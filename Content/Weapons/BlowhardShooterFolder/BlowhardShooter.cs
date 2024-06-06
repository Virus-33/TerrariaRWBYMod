using Microsoft.Xna.Framework;
using RWBY.Content.DamageClasses;
using RWBY.Content.Weapons.BlowhardFolder;
using RWBY.Utility;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace RWBY.Content.Weapons.BlowhardShooterFolder
{
    public class BlowhardShooter : ModItem, ISwitchable
    {

        public override void SetDefaults()
        {
            Item.DamageType = ModContent.GetInstance<HunterDamageClass>();
            Item.crit = 0;
            Item.width = 45;
            Item.height = 40;

            Item.damage = 5;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useAmmo = AmmoID.Bullet;
            Item.shootSpeed = 7f;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.shoot = ProjectileID.PurificationPowder;
            Item.autoReuse = false;

            Item.value = Item.buyPrice(0, 0, 35, 5);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item11;

        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            const int ShellAmount = 6;

            for (int i = 0; i < ShellAmount; i++)
            {
                Vector2 vel = velocity.RotatedByRandom(MathHelper.ToRadians(19));

                Projectile.NewProjectileDirect(source, position, vel, type, damage, knockback, player.whoAmI);
            }

            return false;
        }

        public ModItem SwitchWeaponMode()
        {
            return ModContent.GetInstance<Blowhard>();
        }
    }
}
