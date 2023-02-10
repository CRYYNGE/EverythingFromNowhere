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
            Item.rare = 1;
            Item.maxStack = 9999;
        }
    }
}