using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.Items.Materials
{
    public class Charcoal : ModItem
    {
        
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Charcoal");
            Tooltip.SetDefault("You got a great idea for an art piece.. Oh, it's gone.");
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
            recipe.AddIngredient(ItemID.Wood, 3);
            recipe.AddTile(TileID.Furnaces);
            recipe.Register();
        }
    }
}