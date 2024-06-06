using RWBY.Content.DamageClasses;
using Terraria.ModLoader;

namespace RWBY.Content.Weapons.QueenServants
{
    public class QueenServantsShooter : ModItem
    {
        public override void SetDefaults()
        {
            Item.DamageType = ModContent.GetInstance<HunterDamageClass>();
            Item.crit = 0;
            Item.width = 45;
            Item.height = 40;

            Item.damage = 5;
        }
    }
}
