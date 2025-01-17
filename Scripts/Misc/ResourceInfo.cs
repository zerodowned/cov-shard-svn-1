using System;
using System.Collections;

namespace Server.Items
{
	public enum CraftResource
	{
		None = 0,
		Iron = 1,
		DullCopper,
		ShadowIron,
		Copper,
		Bronze,
		Gold,
		Agapite,
		Verite,
		Valorite,
		Silver,
		//Platinum,
		//Mythril,
		//Obsidian,
		Jade,
		Moonstone,
		Sunstone,
		//Bloodstone,

		RegularLeather = 101,
		SpinedLeather,
		HornedLeather,
		BarbedLeather,
		DragonLeather,
		DaemonLeather,

		RedScales = 201,
		YellowScales,
		BlackScales,
		GreenScales,
		WhiteScales,
		BlueScales,
        MedusaLightScales,
        MedusaDarkScales,
		
		//#region Mondain's Legacy
		Log = 301,
		Oak,
		Ash,
		Yew,
		Heartwood,
		Bloodwood,
		Frostwood,
        Pine,
        Cedar,
        Cherry,
        Mahogany,
		//#endregion
	}

	public enum CraftResourceType
	{
		None,
		Metal,
		Leather,
		Scales,
		Wood
	}

	public class CraftAttributeInfo
	{
		private int m_WeaponFireDamage;
		private int m_WeaponColdDamage;
		private int m_WeaponPoisonDamage;
		private int m_WeaponEnergyDamage;
		private int m_WeaponChaosDamage;
		private int m_WeaponDirectDamage;
		private int m_WeaponDurability;
		private int m_WeaponLuck;
		private int m_WeaponGoldIncrease;
		private int m_WeaponLowerRequirements;

		private int m_ArmorPhysicalResist;
		private int m_ArmorFireResist;
		private int m_ArmorColdResist;
		private int m_ArmorPoisonResist;
		private int m_ArmorEnergyResist;
		private int m_ArmorDurability;
		private int m_ArmorLuck;
		private int m_ArmorGoldIncrease;
		private int m_ArmorLowerRequirements;

		private int m_RunicMinAttributes;
		private int m_RunicMaxAttributes;
		private int m_RunicMinIntensity;
		private int m_RunicMaxIntensity;

		public int WeaponFireDamage{ get{ return m_WeaponFireDamage; } set{ m_WeaponFireDamage = value; } }
		public int WeaponColdDamage{ get{ return m_WeaponColdDamage; } set{ m_WeaponColdDamage = value; } }
		public int WeaponPoisonDamage{ get{ return m_WeaponPoisonDamage; } set{ m_WeaponPoisonDamage = value; } }
		public int WeaponEnergyDamage{ get{ return m_WeaponEnergyDamage; } set{ m_WeaponEnergyDamage = value; } }
		public int WeaponChaosDamage{ get{ return m_WeaponChaosDamage; } set{ m_WeaponChaosDamage = value; } }
		public int WeaponDirectDamage{ get{ return m_WeaponDirectDamage; } set{ m_WeaponDirectDamage = value; } }
		public int WeaponDurability{ get{ return m_WeaponDurability; } set{ m_WeaponDurability = value; } }
		public int WeaponLuck{ get{ return m_WeaponLuck; } set{ m_WeaponLuck = value; } }
		public int WeaponGoldIncrease{ get{ return m_WeaponGoldIncrease; } set{ m_WeaponGoldIncrease = value; } }
		public int WeaponLowerRequirements{ get{ return m_WeaponLowerRequirements; } set{ m_WeaponLowerRequirements = value; } }

		public int ArmorPhysicalResist{ get{ return m_ArmorPhysicalResist; } set{ m_ArmorPhysicalResist = value; } }
		public int ArmorFireResist{ get{ return m_ArmorFireResist; } set{ m_ArmorFireResist = value; } }
		public int ArmorColdResist{ get{ return m_ArmorColdResist; } set{ m_ArmorColdResist = value; } }
		public int ArmorPoisonResist{ get{ return m_ArmorPoisonResist; } set{ m_ArmorPoisonResist = value; } }
		public int ArmorEnergyResist{ get{ return m_ArmorEnergyResist; } set{ m_ArmorEnergyResist = value; } }
		public int ArmorDurability{ get{ return m_ArmorDurability; } set{ m_ArmorDurability = value; } }
		public int ArmorLuck{ get{ return m_ArmorLuck; } set{ m_ArmorLuck = value; } }
		public int ArmorGoldIncrease{ get{ return m_ArmorGoldIncrease; } set{ m_ArmorGoldIncrease = value; } }
		public int ArmorLowerRequirements{ get{ return m_ArmorLowerRequirements; } set{ m_ArmorLowerRequirements = value; } }

		public int RunicMinAttributes{ get{ return m_RunicMinAttributes; } set{ m_RunicMinAttributes = value; } }
		public int RunicMaxAttributes{ get{ return m_RunicMaxAttributes; } set{ m_RunicMaxAttributes = value; } }
		public int RunicMinIntensity{ get{ return m_RunicMinIntensity; } set{ m_RunicMinIntensity = value; } }
		public int RunicMaxIntensity{ get{ return m_RunicMaxIntensity; } set{ m_RunicMaxIntensity = value; } }

		//#region Mondain's Legacy		
		private int m_WeaponDamage;
		private int m_WeaponHitChance;
		private int m_WeaponHitLifeLeech;
		private int m_WeaponRegenHits;
		private int m_WeaponSwingSpeed;
		
		private int m_ArmorDamage;
		private int m_ArmorHitChance;
		private int m_ArmorRegenHits;
		private int m_ArmorMage;
		
		private int m_ShieldPhysicalResist;
		private int m_ShieldFireResist;
		private int m_ShieldColdResist;
		private int m_ShieldPoisonResist;
		private int m_ShieldEnergyResist;
		
		public int WeaponDamage{ get{ return m_WeaponDamage; } set{ m_WeaponDamage = value; } }
		public int WeaponHitChance{ get{ return m_WeaponHitChance; } set{ m_WeaponHitChance = value; } }
		public int WeaponHitLifeLeech{ get{ return m_WeaponHitLifeLeech; } set{ m_WeaponHitLifeLeech = value; } }
		public int WeaponRegenHits{ get{ return m_WeaponRegenHits; } set{ m_WeaponRegenHits = value; } }
		public int WeaponSwingSpeed{ get{ return m_WeaponSwingSpeed; } set{ m_WeaponSwingSpeed = value; } }
		
