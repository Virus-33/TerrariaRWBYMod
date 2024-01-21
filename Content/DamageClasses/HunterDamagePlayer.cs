using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace RWBY.DamageClasses.HunterDamageClass
{
	// This class stores necessary player info for our custom damage class, such as damage multipliers, additions to knockback and crit, and our custom resource that governs the usage of the weapons of this damage class.
	public class HunterDamagePlayer : ModPlayer
	{
		public static HunterDamagePlayer ModPlayer(Player player)
		{
			return player.GetModPlayer<HunterDamagePlayer>();
		}

		// Vanilla only really has damage multipliers in code
		// And crit and knockback is usually just added to
		// As a modder, you could make separate variables for multipliers and simple addition bonuses
		public float hunterDamageAdd;
		public float hunterDamageMult = 1f;
		public float hunterKnockback;
		public int hunterCrit;

		public override void ResetEffects()
		{
			ResetVariables();
		}

		public override void UpdateDead()
		{
			ResetVariables();
		}

		private void ResetVariables()
		{
			hunterDamageAdd = 0f;
			hunterDamageMult = 1f;
			hunterKnockback = 0f;
			hunterCrit = 0;
		}
	}
}