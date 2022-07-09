using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.Items.Materials;

public class DocumentShred : ModItem
{
    
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Document Shred");
        Tooltip.SetDefault("It was strapped to a Bird.");
    }
    
    public override void SetDefaults()
    {
        Item.width = 20;
        Item.height = 20;
        Item.maxStack = 999;
        Item.value = 100;
        Item.rare = 0;
    }
}