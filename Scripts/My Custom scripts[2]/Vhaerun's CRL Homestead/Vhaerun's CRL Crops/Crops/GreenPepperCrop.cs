using System; 
using System.Collections;
using Server.Network; 
using Server.Mobiles; 
using Server.Items; 
using Server.Gumps;

namespace Server.Items.Crops 
{ 
	public class GreenPepperSeed : BaseCrop 
	{ 
		// return true to allow planting on Dirt Item (ItemID 0x32C9)
		// See CropHelper.cs for other overriddable types
		public override bool CanGrowGarden{ get{ return true; } }
		
		[Constructable]
		public GreenPepperSeed() : this( 1 )
		{
		}

		[Constructable]
		public GreenPepperSeed( int amount ) : base( 0xF27 )
		{
			Stackable = true; 
			Weight = .5; 
			Hue = 0x5E2; 

			Movable = true; 
			
			Amount = amount;
			Name = "Green Pepper Seed"; 
		}
		public override void OnDoubleClick( Mobile from ) 
		{ 
			if ( from.Mounted && !CropHelper.CanWorkMounted )
			{
				from.SendMessage( "You cannot plant a seed while mounted." ); 
				return; 
			}

			Point3D m_pnt = from.Location;
			Map m_map = from.Map;

			if ( !IsChildOf( from.Backpack ) ) 
			{ 
				from.SendLocalizedMessage( 1042010 ); //You must have the object in your backpack to use it. 
				return; 
			} 

			else if ( !CropHelper.CheckCanGrow( this, m_map, m_pnt.X, m_pnt.Y ) )
			{
				from.SendMessage( "This seed will not grow here." ); 
				return; 
			}
			
			//check for BaseCrop on this tile
			ArrayList cropshere = CropHelper.CheckCrop( m_pnt, m_map, 0 );
			if ( cropshere.Count > 0 )
			{
				from.SendMessage( "There is already a crop growing here." ); 
				return;
			}

			//check for over planting prohibt if 4 maybe 3 neighboring crops
			ArrayList cropsnear = CropHelper.CheckCrop( m_pnt, m_map, 1 );
			if ( ( cropsnear.Count > 3 ) || (( cropsnear.Count == 3 ) && Utility.RandomBool() ) )
			{
				from.SendMessage( "There are too many crops nearby." ); 
				return;
			}

			if ( this.BumpZ ) ++m_pnt.Z;

			if ( !from.Mounted )
				from.Animate( 32, 5, 1, true, false, 0 ); // Bow

			from.SendMessage("You plant the seed."); 
			this.Consume(); 
			Item item = new GreenPepperSeedling( from ); 
			item.Location = m_pnt; 
			item.Map = m_map; 
			
		} 

		public GreenPepperSeed( Serial serial ) : base( serial ) 
		{ 
		} 

		public override void Serialize( GenericWriter writer ) 
		{ 
			base.Serialize( writer ); 
			writer.Write( (int) 0 ); 
		} 

		public override void Deserialize( GenericReader reader ) 
		{ 
			base.Deserialize( reader ); 
			int version = reader.ReadInt(); 
		} 
	} 


	public class GreenPepperSeedling : BaseCrop 
	{ 
		private Mobile m_sower;
		public Timer thisTimer;

		[CommandProperty( AccessLevel.GameMaster )]
		public Mobile Sower{ get{ return m_sower; } set{ m_sower = value; } }
		
		[Constructable] 
		public GreenPepperSeedling( Mobile sower ) : base( Utility.RandomList ( 0xCB6, 0xCB0 ) ) 
		{ 
			Movable = false; 
			Name = "Green Pepper Seedling"; 
			m_sower = sower;
			
			init( this );
		} 

		public static void init( GreenPepperSeedling plant )
		{
			plant.thisTimer = new CropHelper.GrowTimer( plant, typeof(GreenPepperCrop), plant.Sower ); 
			plant.thisTimer.Start(); 
		}

