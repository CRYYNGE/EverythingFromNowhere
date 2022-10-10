using EverythingFromNowhere.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace EverythingFromNowhere.Items.Placeables.Furniture
{
    public class SewingTableItem : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Sewing Machine");
            Tooltip.SetDefault("Got needles in your eyes, or a good reason to cry?");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults() {
            Item.createTile = ModContent.TileType<Tiles.Furniture.SewingTable>();
            Item.width = 28; // The item texture's width
            Item.height = 14; // The item texture's height

            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 10;
            Item.useAnimation = 15;

            Item.maxStack = 99;
            Item.consumable = true;
            Item.value = 150;
        }

        // Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
        public override void AddRecipes() {
            
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.WoodenTable, 1);
            recipe.AddIngredient<Items.Materials.SteelBar>(3);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}