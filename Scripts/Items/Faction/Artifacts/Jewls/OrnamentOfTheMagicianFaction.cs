//System Created by Xeonlive
//Check Out http://xeonlive.com
using System;
using System.Collections;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Targeting;
using Server.Spells;
using Server.Spells.Necromancy;
using Server.Spells.First;
using Server.Spells.Second;
using Server.Spells.Fourth;
using Server.Spells.Fifth;
using Server.Network;
using Server.ContextMenus;
using Server.Factions;

namespace Server.Items
{
	public class OrnamentOfTheMagicianFaction : GoldBracelet
	{
		public override int LabelNumber{ get{ return 1061105; } } // Ornament of the Magician
		public override int ArtifactRarity{ get{ return 11; } }
		
				#region FactionOwner
		private Mobile m_Owner; 
				
		[CommandProperty( AccessLevel.GameMaster )]
		public Mobile Owner
		{
			get{ return m_Owner; }
			set{ m_Owner = value; InvalidateProperties(); }
		}
		#endregion

		[Constructable]
		public OrnamentOfTheMagicianFaction( Faction faction, Mobile mobile ) : base()
		{
			Hue = 0x554;
			Attributes.CastRecovery = 3;
			Attributes.CastSpeed = 2;
			Attributes.LowerManaCost = 10;
			Attributes.LowerRegCost = 20;
			Resistances.Energy = 15;
			Attributes.RegenMana = 3;
			m_Owner = mobile;
		}

		public OrnamentOfTheMagicianFaction( Serial serial ) : base( serial )
		{
		}

		#region FactionOwner	
		public override bool CanEquip( Mobile m )
		{
			PlayerState pl = PlayerState.Find( m );

			if ( pl == null )
			{
				m.SendLocalizedMessage( 1010371 ); // You cannot use faction item
				return false;
			}
			else if ( pl.Rank.Rank < 10 )
{
				m.SendLocalizedMessage( 1094804 ); //rank
				return false;
			}

			
			if ( m_Owner == null || m_Owner == m )
			return true;
			return false;
			
		}
		
		public override void OnAdded( object parent )
		{
			if ( parent is Mobile )
			{
				Mobile from = (Mobile)parent;

				if ( m_Owner == null )
				{
					m_Owner = (Mobile) parent;
				}
				
			}
			InvalidateProperties();
			
			base.OnAdded( parent );
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );
				
			if ( m_Owner != null )
				list.Add( 1072304, m_Owner.Name ); // Owned by ~1_name~
				list.Add(1041350);
		}
				private static void SetSaveFlag( ref SaveFlag flags, SaveFlag toSet, bool setIf )
		{
			if ( setIf )
				flags |= toSet;
		}

		private static bool GetSaveFlag( SaveFlag flags, SaveFlag toGet )
		{
			return ( (flags & toGet) != 0 );
		}
		[Flags]
		private enum SaveFlag
		{
			None				= 0x00000000,
			Owner				= 0x00000001,

		}
		#endregion
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			
			writer.Write( (int) 0 ); // version
				
			#region FactionOwner	
			SaveFlag flags = SaveFlag.None;
		
			SetSaveFlag( ref flags, SaveFlag.Owner,				m_Owner != null );
			
			writer.WriteEncodedInt( (int) flags );
			
			if ( GetSaveFlag( flags, SaveFlag.Owner ) )
				writer.Write( (Mobile) m_Owner );
			#endregion
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			
			int version = reader.ReadInt();
			
			#region FactionOwner	
			switch ( version )
			{
				case 0:
				{
					SaveFlag flags = (SaveFlag) reader.ReadEncodedInt();
						
					if ( GetSaveFlag( flags, SaveFlag.Owner ) )
						m_Owner = reader.ReadMobile();
						break;
				}
			} 
			#endregion
		}
	}
}