		public int ArmorDamage{ get{ return m_ArmorDamage; } set{ m_ArmorDamage = value; } }
		public int ArmorHitChance{ get{ return m_ArmorHitChance; } set{ m_ArmorHitChance = value; } }
		public int ArmorRegenHits{ get{ return m_ArmorRegenHits; } set{ m_ArmorRegenHits = value; } }
		public int ArmorMage{ get{ return m_ArmorMage; } set{ m_ArmorMage = value; } }
		
		public int ShieldPhysicalResist{ get{ return m_ShieldPhysicalResist; } set{ m_ShieldPhysicalResist = value; } }
		public int ShieldFireResist{ get{ return m_ShieldFireResist; } set{ m_ShieldFireResist = value; } }
		public int ShieldColdResist{ get{ return m_ShieldColdResist; } set{ m_ShieldColdResist = value; } }
		public int ShieldPoisonResist{ get{ return m_ShieldPoisonResist; } set{ m_ShieldPoisonResist = value; } }
		public int ShieldEnergyResist{ get{ return m_ShieldEnergyResist; } set{ m_ShieldEnergyResist = value; } }
		//#endregion

		public CraftAttributeInfo()
		{
		}

		public static readonly CraftAttributeInfo Blank;
		public static readonly CraftAttributeInfo DullCopper, ShadowIron, Copper, Bronze, Golden, Agapite, Verite, Valorite, Silver, Jade, Moonstone, Sunstone;
		public static readonly CraftAttributeInfo Spined, Horned, Barbed, DragonL, Daemon;		
		public static readonly CraftAttributeInfo RedScales, YellowScales, BlackScales, GreenScales, WhiteScales, BlueScales, MedusaLightScales, MedusaDarkScales;
        public static readonly CraftAttributeInfo Oak, Ash, Yew, Bloodwood, Heartwood, Frostwood, Pine, Cedar, Cherry, Mahogany;
		
