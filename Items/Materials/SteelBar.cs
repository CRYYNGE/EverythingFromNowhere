using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.Items.Materials
{
    public class SteelBar : ModItem
    {
        
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Steel Bar");
            Tooltip.SetDefault("I am Iron Man!");
            
        }
        
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 999;
            Item.value = 0;
            Item.rare = 0;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Items.Materials.Charcoal>(1);
            recipe.AddIngredient(ItemID.IronOre, 3);
            recipe.AddTile(TileID.Furnaces);
            recipe.Register();
        }
    }
}