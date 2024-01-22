using RWBY.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameInput;
using Terraria.ModLoader;
using Terraria.Server;

namespace RWBY
{
    public class RWBYPlayer : ModPlayer
    {
        public override void ProcessTriggers(TriggersSet triggersSet)
        {
            if (RWBY.GetTransformHotKey().JustPressed && Player.itemAnimation == 0)
            {
                Item inHand = Player.inventory[Player.selectedItem];
                if (inHand is ISwitchable)
                {
                    try
                    {
                        ISwitchable holdItem = (ISwitchable)inHand;
                        holdItem.SwitchWeaponMode();
                    }
                    catch (Exception e)
                    {
                        Terraria.Chat.ChatMessage a = new("Error: " + e.ToString());
                        a.Consume();
                    }
                }
            }

            base.ProcessTriggers(triggersSet);
        }
    }
}
