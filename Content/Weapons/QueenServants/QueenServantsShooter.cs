using Microsoft.Xna.Framework;
using RWBY.Content.DamageClasses;
using RWBY.Utility;
using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace RWBY.Content.Weapons.QueenServants
{
    public class QueenServantsShooter : ModItem, ISwitchable
    {
        public override void SetDefaults()
        {
            Item.width = 45;
            Item.height = 40;

            Item.DamageType = ModContent.GetInstance<HunterDamageClass>();
            Item.damage = 10;
            Item.crit = 0;
            Item.ArmorPenetration = 3;

            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTime = 40;
            Item.useAnimation = 40;
            Item.UseSound = SoundID.Item36;            

            Item.shoot = ProjectileID.PurificationPowder;
            Item.shootSpeed = 20f;
            Item.useAmmo = AmmoID.Bullet;
            Item.knockBack = 2;

            Item.value = Item.buyPrice(0, 0, 40, 15);
            Item.rare = ItemRarityID.Blue;
        }

        public bool CanHavePrefixes() => true;

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            float numberProjectiles = 2;
            float pi = 3.14159265f;
            velocity.Normalize();
            velocity *= 40f;
            bool flag = Collision.CanHit(position, 0, 0, position + velocity, 0, 0);
            for (int i = 0; i < numberProjectiles; i++)
            {
                float num = (float)i - ((float)numberProjectiles - 1f) / 2f;
                Vector2 vector2 = velocity.RotatedBy((double)(pi * num / 10), default(Vector2));
                if (!flag)
                {
                    vector2 -= velocity;
                }
                Projectile.NewProjectile(source, position.X + vector2.X, position.Y + vector2.Y, velocity.X, velocity.Y, type, damage, knockback, player.whoAmI);
            }
            return false;
        }

        public ModItem SwitchWeaponMode()
        {
            return ModContent.GetInstance<QueenServantsBlade>();
        }
    }
}
