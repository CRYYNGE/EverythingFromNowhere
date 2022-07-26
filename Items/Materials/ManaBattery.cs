using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.Items.Materials;

public class ManaBattery : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Mana Battery");
        Tooltip.SetDefault("Made by some mechanic, it saps mana from the holder and turns it into power.");
    }

    public override void SetDefaults()
    {
        Item.rare = 0;
        Item.maxStack = 9999;
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.IronBar, 3);
        recipe.AddIngredient(ItemID.FallenStar, 2);
        recipe.AddTile(TileID.Anvils);
        recipe.Register();
    }
}