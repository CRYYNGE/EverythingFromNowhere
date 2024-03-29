using Terraria;
using Terraria.GameContent.Creative;
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
            Item.createTile = ModContent.TileType<Tiles.Bars.SteelTileBar>();
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 1);
            recipe.AddIngredient(ItemID.IronOre, 3);
            recipe.AddTile(TileID.Furnaces);
            recipe.Register();
            
        }
    }
}