using System;
using Server.Network;

namespace Server.Items
{
	public class Kiwi : Food
	{
		[Constructable]
		public Kiwi() : this( 1 )
		{
		}

		[Constructable]
		public Kiwi( int amount ) : base( amount, 0xF8B )
		{
			this.Weight = 1.0;
			this.FillFactor = 1;
			this.Hue = 0x458;
			this.Name = "Kiwi";
		}

		public Kiwi( Serial serial ) : base( serial )
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