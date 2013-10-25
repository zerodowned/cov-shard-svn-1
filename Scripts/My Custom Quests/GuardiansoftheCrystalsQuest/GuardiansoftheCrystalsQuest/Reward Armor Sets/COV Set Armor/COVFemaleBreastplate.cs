using System;
using Server.Items;

namespace Server.Items
{
	public class COVFemaleBreastplate : FemalePlateChest
	{
		public override int LabelNumber{ get{ return 1080164; } }
		
		public override SetItem SetID{ get{ return SetItem.COV; } }
		public override int Pieces{ get{ return 6; } }

        public override int BasePhysicalResistance { get { return 8; } }
        public override int BaseFireResistance { get { return 5; } }
        public override int BaseColdResistance { get { return 5; } }
        public override int BasePoisonResistance { get { return 7; } }
        public override int BaseEnergyResistance { get { return 5; } }

		[Constructable]
		public COVFemaleBreastplate() : base()
		{
			SetHue = 2224;					
			
			Attributes.BonusHits = 1;

            SetAttributes.RegenHits = 2;
            SetAttributes.RegenMana = 2;
            SetAttributes.DefendChance = 10;
            SetAttributes.AttackChance = 10;
			
			SetSelfRepair = 3;

            SetPhysicalBonus = 5;
            SetFireBonus = 5;
            SetColdBonus = 5;
            SetPoisonBonus = 5;
            SetEnergyBonus = 5;
		}

		public COVFemaleBreastplate( Serial serial ) : base( serial )
		{
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			
			writer.Write( (int) 0 ); 
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			
			int version = reader.ReadInt();
		}
	}
}