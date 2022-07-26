using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.Items.Materials;

public class Components : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Components");
        Tooltip.SetDefault("A collection of components, used to craft things.");
    }

    public override void SetDefaults()
    {
        Item.rare = 0;
        Item.maxStack = 9999;
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.IronBar, 2);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();
    }
}