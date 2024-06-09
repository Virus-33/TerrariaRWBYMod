using Microsoft.Xna.Framework;
using RWBY.Content.DamageClasses;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RWBY.Content.Weapons.HunterAxeFolder
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

            Item.DamageType = ModContent.GetInstance<HunterDamageClass>();
            Item.crit = 0;
            Item.damage = 15;
            Item.knockBack = 8;
            Item.ArmorPenetration = 2;

            Item.value = Item.buyPrice(0, 0, 3, 5);
            Item.rare = ItemRarityID.White;
            Item.UseSound = SoundID.Item1;

            Item.axe = 7;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 2);
            recipe.AddIngredient(ItemID.IronBar, 3);
            recipe.AddIngredient(ItemID.Gel, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
            
            Recipe recipeLead = CreateRecipe();
            recipeLead.AddIngredient(ItemID.Wood, 2);
            recipeLead.AddIngredient(ItemID.LeadBar, 3);
            recipeLead.AddIngredient(ItemID.Gel, 2);
            recipeLead.AddTile(TileID.WorkBenches);
            recipeLead.Register();
        }
    }
}