		static CraftAttributeInfo()
		{
			Blank = new CraftAttributeInfo();

			CraftAttributeInfo dullCopper = DullCopper = new CraftAttributeInfo();

			dullCopper.ArmorPhysicalResist = 6;
			dullCopper.ArmorDurability = 50;
			dullCopper.ArmorLowerRequirements = 20;
			dullCopper.WeaponDurability = 100;
			dullCopper.WeaponLowerRequirements = 50;
			dullCopper.RunicMinAttributes = 1;
			dullCopper.RunicMaxAttributes = 2;
			dullCopper.RunicMinIntensity = 10;
			dullCopper.RunicMaxIntensity = 35;

			CraftAttributeInfo shadowIron = ShadowIron = new CraftAttributeInfo();

			shadowIron.ArmorPhysicalResist = 2;
			shadowIron.ArmorFireResist = 1;
			shadowIron.ArmorEnergyResist = 5;
			shadowIron.ArmorDurability = 100;
			shadowIron.WeaponColdDamage = 20;
			shadowIron.WeaponDurability = 50;
			shadowIron.RunicMinAttributes = 2;
			shadowIron.RunicMaxAttributes = 2;
			shadowIron.RunicMinIntensity = 20;
			shadowIron.RunicMaxIntensity = 45;

			CraftAttributeInfo copper = Copper = new CraftAttributeInfo();

			copper.ArmorPhysicalResist = 1;
			copper.ArmorFireResist = 1;
			copper.ArmorPoisonResist = 5;
			copper.ArmorEnergyResist = 2;
			copper.WeaponPoisonDamage = 10;
			copper.WeaponEnergyDamage = 20;
			copper.RunicMinAttributes = 2;
			copper.RunicMaxAttributes = 3;
			copper.RunicMinIntensity = 25;
			copper.RunicMaxIntensity = 50;

			CraftAttributeInfo bronze = Bronze = new CraftAttributeInfo();

			bronze.ArmorPhysicalResist = 3;
			bronze.ArmorColdResist = 5;
			bronze.ArmorPoisonResist = 1;
			bronze.ArmorEnergyResist = 1;
			bronze.WeaponFireDamage = 40;
			bronze.RunicMinAttributes = 3;
			bronze.RunicMaxAttributes = 3;
			bronze.RunicMinIntensity = 30;
			bronze.RunicMaxIntensity = 65;

			CraftAttributeInfo golden = Golden = new CraftAttributeInfo();

			golden.ArmorPhysicalResist = 1;
			golden.ArmorFireResist = 1;
			golden.ArmorColdResist = 2;
			golden.ArmorEnergyResist = 2;
			golden.ArmorLuck = 40;
			golden.ArmorLowerRequirements = 30;
			golden.WeaponLuck = 40;
			golden.WeaponLowerRequirements = 50;
			golden.RunicMinAttributes = 3;
			golden.RunicMaxAttributes = 4;
			golden.RunicMinIntensity = 35;
			golden.RunicMaxIntensity = 75;

			CraftAttributeInfo agapite = Agapite = new CraftAttributeInfo();

			agapite.ArmorPhysicalResist = 2;
			agapite.ArmorFireResist = 3;
			agapite.ArmorColdResist = 2;
			agapite.ArmorPoisonResist = 2;
			agapite.ArmorEnergyResist = 2;
			agapite.WeaponColdDamage = 30;
			agapite.WeaponEnergyDamage = 20;
			agapite.RunicMinAttributes = 4;
			agapite.RunicMaxAttributes = 4;
			agapite.RunicMinIntensity = 40;
			agapite.RunicMaxIntensity = 80;

			CraftAttributeInfo verite = Verite = new CraftAttributeInfo();

			verite.ArmorPhysicalResist = 3;
			verite.ArmorFireResist = 3;
			verite.ArmorColdResist = 2;
			verite.ArmorPoisonResist = 3;
			verite.ArmorEnergyResist = 1;
			verite.WeaponPoisonDamage = 40;
			verite.WeaponEnergyDamage = 20;
			verite.RunicMinAttributes = 4;
			verite.RunicMaxAttributes = 5;
			verite.RunicMinIntensity = 45;
			verite.RunicMaxIntensity = 90;

			CraftAttributeInfo valorite = Valorite = new CraftAttributeInfo();

			valorite.ArmorPhysicalResist = 4;
			valorite.ArmorColdResist = 3;
			valorite.ArmorPoisonResist = 3;
			valorite.ArmorEnergyResist = 3;
			valorite.ArmorDurability = 50;
			valorite.WeaponFireDamage = 10;
			valorite.WeaponColdDamage = 20;
			valorite.WeaponPoisonDamage = 10;
			valorite.WeaponEnergyDamage = 20;
			valorite.RunicMinAttributes = 5;
			valorite.RunicMaxAttributes = 5;
			valorite.RunicMinIntensity = 50;
			valorite.RunicMaxIntensity = 100;
			
			CraftAttributeInfo silver = Silver = new CraftAttributeInfo();

			silver.ArmorPhysicalResist = 2;
			silver.ArmorColdResist = 5;
			silver.ArmorEnergyResist = 3;
			silver.WeaponColdDamage = 40;
			silver.RunicMinAttributes = 7;
			silver.RunicMaxAttributes = 8;
			silver.RunicMinIntensity = 55;
			silver.RunicMaxIntensity = 105;

			CraftAttributeInfo jade = Jade = new CraftAttributeInfo();

			jade.ArmorPhysicalResist = 5;
			jade.ArmorColdResist = 5;
			jade.ArmorPoisonResist = 6;
			jade.WeaponPoisonDamage = 40;
			jade.RunicMinAttributes = 11;
			jade.RunicMaxAttributes = 12;
			jade.RunicMinIntensity = 60;
			jade.RunicMaxIntensity = 105;
			
			CraftAttributeInfo moonstone = Moonstone = new CraftAttributeInfo();

			moonstone.ArmorPhysicalResist = 7;
			moonstone.ArmorColdResist = 6;
			moonstone.ArmorEnergyResist = 6;
			moonstone.WeaponEnergyDamage = 50;
			moonstone.RunicMinAttributes = 12;
			moonstone.RunicMaxAttributes = 13;
			moonstone.RunicMinIntensity = 65;
			moonstone.RunicMaxIntensity = 110;

			CraftAttributeInfo sunstone = Sunstone = new CraftAttributeInfo();

			sunstone.ArmorPhysicalResist = 7;
			sunstone.ArmorFireResist = 6;
			sunstone.ArmorPoisonResist = 6;
			sunstone.WeaponFireDamage = 60;
			sunstone.WeaponPoisonDamage = 40;
			sunstone.RunicMinAttributes = 13;
			sunstone.RunicMaxAttributes = 14;
			sunstone.RunicMinIntensity = 70;
			sunstone.RunicMaxIntensity = 115;

			CraftAttributeInfo spined = Spined = new CraftAttributeInfo();

			spined.ArmorPhysicalResist = 5;
			spined.ArmorLuck = 40;
			spined.RunicMinAttributes = 1;
			spined.RunicMaxAttributes = 3;
			spined.RunicMinIntensity = 20;
			spined.RunicMaxIntensity = 40;

			CraftAttributeInfo horned = Horned = new CraftAttributeInfo();

			horned.ArmorPhysicalResist = 2;
			horned.ArmorFireResist = 3;
			horned.ArmorColdResist = 2;
			horned.ArmorPoisonResist = 2;
			horned.ArmorEnergyResist = 2;
			horned.RunicMinAttributes = 3;
			horned.RunicMaxAttributes = 4;
			horned.RunicMinIntensity = 30;
			horned.RunicMaxIntensity = 70;

			CraftAttributeInfo barbed = Barbed = new CraftAttributeInfo();

			barbed.ArmorPhysicalResist = 2;
			barbed.ArmorFireResist = 1;
			barbed.ArmorColdResist = 2;
			barbed.ArmorPoisonResist = 3;
			barbed.ArmorEnergyResist = 4;
			barbed.RunicMinAttributes = 4;
			barbed.RunicMaxAttributes = 5;
			barbed.RunicMinIntensity = 40;
			barbed.RunicMaxIntensity = 100;
			
			CraftAttributeInfo dragon = DragonL = new CraftAttributeInfo();

			dragon.ArmorPhysicalResist = 4;
			dragon.ArmorFireResist = 6;
			dragon.ArmorColdResist = 2;
			dragon.ArmorPoisonResist = 3;
			dragon.ArmorEnergyResist = 5;
			dragon.RunicMinAttributes = 12;
			dragon.RunicMaxAttributes = 13;
			dragon.RunicMinIntensity = 60;
			dragon.RunicMaxIntensity = 105;
			
			CraftAttributeInfo daemon = Daemon = new CraftAttributeInfo();

			daemon.ArmorPhysicalResist = 3;
			daemon.ArmorFireResist = 5;
			daemon.ArmorColdResist = 3;
			daemon.ArmorPoisonResist = 3;
			daemon.ArmorEnergyResist = 6;
			daemon.RunicMinAttributes = 13;
			daemon.RunicMaxAttributes = 14;
			daemon.RunicMinIntensity = 70;
			daemon.RunicMaxIntensity = 110;
			
			CraftAttributeInfo red = RedScales = new CraftAttributeInfo();

			red.ArmorFireResist = 10;
			red.ArmorColdResist = -3;

			CraftAttributeInfo yellow = YellowScales = new CraftAttributeInfo();

			yellow.ArmorPhysicalResist = -3;
			yellow.ArmorLuck = 20;

			CraftAttributeInfo black = BlackScales = new CraftAttributeInfo();

			black.ArmorPhysicalResist = 10;
			black.ArmorEnergyResist = -3;

			CraftAttributeInfo green = GreenScales = new CraftAttributeInfo();

			green.ArmorFireResist = -3;
			green.ArmorPoisonResist = 10;

			CraftAttributeInfo white = WhiteScales = new CraftAttributeInfo();

			white.ArmorPhysicalResist = -3;
			white.ArmorColdResist = 10;

			CraftAttributeInfo blue = BlueScales = new CraftAttributeInfo();

			blue.ArmorPoisonResist = -3;
			blue.ArmorEnergyResist = 10;

            CraftAttributeInfo medusalight = MedusaLightScales = new CraftAttributeInfo();

            medusalight.ArmorPoisonResist = -3;
            medusalight.ArmorEnergyResist = 10;

            CraftAttributeInfo medusadark = MedusaDarkScales = new CraftAttributeInfo();

            medusadark.ArmorPoisonResist = -3;
            medusadark.ArmorEnergyResist = 10;
			
			//#region Mondain's Legacy
			CraftAttributeInfo oak = Oak = new CraftAttributeInfo();

			oak.ArmorPhysicalResist = 3;
			oak.ArmorFireResist = 3;
			oak.ArmorPoisonResist = 2;
			oak.ArmorEnergyResist = 3;
			oak.ArmorLuck = 40;
			oak.ShieldPhysicalResist = 1;
			oak.ShieldFireResist = 1;
			oak.ShieldColdResist = 1;
			oak.ShieldPoisonResist = 1;
			oak.ShieldEnergyResist = 1;
			oak.WeaponLuck = 40;
			oak.WeaponDamage = 5;			
			oak.RunicMinAttributes = 1;
			oak.RunicMaxAttributes = 2;
			oak.RunicMinIntensity = 1;
			oak.RunicMaxIntensity = 50;
			
			CraftAttributeInfo ash = Ash = new CraftAttributeInfo();

			ash.ArmorPhysicalResist = 4;
			ash.ArmorFireResist = 2;
			ash.ArmorColdResist = 4;
			ash.ArmorPoisonResist = 1;
			ash.ArmorEnergyResist = 6;
			ash.ArmorLowerRequirements = 20;
			ash.ShieldEnergyResist = 3;
			ash.WeaponSwingSpeed = 10;
			ash.WeaponLowerRequirements = 20;			
			ash.RunicMinAttributes = 2;
			ash.RunicMaxAttributes = 3;
			ash.RunicMinIntensity = 35;
			ash.RunicMaxIntensity = 75;
			
			CraftAttributeInfo yew = Yew = new CraftAttributeInfo();

			yew.ArmorPhysicalResist = 6;
			yew.ArmorFireResist = 3;
			yew.ArmorColdResist = 3;
			yew.ArmorEnergyResist = 3;
			yew.ArmorRegenHits = 1;
			yew.ShieldPhysicalResist = 3;
			yew.WeaponHitChance = 5;
			yew.WeaponDamage = 10;			
			yew.RunicMinAttributes = 3;
			yew.RunicMaxAttributes = 3;
			yew.RunicMinIntensity = 40;
			yew.RunicMaxIntensity = 90;		
			
			CraftAttributeInfo heartwood = Heartwood = new CraftAttributeInfo();
			
			heartwood.ArmorPhysicalResist = 2;
			heartwood.ArmorFireResist = 3;
			heartwood.ArmorColdResist = 2;
			heartwood.ArmorPoisonResist = 7;
			heartwood.ArmorEnergyResist = 2;
			
			// one of below
			heartwood.ArmorDamage = 10;
			heartwood.ArmorHitChance = 5;
			heartwood.ArmorLuck = 40;
			heartwood.ArmorLowerRequirements = 20;
			heartwood.ArmorMage = 1;
			
			// one of below
			heartwood.WeaponDamage = 10;
			heartwood.WeaponHitChance = 5;		
			heartwood.WeaponHitLifeLeech = 13;
			heartwood.WeaponLuck = 40;
			heartwood.WeaponLowerRequirements = 20;	
			heartwood.WeaponSwingSpeed = 10;			
			
			heartwood.RunicMinAttributes = 4;
			heartwood.RunicMaxAttributes = 4;
			heartwood.RunicMinIntensity = 50;
			heartwood.RunicMaxIntensity = 100;
			
			CraftAttributeInfo bloodwood = Bloodwood = new CraftAttributeInfo();

			bloodwood.ArmorPhysicalResist = 3;
			bloodwood.ArmorFireResist = 8;
			bloodwood.ArmorColdResist = 1;
			bloodwood.ArmorPoisonResist = 3;
			bloodwood.ArmorEnergyResist = 3;
			bloodwood.ArmorRegenHits = 2;
			bloodwood.ShieldFireResist = 3;
			bloodwood.WeaponRegenHits = 2;
			bloodwood.WeaponHitLifeLeech = 16;
			
			CraftAttributeInfo frostwood = Frostwood = new CraftAttributeInfo();

			frostwood.ArmorPhysicalResist = 2;
			frostwood.ArmorFireResist = 1;
			frostwood.ArmorColdResist = 8;
			frostwood.ArmorPoisonResist = 3;
			frostwood.ArmorEnergyResist = 4;
			frostwood.ShieldColdResist = 3;
			frostwood.WeaponColdDamage = 40;
			frostwood.WeaponDamage = 12;

            CraftAttributeInfo pine = Pine = new CraftAttributeInfo();

            pine.WeaponLowerRequirements = 50;
            pine.RunicMinAttributes = 2;
            pine.RunicMaxAttributes = 3;
            pine.RunicMinIntensity = 40;
            pine.RunicMaxIntensity = 60;

            CraftAttributeInfo cedar = Cedar = new CraftAttributeInfo();

            cedar.WeaponEnergyDamage = 60;
            cedar.RunicMinAttributes = 3;
            cedar.RunicMaxAttributes = 4;
            cedar.RunicMinIntensity = 50;
            cedar.RunicMaxIntensity = 70;

            CraftAttributeInfo cherry = Cherry = new CraftAttributeInfo();

            cherry.WeaponFireDamage = 60;
            cherry.RunicMinAttributes = 4;
            cherry.RunicMaxAttributes = 5;
            cherry.RunicMinIntensity = 60;
            cherry.RunicMaxIntensity = 80;

            CraftAttributeInfo mahogany = Mahogany = new CraftAttributeInfo();

            mahogany.WeaponColdDamage = 60;
            mahogany.RunicMinAttributes = 5;
            mahogany.RunicMaxAttributes = 6;
            mahogany.RunicMinIntensity = 70;
            mahogany.RunicMaxIntensity = 90;

			//#endregion
		}
	}

