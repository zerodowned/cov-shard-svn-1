

using System;
using System.Collections.Generic;
using Server.Multis;
using Server.Targeting;
using Server;

namespace Server.Items
{
	

	public class GreenFloralCarpetAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new GreenFloralCarpetDeed(); } }
		
		private enum RugPiece
		{
			Top,
			Bottom,
			Right,
			Left,
			TopRight,
			TopLeft,
			BottomRight,
			BottomLeft,
			Center
		}
		
		private int RugPieceId( RugPiece whichPiece )
		{

					switch ( whichPiece )
					{
						case RugPiece.Top: return 0xAF3;
						case RugPiece.Bottom: return 0xAF5;
						case RugPiece.Left: return 0xAF2;
						case RugPiece.Right: return 0xAF4;
						case RugPiece.TopLeft: return 0xAEF;
						case RugPiece.TopRight: return 0xAF1;
						case RugPiece.BottomLeft: return 0xAF0;
						case RugPiece.BottomRight: return 0xAEE;
						default: return 0xAED;
					}
	
		}

		[Constructable]
		public GreenFloralCarpetAddon( Rectangle2D rect )
		{
				
			for ( int x = 0; x < rect.Width; x++ )
				for ( int y = 0; y < rect.Height; y++ )
				{
					if ( y == 0 && x != 0 && x != rect.Width - 1 )
						AddComponent( new AddonComponent( RugPieceId(  RugPiece.Top ) ), x, y, 0 );
					if ( y == rect.Height - 1 && x != 0 && x != rect.Width - 1 )
						AddComponent( new AddonComponent( RugPieceId(  RugPiece.Bottom ) ), x, y, 0 );
					if ( x == 0 && y != 0 && y != rect.Height - 1 )
						AddComponent( new AddonComponent( RugPieceId(  RugPiece.Left ) ), x, y, 0 );
					if ( x == rect.Width - 1 && y != 0 && y != rect.Height - 1 )
						AddComponent( new AddonComponent( RugPieceId(  RugPiece.Right ) ), x, y, 0 );
					if ( y == 0 && x == 0 )
						AddComponent( new AddonComponent( RugPieceId(  RugPiece.TopLeft ) ), x, y, 0 );
					if ( y == 0 && x == rect.Width - 1 )
						AddComponent( new AddonComponent( RugPieceId(  RugPiece.TopRight ) ), x, y, 0 );
					if ( y == rect.Height - 1 && x == 0 )
						AddComponent( new AddonComponent( RugPieceId(  RugPiece.BottomLeft ) ), x, y, 0 );
					if ( y == rect.Height - 1 && x == rect.Width - 1 )
						AddComponent( new AddonComponent( RugPieceId(  RugPiece.BottomRight ) ), x, y, 0 );
					if ( y != 0 && x != 0  && x != rect.Width - 1  && y != rect.Height - 1 )
						AddComponent( new AddonComponent( RugPieceId(  RugPiece.Center ) ), x, y, 0 );
				}
				
			Hue = 1419; // Set Hue of Rug Here
				
		}

		public GreenFloralCarpetAddon( Serial serial ) : base( serial )
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

	public class GreenFloralCarpetDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return null; } }
		

		[Constructable]
		public GreenFloralCarpetDeed( )
		{
			Name =  "Green Floral Carpet";
		}

		public GreenFloralCarpetDeed( Serial serial ) : base( serial )
		{
		}

		public override void OnDoubleClick( Mobile from )
		{
			if ( IsChildOf( from.Backpack ) )
				BoundingBoxPicker.Begin( from, new BoundingBoxCallback( BuildRugBox_Callback ), this );
			else
				from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
		}

		private static void BuildRugBox_Callback( Mobile from, Map map, Point3D start, Point3D end, object state )
		{
			GreenFloralCarpetDeed m_Deed = state as GreenFloralCarpetDeed;

			if ( m_Deed.Deleted )
				return;

			if ( m_Deed.IsChildOf( from.Backpack ) )
			{
				Rectangle2D rect = new Rectangle2D( start.X, start.Y, end.X - start.X + 1, end.Y - start.Y + 1 );

				if ( rect.Width < 3 || rect.Height < 3 )
				{
					from.SendMessage( "The carpet is too small. It should be longer or wider than that." );
					return;
				}

				BaseAddon addon = new GreenFloralCarpetAddon( rect );

				BaseHouse house = null;

				AddonFitResult res = addon.CouldFit( start, map, from, ref house );

				if ( res == AddonFitResult.Valid )
					addon.MoveToWorld( start, map );
				else if ( res == AddonFitResult.Blocked )
					from.SendLocalizedMessage( 500269 ); // You cannot build that there.
				else if ( res == AddonFitResult.NotInHouse )
					from.SendLocalizedMessage( 500274 ); // You can only place this in a house that you own!
				else if ( res == AddonFitResult.DoorsNotClosed )
					from.SendMessage( "You must close all house doors before placing this." );
				else if ( res == AddonFitResult.DoorTooClose )
					from.SendLocalizedMessage( 500271 ); // You cannot build near the door.
					
				if ( res == AddonFitResult.Valid )
				{
					m_Deed.Delete();

					//if ( house != null )
					//{
						//foreach ( Server.Multis.BaseHouse h in house )
							house.Addons.Add( addon );
					//}
				}
				else
				{
					addon.Delete();
				}
			}
			else
			{
				from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
			}
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