/* using EverythingFromNowhere.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EveryNo.Items.Accessories
{
    public class Glider : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glider");
            Tooltip.SetDefault("Allows you to fly in any direction but up.");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
            Item.value = 100;
            Item.rare = 0;
        }
        
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<BirdBone>(), 10);
            recipe.AddIngredient(ItemID.Silk, 15);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}

*/