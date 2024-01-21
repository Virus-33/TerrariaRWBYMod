using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RWBY.Content.Accessories
{
    [AutoloadEquip(EquipType.Beard)]
    public class Cigarette : ModItem
	{

        public override void SetStaticDefaults()
		{
            ArmorIDs.Beard.Sets.UseHairColor[Item.beardSlot] = false;
        }

        public override void SetDefaults()
        {
			Item.width = 18;
			Item.height = 14;
			Item.maxStack = 1;
			Item.value = Item.sellPrice(0, 0, 1, 20);
			Item.accessory = true;
			Item.vanity = true;
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}