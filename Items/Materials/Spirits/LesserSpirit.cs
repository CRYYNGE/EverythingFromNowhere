using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.Items.Materials.Spirits
{
    public class LesserSpirit : ModItem
    {
        
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lesser Spirit");
            Tooltip.SetDefault("It's like looking into nothing.");
            
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25;
        }
        
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 999;
            Item.value = 0;
            Item.rare = ItemRarityID.Blue;
        }
    }
}