	public class CraftResourceInfo
	{
		private int m_Hue;
		private int m_Number;
		private string m_Name;
		private CraftAttributeInfo m_AttributeInfo;
		private CraftResource m_Resource;
		private Type[] m_ResourceTypes;

		public int Hue{ get{ return m_Hue; } }
		public int Number{ get{ return m_Number; } }
		public string Name{ get{ return m_Name; } }
		public CraftAttributeInfo AttributeInfo{ get{ return m_AttributeInfo; } }
		public CraftResource Resource{ get{ return m_Resource; } }
		public Type[] ResourceTypes{ get{ return m_ResourceTypes; } }

		public CraftResourceInfo( int hue, int number, string name, CraftAttributeInfo attributeInfo, CraftResource resource, params Type[] resourceTypes )
		{
			m_Hue = hue;
			m_Number = number;
			m_Name = name;
			m_AttributeInfo = attributeInfo;
			m_Resource = resource;
			m_ResourceTypes = resourceTypes;

			for ( int i = 0; i < resourceTypes.Length; ++i )
				CraftResources.RegisterType( resourceTypes[i], resource );
		}
	}

	public class CraftResources
	{
		private static CraftResourceInfo[] m_MetalInfo = new CraftResourceInfo[]
			{
				new CraftResourceInfo( 0x000, 1053109, "Iron",			CraftAttributeInfo.Blank,		CraftResource.Iron,				typeof( IronIngot ),		typeof( IronOre ),			typeof( Granite ) ),
				new CraftResourceInfo( 0x973, 1053108, "Dull Copper",	    CraftAttributeInfo.DullCopper,	CraftResource.DullCopper,		typeof( DullCopperIngot ),	typeof( DullCopperOre ),	typeof( DullCopperGranite ) ),
				new CraftResourceInfo( 0x966, 1053107, "Shadow Iron",	    CraftAttributeInfo.ShadowIron,	CraftResource.ShadowIron,		typeof( ShadowIronIngot ),	typeof( ShadowIronOre ),	typeof( ShadowIronGranite ) ),
				new CraftResourceInfo( 0x96D, 1053106, "Copper",		    CraftAttributeInfo.Copper,		CraftResource.Copper,			typeof( CopperIngot ),		typeof( CopperOre ),		typeof( CopperGranite ) ),
				new CraftResourceInfo( 0x972, 1053105, "Bronze",		    CraftAttributeInfo.Bronze,		CraftResource.Bronze,			typeof( BronzeIngot ),		typeof( BronzeOre ),		typeof( BronzeGranite ) ),
				new CraftResourceInfo( 0x8A5, 1053104, "Gold",			CraftAttributeInfo.Golden,		CraftResource.Gold,				typeof( GoldIngot ),		typeof( GoldOre ),			typeof( GoldGranite ) ),
				new CraftResourceInfo( 0x979, 1053103, "Agapite",		    CraftAttributeInfo.Agapite,		CraftResource.Agapite,			typeof( AgapiteIngot ),		typeof( AgapiteOre ),		typeof( AgapiteGranite ) ),
				new CraftResourceInfo( 0x89F, 1053102, "Verite",		    CraftAttributeInfo.Verite,		CraftResource.Verite,			typeof( VeriteIngot ),		typeof( VeriteOre ),		typeof( VeriteGranite ) ),
				new CraftResourceInfo( 0x8AB, 1053101, "Valorite",		CraftAttributeInfo.Valorite,    CraftResource.Valorite,			typeof( ValoriteIngot ),	typeof( ValoriteOre ),		typeof( ValoriteGranite ) ),
				new CraftResourceInfo( 0x47E, 0, "Silver",			CraftAttributeInfo.Silver,		CraftResource.Silver,			typeof( SilverIngot ),		typeof( SilverOre ),		typeof( SilverGranite ) ),
				//new CraftResourceInfo( 0x494, 0, "Platinum",	    CraftAttributeInfo.Platinum,	CraftResource.Platinum,			typeof( PlatinumIngot ),	typeof( PlatinumOre ),		typeof( PlatinumGranite ) ),
				//new CraftResourceInfo( 0x486, 0, "Mythril",			CraftAttributeInfo.Mythril,		CraftResource.Mythril,			typeof( MythrilIngot ),		typeof( MythrilOre ),		typeof( MythrilGranite ) ),
				//new CraftResourceInfo( 0x455, 0, "Obsidian",	    CraftAttributeInfo.Obsidian,	CraftResource.Obsidian,			typeof( ObsidianIngot ),	typeof( ObsidianOre ),		typeof( ObsidianGranite ) ),
				new CraftResourceInfo( 0x48C, 0, "Jade",			CraftAttributeInfo.Jade,		CraftResource.Jade,			    typeof( JadeIngot ),		typeof( JadeOre ),		    typeof( JadeGranite ) ),
				new CraftResourceInfo( 0x484, 0, "Moonstone",		CraftAttributeInfo.Moonstone,	CraftResource.Moonstone,		typeof( MoonstoneIngot ),	typeof( MoonstoneOre ),		typeof( MoonstoneGranite ) ),
				new CraftResourceInfo( 0x550, 0, "Sunstone",		CraftAttributeInfo.Sunstone,	CraftResource.Sunstone,			typeof( SunstoneIngot ),	typeof( SunstoneOre ),		typeof( SunstoneGranite ) ),
				//new CraftResourceInfo( 0x485, 0, "Bloodstone",		CraftAttributeInfo.Bloodstone,	CraftResource.Bloodstone,		typeof( BloodstoneIngot ),	typeof( BloodstoneOre ),	typeof( BloodstoneGranite ) ),
			};