		public override void OnDoubleClick( Mobile from ) 
		{ 
			if ( from.Mounted && !CropHelper.CanWorkMounted )
			{
				from.SendMessage( "The crop is too small to harvest while mounted." ); 
				return; 
			}

			if ( ( Utility.RandomDouble() <= .25 ) && !( m_sower.AccessLevel > AccessLevel.Counselor ) ) 
			{ //25% Chance
				from.SendMessage( "You uproot the seedling." ); 
				thisTimer.Stop();
				this.Delete();
			}
			else from.SendMessage( "This crop is too young to harvest." ); 
		}

		public GreenPepperSeedling( Serial serial ) : base( serial ) 
		{ 
		} 

		public override void Serialize( GenericWriter writer ) 
		{ 
			base.Serialize( writer ); 
			writer.Write( (int) 0 ); 
			writer.Write( m_sower );
		} 

		public override void Deserialize( GenericReader reader ) 
		{ 
			base.Deserialize( reader ); 
			int version = reader.ReadInt(); 
			m_sower = reader.ReadMobile();

			init( this );
		} 
	} 

	public class GreenPepperCrop : BaseCrop 
	{ 
		private const int max = 10;
		private int fullGraphic;
		private int pickedGraphic;
		private DateTime lastpicked;

		private Mobile m_sower;
		private int m_yield;

		public Timer regrowTimer;

		private DateTime m_lastvisit;

		[CommandProperty( AccessLevel.GameMaster )] 
		public DateTime LastSowerVisit{ get{ return m_lastvisit; } }

		[CommandProperty( AccessLevel.GameMaster )] // debuging
		public bool Growing{ get{ return regrowTimer.Running; } }

		[CommandProperty( AccessLevel.GameMaster )]
		public Mobile Sower{ get{ return m_sower; } set{ m_sower = value; } }
		
		[CommandProperty( AccessLevel.GameMaster )]
		public int Yield{ get{ return m_yield; } set{ m_yield = value; } }

		public int Capacity{ get{ return max; } }
		public int FullGraphic{ get{ return fullGraphic; } set{ fullGraphic = value; } }
		public int PickGraphic{ get{ return pickedGraphic; } set{ pickedGraphic = value; } }
		public DateTime LastPick{ get{ return lastpicked; } set{ lastpicked = value; } }
		
		[Constructable] 
		public GreenPepperCrop( Mobile sower ) : base( Utility.RandomList( 0xCE9, 0xCEA ) ) 
		{ 
			Movable = false; 
			Name = "Green Pepper Plant";
			Hue = 0x41;

			m_sower = sower;
			m_lastvisit = DateTime.Now;

			init( this, false );
		}

		public static void init ( GreenPepperCrop plant, bool full )
		{
			plant.PickGraphic = Utility.RandomList( 0xCE9, 0xCEA );
			plant.FullGraphic = Utility.RandomList( 0xCE9, 0xCEA );

			plant.LastPick = DateTime.Now;
			plant.regrowTimer = new CropTimer( plant );

			if ( full )
			{
				plant.Yield = plant.Capacity;
				((Item)plant).ItemID = plant.FullGraphic;
			}
			else
			{
				plant.Yield = 0;
				((Item)plant).ItemID = plant.PickGraphic;
				plant.regrowTimer.Start();
			}
		}
		
		public void UpRoot( Mobile from )
		{
			from.SendMessage( "The crop withers away." ); 
			if ( regrowTimer.Running )
				regrowTimer.Stop();

			this.Delete();
		}

