using System;
using Server;
using Server.Items;
using Server.Misc;

namespace Server.Mobiles
{
	[CorpseName( "a Black Order Grand Mage corpse" )] 
	public class DragonsFlameGrandMage : DragonsFlameMage
	{	
		public override bool AlwaysMurderer{ get{ return true; } }
		public override bool ShowFameTitle{ get{ return false; } }


            [Constructable]
		public DragonsFlameGrandMage() : base()
		{
			Name = "Black Order Grand Mage";
			Title = "of the Dragon's Flame Sect";
		}

		public DragonsFlameGrandMage( Serial serial ) : base( serial )
		{
		}
		
		public override void GenerateLoot()
		{
			AddLoot( LootPack.AosFilthyRich, 6 );
		}

        public override void AlterMeleeDamageFrom(Mobile from, ref int damage)
        {
            if (from != null)
                from.Damage(damage / 2, from);
        }

        public override void OnDeath(Container c)
        {
            base.OnDeath(c);

            if (Utility.RandomDouble() < 0.3)
                c.DropItem(new DragonFlameKey());
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
		}
	}
}