		private static CraftResourceInfo[] m_ScaleInfo = new CraftResourceInfo[]
			{
				new CraftResourceInfo( 0x66D, 1053129, "Red Scales",	CraftAttributeInfo.RedScales,		CraftResource.RedScales,		typeof( RedScales ) ),
				new CraftResourceInfo( 0x8A8, 1053130, "Yellow Scales",	CraftAttributeInfo.YellowScales,	CraftResource.YellowScales,		typeof( YellowScales ) ),
				new CraftResourceInfo( 0x455, 1053131, "Black Scales",	CraftAttributeInfo.BlackScales,		CraftResource.BlackScales,		typeof( BlackScales ) ),
				new CraftResourceInfo( 0x851, 1053132, "Green Scales",	CraftAttributeInfo.GreenScales,		CraftResource.GreenScales,		typeof( GreenScales ) ),
				new CraftResourceInfo( 0x8FD, 1053133, "White Scales",	CraftAttributeInfo.WhiteScales,		CraftResource.WhiteScales,		typeof( WhiteScales ) ),
				new CraftResourceInfo( 0x8B0, 1053134, "Blue Scales",	CraftAttributeInfo.BlueScales,		CraftResource.BlueScales,		typeof( BlueScales ) ),
                new CraftResourceInfo( 591, 1112626, "Medusa Scales",	CraftAttributeInfo.MedusaLightScales,		CraftResource.MedusaLightScales,    typeof( MedusaLightScales ) ),
				new CraftResourceInfo( 1266, 1112626, "Medusa Scales",	CraftAttributeInfo.MedusaDarkScales,		CraftResource.MedusaDarkScales,		typeof( MedusaDarkScales ) )
			};

