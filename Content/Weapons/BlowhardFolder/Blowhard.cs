using Microsoft.Xna.Framework;
using RWBY.Content.DamageClasses;
using RWBY.Content.Weapons.BlowhardShooterFolder;
using RWBY.Content.Weapons.HunterAxeFolder;
using RWBY.Utility;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RWBY.Content.Weapons.BlowhardFolder
{
    public class Blowhard : ModItem, ISwitchable
    {
        public ModItem SecondState;
        
        public override void SetDefaults()
        {
            Item.DamageType = ModContent.GetInstance<HunterDamageClass>();
            Item.crit = 0;
            Item.width = 45;
            Item.height = 40;
            Item.ArmorPenetration = 2;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.autoReuse = true;

            Item.damage = 20;
            Item.knockBack = 8;

            Item.value = Item.buyPrice(0, 0, 35, 5);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item1;

            SecondState = ModContent.GetInstance<BlowhardShooter>();
        }

        public bool CanHavePrefixes() => true;

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.GetInstance<HunterAxe>(), 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }

        public ModItem SwitchWeaponMode()
        {
            return SecondState;
        }
    }
}