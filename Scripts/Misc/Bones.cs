//Created by Peoharen for the Mobile Abilities Package.
//ID's bard 3786, rogue 3788, mage 3790, warrior 3792, healer 3794.
using System; 
using Server; 
using Server.Items;

namespace Server.Items
{
	public class BardBones : Bag
	{
		[Constructable]
		public BardBones() : this( 1 )
		{
			Name = "An Unknown Bard's Skeleton";
			Movable = true;
			GumpID = 9;
			ItemID = 3786;
		}

		[Constructable]
		public BardBones( int amount )
		{
			DropItem( new BodySash( 0x159 ) );
			DropItem( new Sandals( 0x0 ) );
			DropItem( new Lute( ) );
			DropItem( new Gold( 260, 350 ) );
			DropItem( new LongPants( 0x45E ) );
			DropItem( new FancyShirt( 0x4D1 ) );
		}

		public BardBones( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			if ( ItemID == 3787 )
				ItemID = 3786;
		}
	}

	public class RogueBones : Bag
	{
		[Constructable]
		public RogueBones() : this( 1 )
		{ 
			Name = "An Unknown Rogue's Skeleton";
			Movable = true;
			GumpID = 9;
			ItemID = 3788;
		}

		[Constructable]
		public RogueBones( int amount )
		{
			DropItem( new Cloak( 0x66B ) );
			DropItem( new LongPants( 0x6B6 ) );
			DropItem( new Lantern( ) );
			DropItem( new Gold( 260, 350 ) );
			DropItem( new Dagger( ) );
		}

		public RogueBones( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			if ( ItemID == 3787 )
				ItemID = 3788;
		}
	}

	public class MageBones : Bag
	{ 
		[Constructable]
		public MageBones() : this( 1 )
		{
			Name = "An Unknown Mage's Skeleton";
			Movable = true;
			GumpID = 9;
			ItemID = 3790;
		}

		[Constructable]
		public MageBones( int amount )
		{
			DropItem( new Robe( 0x52B ) );
			DropItem( new Shoes( 0x6B6 ) );
			DropItem( new WizardsHat( 0x52B ) );
			DropItem( new Gold( 260, 350 ) );
		}

		public MageBones( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			if ( ItemID == 3787 )
				ItemID = 3790;
		}
	}

	public class WarriorBones : Bag
	{ 
		[Constructable]
		public WarriorBones() : this( 1 )
		{
			Name = "An Unknown Warrior's Skeleton";
			Movable = true;
			GumpID = 9;
			ItemID = 3792;
		}

		[Constructable]
		public WarriorBones( int amount )
		{
			DropItem( new LeatherChest() );
			DropItem( new Boots( 0x6B6 ) );
			DropItem( new Broadsword() );
			DropItem( new Gold( 260, 350 ) );
		}

		public WarriorBones( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			if ( ItemID == 3787 )
				ItemID = 3792;
		}
	}

	public class HealerBones : Bag
	{ 
		[Constructable]
		public HealerBones() : this( 1 )
		{
			Name = "An Unknown Healer's Skeleton";
			Movable = true;
			GumpID = 9;
			ItemID = 3794;
		}

		[Constructable]
		public HealerBones( int amount )
		{
			DropItem( new Robe( Utility.RandomYellowHue() ) );
			DropItem( new Sandals( 0x6B6 ) );
			DropItem( new Bandage( Utility.RandomMinMax( 1, 5 ) ) );
			DropItem( new HealPotion() );
			DropItem( new CurePotion() );
		}

		public HealerBones( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			if ( ItemID == 3787 )
				ItemID = 3794;
		}
	}

}
