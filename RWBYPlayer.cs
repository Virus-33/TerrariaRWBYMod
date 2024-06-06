using RWBY.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Chat;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Server;
using Terraria.UI.Chat;

namespace RWBY
{
    public class RWBYPlayer : ModPlayer
    {
        public override void ProcessTriggers(TriggersSet triggersSet)
        {
            if (RWBY.GetTransformHotKey().JustPressed)
            {
                ModItem inHand = Player.inventory[Player.selectedItem].ModItem;
                if (inHand is ISwitchable)
                {
                    int item_prefix = Player.inventory[Player.selectedItem].prefix;
                    ISwitchable holdItem = (ISwitchable)inHand;
                    Item newMode = holdItem.SwitchWeaponMode().Item;
                    if (item_prefix != 0) { newMode.Prefix(item_prefix); }
                    Player.inventory[Player.selectedItem] = newMode.Clone();
                    Player.inventory[Player.selectedItem].SetDefaults(newMode.type);
                }
            }

            base.ProcessTriggers(triggersSet);
        }
    }
}
