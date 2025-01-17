using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	// Based off a Kryss
	[FlipableAttribute( 0x8FE, 0x4072 )]
	public class LifeSyphon : BaseSword
	{
        public override int LabelNumber { get { return 1113524; } }///Life Syphon

		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.BleedAttack; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ParalyzingBlow; } }

		public override int AosStrengthReq{ get{ return 10; } }
		public override int AosMinDamage{ get{ return 10; } }
		public override int AosMaxDamage{ get{ return 12; } }
		public override int AosSpeed{ get{ return 53; } }
		public override float MlSpeed{ get{ return 2.00f; } }

		public override int OldStrengthReq{ get{ return 10; } }
		public override int OldMinDamage{ get{ return 3; } }
		public override int OldMaxDamage{ get{ return 28; } }
		public override int OldSpeed{ get{ return 53; } }

		public override int DefHitSound{ get{ return 0x23C; } }
		public override int DefMissSound{ get{ return 0x238; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		public override SkillName DefSkill{ get{ return SkillName.Fencing; } }
		public override WeaponType DefType{ get{ return WeaponType.Piercing; } }
		public override WeaponAnimation DefAnimation{ get{ return WeaponAnimation.Pierce1H; } }

        public override Race RequiredRace { get { return Race.Gargoyle; } }
        public override bool CanBeWornByGargoyles { get { return true; } }

		[Constructable]
		public LifeSyphon() : base( 0x8FE )
		{
			Weight = 4.0;
            Hue = 37;

            WeaponAttributes.BloodDrinker = 25;
            WeaponAttributes.HitLeechHits = 100;
            WeaponAttributes.HitHarm = 30;
            Attributes.BonusStr = 10;
            Attributes.WeaponSpeed = 25;
            Attributes.WeaponDamage = 50;
		}

		public LifeSyphon( Serial serial ) : base( serial )
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
		}
	}
}