		private static CraftResourceInfo[] m_LeatherInfo = new CraftResourceInfo[]
			{
				new CraftResourceInfo( 0x000, 1049353, "Normal",		CraftAttributeInfo.Blank,		CraftResource.RegularLeather,	typeof( Leather ),			typeof( Hides ) ),
				new CraftResourceInfo( 0x283, 1049354, "Spined",		CraftAttributeInfo.Spined,		CraftResource.SpinedLeather,	typeof( SpinedLeather ),	typeof( SpinedHides ) ),
				new CraftResourceInfo( 0x227, 1049355, "Horned",		CraftAttributeInfo.Horned,		CraftResource.HornedLeather,	typeof( HornedLeather ),	typeof( HornedHides ) ),
				new CraftResourceInfo( 0x1C1, 1049356, "Barbed",		CraftAttributeInfo.Barbed,		CraftResource.BarbedLeather,	typeof( BarbedLeather ),	typeof( BarbedHides ) ),
				new CraftResourceInfo( 0x488, 0, "Dragon",			CraftAttributeInfo.DragonL,		CraftResource.DragonLeather,	typeof( DragonLeather ),	typeof( DragonHides ) ),
				new CraftResourceInfo( 0x3DB, 0, "Daemon",			CraftAttributeInfo.Daemon,		CraftResource.DaemonLeather,	typeof( DaemonLeather ),	typeof( DaemonHides ) )
				
		};

		private static CraftResourceInfo[] m_AOSLeatherInfo = new CraftResourceInfo[]
			{
				new CraftResourceInfo( 0x000, 1049353, "Normal",		CraftAttributeInfo.Blank,		CraftResource.RegularLeather,	typeof( Leather ),			typeof( Hides ) ),
				new CraftResourceInfo( 0x8AC, 1049354, "Spined",		CraftAttributeInfo.Spined,		CraftResource.SpinedLeather,	typeof( SpinedLeather ),	typeof( SpinedHides ) ),
				new CraftResourceInfo( 0x845, 1049355, "Horned",		CraftAttributeInfo.Horned,		CraftResource.HornedLeather,	typeof( HornedLeather ),	typeof( HornedHides ) ),
				new CraftResourceInfo( 0x851, 1049356, "Barbed",		CraftAttributeInfo.Barbed,		CraftResource.BarbedLeather,	typeof( BarbedLeather ),	typeof( BarbedHides ) ),
				new CraftResourceInfo( 0x488, 0, "Dragon",			CraftAttributeInfo.DragonL,		CraftResource.DragonLeather,	    typeof( DragonLeather ),	typeof( DragonHides ) ),
				new CraftResourceInfo( 0x3DB, 0, "Daemon",			CraftAttributeInfo.Daemon,		CraftResource.DaemonLeather,	    typeof( DaemonLeather ),	typeof( DaemonHides ) )
		};

		//#region Mondain's Legacy
		private static CraftResourceInfo[] m_WoodInfo = new CraftResourceInfo[]
			{
				new CraftResourceInfo( 0x000, 1027133, "Regular",		CraftAttributeInfo.Blank,		CraftResource.Log,			typeof( Log ),				typeof( Board ) ),
				new CraftResourceInfo( 0x7DA, 1072533, "Oak",			CraftAttributeInfo.Oak,			CraftResource.Oak,			typeof( OakLog ),			typeof( OakBoard ) ),
				new CraftResourceInfo( 1191, 1072534, "Ash",			CraftAttributeInfo.Ash,			CraftResource.Ash,			typeof( AshLog ),			typeof( AshBoard ) ),
				new CraftResourceInfo( 0x4A8, 1072535, "Yew",			CraftAttributeInfo.Yew,			CraftResource.Yew,			typeof( YewLog ),			typeof( YewBoard ) ),
				new CraftResourceInfo( 1193, 1072536, "Heartwood",		CraftAttributeInfo.Heartwood,	CraftResource.Heartwood,	typeof( HeartwoodLog ),		typeof( HeartwoodBoard ) ),
				new CraftResourceInfo( 1194, 1072538, "Bloodwood",		CraftAttributeInfo.Bloodwood,	CraftResource.Bloodwood,	typeof( BloodwoodLog ),		typeof( BloodwoodBoard ) ),
				new CraftResourceInfo( 1151, 1072539, "Frostwood",		CraftAttributeInfo.Frostwood,	CraftResource.Frostwood,	typeof( FrostwoodLog ),		typeof( FrostwoodBoard ) ),
                new CraftResourceInfo( 1153, 0, "Pine",		            CraftAttributeInfo.Pine,		CraftResource.Pine,			typeof( PineLog ),			typeof( PineBoard ) ),
				new CraftResourceInfo( 0x35E, 0, "Cedar",		        CraftAttributeInfo.Cedar,		CraftResource.Cedar,		typeof( CedarLog ),			typeof( CedarBoard ) ),
				new CraftResourceInfo( 1149, 0, "Cherry",		        CraftAttributeInfo.Cherry,		CraftResource.Cherry,		typeof( CherryLog ),		typeof( CherryBoard ) ),
				new CraftResourceInfo( 42, 0, "Mahogany",		        CraftAttributeInfo.Mahogany,	CraftResource.Mahogany,		typeof( MahoganyLog ),		typeof( MahoganyBoard ) ),
		};
		//#endregion

