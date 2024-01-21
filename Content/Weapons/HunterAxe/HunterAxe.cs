using Microsoft.Xna.Framework;
using RWBY.Content.DamageClasses;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RWBY.Content.Weapons.HunterAxe
{
    public class HunterAxe : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 45;
            Item.height = 40;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.autoReuse = false;

            Item.DamageType = ModContent.GetInstance<HunterDamageClass>();
            Item.crit = 0;
            Item.damage = 15;
            Item.knockBack = 8;

            Item.value = Item.buyPrice(0, 0, 3, 5);
            Item.rare = 1;
            Item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}