using System; 
using Server;
using Server.Commands; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;

namespace Server.Gumps
{
    public class GalaphileGump2 : Gump
    {
        public static void Initialize()
        {
            CommandSystem.Register("GalaphileGump2", AccessLevel.GameMaster, new CommandEventHandler(GalaphileGump2_OnCommand));
        }

        private static void GalaphileGump2_OnCommand(CommandEventArgs e)
        {
            e.Mobile.SendGump(new GalaphileGump2(e.Mobile));
        }

        public GalaphileGump2(Mobile owner)
            : base(50, 50)
        {
            //----------------------------------------------------------------------------------------------------

            AddPage(0);
            AddImageTiled(54, 33, 369, 400, 2624);
            AddAlphaRegion(54, 33, 369, 400);

            AddImageTiled(416, 39, 44, 389, 203);
            //--------------------------------------Window size bar--------------------------------------------

            AddImage(97, 49, 9005);
            AddImageTiled(58, 39, 29, 390, 10460);
            AddImageTiled(412, 37, 31, 389, 10460);
            AddLabel(140, 60, 0x34, "You have done it!");


            AddHtml(107, 140, 300, 230, "<BODY>" +
                //----------------------/----------------------------------------------/
"<BASEFONT COLOR=White> I welcome your bravery in helping all of COV and myself. Now COV should be safe! *For all Eternity I hope*" +
"<BASEFONT COLOR=White> Now here is your reward. Wear it proudly, and be safe on all your journey's." +
                             "</BODY>", false, true);

            AddImage(430, 9, 10441);
            AddImageTiled(40, 38, 17, 391, 9263);
            AddImage(6, 25, 10421);
            AddImage(34, 12, 10420);
            AddImageTiled(94, 25, 342, 15, 10304);
            AddImageTiled(40, 427, 415, 16, 10304);
            AddImage(-10, 314, 10402);
            AddImage(56, 150, 10411);
            AddImage(155, 120, 2103);
            AddImage(136, 84, 96);

            AddButton(225, 390, 0xF7, 0xF8, 0, GumpButtonType.Reply, 0);

            //--------------------------------------------------------------------------------------------------------------
        }

        public override void OnResponse(NetState state, RelayInfo info)
        {
            Mobile from = state.Mobile;

            switch (info.ButtonID)
            {
                case 0:
                    {
                        from.SendMessage("Be safe and be proud of what you have done! Thank You!");
                        from.CloseGump(typeof(GalaphileGump2));
                        
                        break;
                    }                 
            }
        }
    }
}