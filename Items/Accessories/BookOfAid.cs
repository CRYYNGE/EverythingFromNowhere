using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.Items.Accessories;

public class BookOfAid : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Health Tome");
        Tooltip.SetDefault("A Tome with Knowledge of Health.\n"
                           + "6% increased Health Regen.\n");

        CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
        Item.accessory = true;
        Item.maxStack = 1;
        Item.width = 32;
        Item.height = 32;
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.lifeRegen += 6;
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient<Items.Accessories.EmptyTome>();
        recipe.AddIngredient(ItemID.LifeCrystal, 5);
        recipe.AddTile(TileID.Bookcases);
        recipe.Register();
    }
}