		/// <summary>
		/// Returns true if '<paramref name="resource"/>' is None, Iron, RegularLeather or RegularWood. False if otherwise.
		/// </summary>
		public static bool IsStandard( CraftResource resource )
		{
			return ( resource == CraftResource.None || resource == CraftResource.Iron || resource == CraftResource.RegularLeather || resource == CraftResource.Log );
		}

		private static Hashtable m_TypeTable;

		/// <summary>
		/// Registers that '<paramref name="resourceType"/>' uses '<paramref name="resource"/>' so that it can later be queried by <see cref="CraftResources.GetFromType"/>
		/// </summary>
		public static void RegisterType( Type resourceType, CraftResource resource )
		{
			if ( m_TypeTable == null )
				m_TypeTable = new Hashtable();

			m_TypeTable[resourceType] = resource;
		}

		/// <summary>
		/// Returns the <see cref="CraftResource"/> value for which '<paramref name="resourceType"/>' uses -or- CraftResource.None if an unregistered type was specified.
		/// </summary>
		public static CraftResource GetFromType( Type resourceType )
		{
			if ( m_TypeTable == null )
				return CraftResource.None;

			object obj = m_TypeTable[resourceType];

			if ( !(obj is CraftResource) )
				return CraftResource.None;

			return (CraftResource)obj;
		}

		/// <summary>
		/// Returns a <see cref="CraftResourceInfo"/> instance describing '<paramref name="resource"/>' -or- null if an invalid resource was specified.
		/// </summary>
		public static CraftResourceInfo GetInfo( CraftResource resource )
		{
			CraftResourceInfo[] list = null;

			switch ( GetType( resource ) )
			{
				case CraftResourceType.Metal: list = m_MetalInfo; break;
				case CraftResourceType.Leather: list = Core.AOS ? m_AOSLeatherInfo : m_LeatherInfo; break;
				case CraftResourceType.Scales: list = m_ScaleInfo; break;
				
				//#region Mondain's Legacy
				case CraftResourceType.Wood: list = m_WoodInfo; break;
				//#endregion
			}

			if ( list != null )
			{
				int index = GetIndex( resource );

				if ( index >= 0 && index < list.Length )
					return list[index];
			}

			return null;
		}

		/// <summary>
		/// Returns a <see cref="CraftResourceType"/> value indiciating the type of '<paramref name="resource"/>'.
		/// </summary>
		public static CraftResourceType GetType( CraftResource resource )
		{
			if ( resource >= CraftResource.Iron && resource <= CraftResource.Sunstone )
				return CraftResourceType.Metal;

			if ( resource >= CraftResource.RegularLeather && resource <= CraftResource.DaemonLeather )
				return CraftResourceType.Leather;

			if ( resource >= CraftResource.RedScales && resource <= CraftResource.MedusaDarkScales )
				return CraftResourceType.Scales;

			//#region Mondain's Legacy
			if ( resource >= CraftResource.Log && resource <= CraftResource.Mahogany )
				return CraftResourceType.Wood;
			//#endregion

			return CraftResourceType.None;
		}

		/// <summary>
		/// Returns the first <see cref="CraftResource"/> in the series of resources for which '<paramref name="resource"/>' belongs.
		/// </summary>
		public static CraftResource GetStart( CraftResource resource )
		{
			switch ( GetType( resource ) )
			{
				case CraftResourceType.Metal: return CraftResource.Iron;
				case CraftResourceType.Leather: return CraftResource.RegularLeather;
				case CraftResourceType.Scales: return CraftResource.RedScales;
				
				//#region Mondain's Legacy
				case CraftResourceType.Wood: return CraftResource.Log; 
				//#endregion
			}

			return CraftResource.None;
		}

		/// <summary>
		/// Returns the index of '<paramref name="resource"/>' in the seriest of resources for which it belongs.
		/// </summary>
		public static int GetIndex( CraftResource resource )
		{
			CraftResource start = GetStart( resource );

			if ( start == CraftResource.None )
				return 0;

			return (int)(resource - start);
		}

		/// <summary>
		/// Returns the <see cref="CraftResourceInfo.Number"/> property of '<paramref name="resource"/>' -or- 0 if an invalid resource was specified.
		/// </summary>
		public static int GetLocalizationNumber( CraftResource resource )
		{
			CraftResourceInfo info = GetInfo( resource );

			return ( info == null ? 0 : info.Number );
		}

		/// <summary>
		/// Returns the <see cref="CraftResourceInfo.Hue"/> property of '<paramref name="resource"/>' -or- 0 if an invalid resource was specified.
		/// </summary>
		public static int GetHue( CraftResource resource )
		{
			CraftResourceInfo info = GetInfo( resource );

			return ( info == null ? 0 : info.Hue );
		}

		/// <summary>
		/// Returns the <see cref="CraftResourceInfo.Name"/> property of '<paramref name="resource"/>' -or- an empty string if the resource specified was invalid.
		/// </summary>
		public static string GetName( CraftResource resource )
		{
			CraftResourceInfo info = GetInfo( resource );

			return ( info == null ? String.Empty : info.Name );
		}

