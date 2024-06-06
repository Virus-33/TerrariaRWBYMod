using RWBY.Content.DamageClasses;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RWBY.Content.Weapons.QueenServants
{
    public class QueenServantsBlade : ModItem
    {
        // TODO: Add dropchance from dunno what mob/lootchest
        public override void SetDefaults()
        {
            Item.width = 45;
            Item.height = 40;
            Item.ArmorPenetration = 3;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 10;
            Item.useAnimation = 10;
            Item.autoReuse = true;

            Item.DamageType = ModContent.GetInstance<HunterDamageClass>();
            Item.crit = 0;
            Item.damage = 4;
            Item.knockBack = 0;
            Item.ArmorPenetration = 3;

            Item.value = Item.buyPrice(0,0,5,0);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.DD2_MonkStaffSwing;
        }
    }
}
