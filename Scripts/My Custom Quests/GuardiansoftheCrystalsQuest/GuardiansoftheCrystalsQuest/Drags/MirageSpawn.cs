using System;
using System.Collections;
using System.Collections.Generic;
using Server.Items;
using Server.Targeting;
using Server.ContextMenus;

namespace Server.Mobiles
{
	[CorpseName( "a mirage spawn corpse" )]
	public class MirageSpawn : BaseCreature
	{
		private Mobile m_Owner;
		private DateTime m_ExpireTime;

		[CommandProperty( AccessLevel.GameMaster )]
		public Mobile Owner
		{
			get{ return m_Owner; }
			set{ m_Owner = value; }
		}

		[CommandProperty( AccessLevel.GameMaster )]
		public DateTime ExpireTime
		{
			get{ return m_ExpireTime; }
			set{ m_ExpireTime = value; }
		}

		[Constructable]
		public MirageSpawn() : this( null )
		{
		}

		public override bool AlwaysMurderer{ get{ return true; } }

		public override void DisplayPaperdollTo(Mobile to)
		{
		}

		public override void GetContextMenuEntries( Mobile from, List<ContextMenuEntry> list )
		{
			base.GetContextMenuEntries( from, list );

			for ( int i = 0; i < list.Count; ++i )
			{
				if ( list[i] is ContextMenus.PaperdollEntry )
					list.RemoveAt( i-- );
			}
		}

		public override void OnThink()
		{
			bool expired;

			expired = ( DateTime.Now >= m_ExpireTime );

			if ( !expired && m_Owner != null )
				expired = m_Owner.Deleted || Map != m_Owner.Map || !InRange( m_Owner, 16 );

			if ( expired )
			{
				PlaySound( GetIdleSound() );
				Delete();
			}
			else
			{
				base.OnThink();
			}
		}

		public MirageSpawn( Mobile owner ) : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			m_Owner = owner;
			m_ExpireTime = DateTime.Now + TimeSpan.FromMinutes( 1.0 );

			Name = "a mirage spawn";
			Hue = 1267;
			Body = 103;
			BaseSoundID = 362;				

			SetStr( 201, 300 );
			SetDex( 80 );
			SetInt( 16, 20 );

			SetHits( 121, 180 );

			SetDamage( 11, 17 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 35, 45 );
			SetResistance( ResistanceType.Fire, 30, 40 );
			SetResistance( ResistanceType.Cold, 25, 35 );
			SetResistance( ResistanceType.Poison, 65, 75 );
			SetResistance( ResistanceType.Energy, 25, 35 );

			SetSkill( SkillName.MagicResist, 25.0 );
			SetSkill( SkillName.Tactics, 25.0 );
			SetSkill( SkillName.Wrestling, 50.0 );

			Fame = 1000;
			Karma = -1000;

			VirtualArmor = 20;
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Poor );
			AddLoot( LootPack.Gems );
		}

		public MirageSpawn( Serial serial ) : base( serial )
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
}