		/// <summary>
		/// Returns the <see cref="CraftResource"/> value which represents '<paramref name="info"/>' -or- CraftResource.None if unable to convert.
		/// </summary>
		public static CraftResource GetFromOreInfo( OreInfo info )
		{
			if ( info.Name.IndexOf( "Spined" ) >= 0 )
				return CraftResource.SpinedLeather;
			else if ( info.Name.IndexOf( "Horned" ) >= 0 )
				return CraftResource.HornedLeather;
			else if ( info.Name.IndexOf( "Barbed" ) >= 0 )
				return CraftResource.BarbedLeather;			
			else if ( info.Name.IndexOf( "DragonL" ) >= 0 )
				return CraftResource.DragonLeather;				
			else if ( info.Name.IndexOf( "Daemon" ) >= 0 )
				return CraftResource.DaemonLeather;
			else if ( info.Name.IndexOf( "Leather" ) >= 0 )
				return CraftResource.RegularLeather;

			if ( info.Level == 0 )
				return CraftResource.Iron;
			else if ( info.Level == 1 )
				return CraftResource.DullCopper;
			else if ( info.Level == 2 )
				return CraftResource.ShadowIron;
			else if ( info.Level == 3 )
				return CraftResource.Copper;
			else if ( info.Level == 4 )
				return CraftResource.Bronze;
			else if ( info.Level == 5 )
				return CraftResource.Gold;
			else if ( info.Level == 6 )
				return CraftResource.Agapite;
			else if ( info.Level == 7 )
				return CraftResource.Verite;
			else if ( info.Level == 8 )
				return CraftResource.Valorite;
			else if ( info.Level == 9 )
				return CraftResource.Silver;
			else if (info.Level == 10 )
			    return CraftResource.Jade;
			else if (info.Level == 11 )
				return CraftResource.Moonstone;
			else if (info.Level == 12 )
				return CraftResource.Sunstone;
			else if (info.Level == 13 )
				return CraftResource.Log;
			else if (info.Level == 14 )
				return CraftResource.Oak;
			else if ( info.Level == 15 )
				return CraftResource.Ash;
			else if ( info.Level == 16 )
				return CraftResource.Yew;
			else if ( info.Level == 17 )
				return CraftResource.Heartwood;
			else if ( info.Level == 18 )
				return CraftResource.Bloodwood;
			else if ( info.Level == 19 )
				return CraftResource.Frostwood;
            else if (info.Level == 20 )
                return CraftResource.Pine;
            else if (info.Level == 21)
                return CraftResource.Cedar;
            else if (info.Level == 22)
                return CraftResource.Cherry;
            else if (info.Level == 23)
                return CraftResource.Mahogany;
			//#endregion

			return CraftResource.None;
		}

		/// <summary>
		/// Returns the <see cref="CraftResource"/> value which represents '<paramref name="info"/>', using '<paramref name="material"/>' to help resolve leather OreInfo instances.
		/// </summary>
		public static CraftResource GetFromOreInfo( OreInfo info, ArmorMaterialType material )
		{
			if ( material == ArmorMaterialType.Studded || material == ArmorMaterialType.Leather || material == ArmorMaterialType.Spined ||
				material == ArmorMaterialType.Horned || material == ArmorMaterialType.Barbed || material == ArmorMaterialType.DragonL || material == ArmorMaterialType.Daemon )
			{
				if ( info.Level == 0 )
					return CraftResource.RegularLeather;
				else if ( info.Level == 1 )
					return CraftResource.SpinedLeather;
				else if ( info.Level == 2 )
					return CraftResource.HornedLeather;
				else if ( info.Level == 3 )
					return CraftResource.BarbedLeather;
				else if ( info.Level == 4 )
					return CraftResource.DragonLeather;
				else if ( info.Level == 5 )
					return CraftResource.DaemonLeather;

				return CraftResource.None;
			}

			return GetFromOreInfo( info );
		}
	}

	// NOTE: This class is only for compatability with very old RunUO versions.
	// No changes to it should be required for custom resources.
	public class OreInfo
	{
		public static readonly OreInfo Iron			= new OreInfo( 0, 0x000, "Iron" );
		public static readonly OreInfo DullCopper	= new OreInfo( 1, 0x973, "Dull Copper" );
		public static readonly OreInfo ShadowIron	= new OreInfo( 2, 0x966, "Shadow Iron" );
		public static readonly OreInfo Copper		= new OreInfo( 3, 0x96D, "Copper" );
		public static readonly OreInfo Bronze		= new OreInfo( 4, 0x972, "Bronze" );
		public static readonly OreInfo Gold			= new OreInfo( 5, 0x8A5, "Gold" );
		public static readonly OreInfo Agapite		= new OreInfo( 6, 0x979, "Agapite" );
		public static readonly OreInfo Verite		= new OreInfo( 7, 0x89F, "Verite" );
		public static readonly OreInfo Valorite		= new OreInfo( 8, 0x8AB, "Valorite" );
		public static readonly OreInfo Silver		= new OreInfo( 9, 0x47e, "Silver" );
		//public static readonly OreInfo Platinum 	= new OreInfo( 10, 0x494, "Platinum");
		//public static readonly OreInfo Mythril		= new OreInfo( 11, 0x486, "Mythril");
		//public static readonly OreInfo Obsidian		= new OreInfo( 12, 0x3C7, "Obsidian");
		public static readonly OreInfo Jade		    = new OreInfo( 10, 0x48C, "Jade");
		public static readonly OreInfo Moonstone	= new OreInfo( 11, 0x481, "Moonstone");
		public static readonly OreInfo Sunstone		= new OreInfo( 12, 0x550, "Sunstone");
		//public static readonly OreInfo Bloodstone	= new OreInfo( 13, 0x485, "Bloodstone");
		public static readonly OreInfo Log		    = new OreInfo( 13, 0x000, "Regular");
        public static readonly OreInfo Oak          = new OreInfo( 14, 0x7DA, "Oak");
        public static readonly OreInfo Ash          = new OreInfo( 15, 1191, "Ash");
        public static readonly OreInfo Yew          = new OreInfo( 16, 0x4A8, "Yew");
        public static readonly OreInfo Heartwood    = new OreInfo( 17, 1193, "Heartwood");
        public static readonly OreInfo Bloodwood    = new OreInfo( 18, 1194, "Bloodwood");
        public static readonly OreInfo Frostwood    = new OreInfo( 19, 1151, "Frostwood");
		public static readonly OreInfo Pine		    = new OreInfo( 20, 1153, "Pine");
		public static readonly OreInfo Cedar        = new OreInfo( 21, 0x35E, "Cedar" );
		public static readonly OreInfo Cherry       = new OreInfo( 22, 1149, "Cherry" );
		public static readonly OreInfo Mahogany		= new OreInfo( 23, 42, "Mahogany" );
		
		private int m_Level;
		private int m_Hue;
		private string m_Name;

		public OreInfo( int level, int hue, string name )
		{
			m_Level = level;
			m_Hue = hue;
			m_Name = name;
		}

		public int Level
		{
			get
			{
				return m_Level;
			}
		}

		public int Hue
		{
			get
			{
				return m_Hue;
			}
		}

		public string Name
		{
			get
			{
				return m_Name;
			}
		}
	}
}