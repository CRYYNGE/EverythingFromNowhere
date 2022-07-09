using EverythingFromNowhere.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.Items.Lore;

public class Document : ModItem
{

    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Document");
        Tooltip.SetDefault("Dear J. Please send 1 Platinum Coin to my account in payment of my service. -S");
    }

    public override void SetDefaults()
    {
        Item.width = 20;
        Item.height = 20;
        Item.maxStack = 1;
        Item.value = 100;
        Item.rare = 1;
    }
    
    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ModContent.ItemType<DocumentShred>(), 15);
        recipe.AddTile(TileID.WorkBenches);
        recipe.Register();
    }
    
}