		public override void OnDoubleClick( Mobile from ) 
		{ 
			if ( m_sower == null || m_sower.Deleted ) 
				m_sower = from;

			if ( from.Mounted && !CropHelper.CanWorkMounted )
			{
				from.SendMessage( "You cannot harvest a crop while mounted." ); 
				return; 
			}

			if ( DateTime.Now > lastpicked.AddSeconds(3) ) // 3 seconds between picking
			{
				lastpicked = DateTime.Now;
			
				int tailorValue = (int)from.Skills[SkillName.Tailoring].Value / 20;
				if ( tailorValue == 0 )
				{
					from.SendMessage( "You have no idea how to harvest this crop." ); 
					return;
				}

				if ( from.InRange( this.GetWorldLocation(), 1 ) ) 
				{ 
					if ( m_yield < 1 )
					{
						from.SendMessage( "There is nothing here to harvest." ); 

						if ( PlayerCanDestroy && !( m_sower.AccessLevel > AccessLevel.Counselor ) )
						{  
							UpRootGump g = new UpRootGump( from, this );
							from.SendGump( g );
						}
					}
					else //check skill and sower
					{
						from.Direction = from.GetDirectionTo( this );

						from.Animate( from.Mounted ? 29:32, 5, 1, true, false, 0 ); 

						if ( from == m_sower ) 
						{
							tailorValue *= 2;
							m_lastvisit = DateTime.Now;
						}

						if ( tailorValue > m_yield ) 
							tailorValue = m_yield + 1;

						int pick = Utility.Random( tailorValue );
						if ( pick == 0 )
						{
							from.SendMessage( "You do not manage to harvest any crops." ); 
							return;
						}
					
						m_yield -= pick;
						from.SendMessage( "You harvest {0} crop{1}!", pick, ( pick == 1 ? "" : "s" ) ); 

						//PublicOverheadMessage( MessageType.Regular, 0x3BD, false, string.Format( "{0}", m_yield )); 
						((Item)this).ItemID = pickedGraphic;

						GreenPepper crop = new GreenPepper( pick ); 
						from.AddToBackpack( crop );

						if ( SowerPickTime != TimeSpan.Zero && m_lastvisit + SowerPickTime < DateTime.Now && !( m_sower.AccessLevel > AccessLevel.Counselor ) )
						{
							this.UpRoot( from );
							return;
						}

						if ( !regrowTimer.Running )
						{
							//regrowTimer = new CropTimer( this );
							regrowTimer.Start();
						}
					}
				} 
				else 
				{ 
					from.SendMessage( "You are too far away to harvest anything." ); 
				} 
			}
		} 

		private class CropTimer : Timer
		{
			private GreenPepperCrop i_plant;

			public CropTimer( GreenPepperCrop plant ) : base( TimeSpan.FromSeconds( 600 ), TimeSpan.FromSeconds( 15 ) )
			{
				Priority = TimerPriority.OneSecond;
				i_plant = plant;
			}

			protected override void OnTick()
			{
				if ( ( i_plant != null ) && ( !i_plant.Deleted ) )
				{
					int current = i_plant.Yield;

					if ( ++current >= i_plant.Capacity )
					{
						current = i_plant.Capacity;
						((Item)i_plant).ItemID = i_plant.FullGraphic;
						Stop();
					}
					else if ( current <= 0 )
						current = 1;

					i_plant.Yield = current;
					//i_plant.PublicOverheadMessage( MessageType.Regular, 0x22, false, string.Format( "{0}", current )); 
				}
				else Stop();
			}
		}

		public GreenPepperCrop( Serial serial ) : base( serial ) 
		{ 
		} 

		public override void Serialize( GenericWriter writer ) 
		{ 
			base.Serialize( writer ); 
			writer.Write( (int) 1 ); 
			writer.Write( m_lastvisit );
			writer.Write( m_sower );
		} 

		public override void Deserialize( GenericReader reader ) 
		{ 
			base.Deserialize( reader ); 
			int version = reader.ReadInt(); 
			switch ( version )
			{
				case 1:
				{
					m_lastvisit = reader.ReadDateTime();
					goto case 0;
				}
				case 0:
				{
					m_sower = reader.ReadMobile();
					break;
				}
			}

			if ( version == 0 ) 
				m_lastvisit = DateTime.Now;

			init( this, true );
		} 
	} 
} 
