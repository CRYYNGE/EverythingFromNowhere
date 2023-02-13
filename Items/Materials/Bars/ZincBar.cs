using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.Items.Materials.Bars
{
    public class ZincBar : ModItem
    {
        
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zinc Bar");
            Tooltip.SetDefault("This Zinc is not filled with Ink that makes you pink.");
            
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25;
        }
        
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 999;
            Item.value = 0;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.placeStyle = 0;
            Item.useTime = 10;
            Item.useAnimation = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.rare = 0;
            Item.createTile = ModContent.TileType<Tiles.Bars.ZincTileBar>();
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Items.Materials.Ores.ZincOreItem>(3);
            recipe.AddTile(TileID.Furnaces);
            recipe.Register();
            
        }
    }
}