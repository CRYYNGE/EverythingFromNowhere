using On.Terraria.GameContent.Golf;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EverythingFromNowhere.Items.Materials.Ores
{
    public class ZincOreItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zinc Ore");
            Tooltip.SetDefault("A small amount of Zinc.");
        }

        public override void SetDefaults()
        {
            Item.maxStack = 999;
            Item.useTime = 10;
            Item.useAnimation = 10;
            Item.placeStyle = 0;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.Ores.PreHardmode.ZincOreTile>();
        }
    }
}