using Microsoft.Xna.Framework;
using RWBY.Content.DamageClasses;
using RWBY.Content.Weapons.HunterAxeFolder;
using RWBY.Utility;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RWBY.Content.Weapons.BlowhardFolder
{
    public class Blowhard : ModItem, ISwitchable
    {
        public int CurrentState;

        public override void SetDefaults()
        {
            Item.DamageType = ModContent.GetInstance<HunterDamageClass>();
            Item.crit = 0;
            Item.width = 45;
            Item.height = 40;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.autoReuse = false;

            Item.damage = 18;
            Item.knockBack = 8;

            Item.value = Item.buyPrice(0, 0, 3, 5);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item1;

            CurrentState = 0;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.GetInstance<HunterAxe>(), 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }

        public void SwitchWeaponMode()
        {
            if (CurrentState == 0)
            {
                CurrentState = 1;
                Item.useStyle = ItemUseStyleID.Shoot;
                Item.useAmmo = AmmoID.Bullet;
                Item.shootSpeed = 16f;
                Item.shoot = ProjectileID.PurificationPowder;
                // There will be sound that must be played
            }
            else
            {
                CurrentState = 0;
                Item.useStyle = ItemUseStyleID.Swing;
                Item.useAmmo = AmmoID.None;
                Item.shootSpeed = 0f;
                Item.shoot = ProjectileID.None;
            }
        }
    }
}