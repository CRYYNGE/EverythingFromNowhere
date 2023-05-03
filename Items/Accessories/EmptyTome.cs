using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.Items.Accessories;

public class EmptyTome : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Empty Tome");
        Tooltip.SetDefault("A Tome with no Knowledge held inside.");

        CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25;
    }

    public override void SetDefaults()
    {
        Item.accessory = true;
        Item.maxStack = 5;
        Item.width = 32;
        Item.height = 32;
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.Book, 3);
        recipe.AddIngredient(ItemID.FallenStar, 5);
        recipe.AddTile(TileID.Bookcases);
        recipe.Register();
    }
}