using Terraria;
using Terraria.ModLoader;

namespace RWBY.Content.DamageClasses
{
    public class HunterDamageClass : DamageClass
    {
        public override StatInheritanceData GetModifierInheritance(DamageClass damageClass)
        {
            if (damageClass == DamageClass.Melee)
            {
                return new StatInheritanceData(
                damageInheritance: 1f,
                critChanceInheritance: 0f,
                attackSpeedInheritance: 0f,
                armorPenInheritance: 0.5f,
                knockbackInheritance: 0.3f);
            }

            if (damageClass == DamageClass.Ranged)
            {
                return new StatInheritanceData(
                damageInheritance: 1f,
                critChanceInheritance: 0f,
                attackSpeedInheritance: 0.8f,
                armorPenInheritance: 0f,
                knockbackInheritance: 0f);
            }

            return StatInheritanceData.None;
        }

        public override bool GetEffectInheritance(DamageClass damageClass)
        {
            return false;
        }

        public override void SetDefaultStats(Player player)
        {
            player.GetArmorPenetration<HunterDamageClass>() += 5;
        }

        public override bool UseStandardCritCalcs => false;

        public override bool ShowStatTooltipLine(Player player, string lineName)
        {
            return true;
        }
    }
}