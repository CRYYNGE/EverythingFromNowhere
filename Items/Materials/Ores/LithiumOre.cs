using IL.Terraria.GameContent;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace EverythingFromNowhere.Items.Materials.Ores
{
    public class LithiumOreItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lithium Ore");
            Tooltip.SetDefault("Used in Batteries.");
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
            Item.createTile = ModContent.TileType<Tiles.Ores.PreHardmode.LithiumOreTile>();
        }
    }
}