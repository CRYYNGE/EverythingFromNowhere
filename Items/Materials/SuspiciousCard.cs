using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.Items.Materials;

public class SuspiciousCard : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Suspicious Card");
        Tooltip.SetDefault("If you see this, you are a dirty cheater.");
    }
    
    public override void SetDefaults()
    {
        Item.width = 20;
        Item.height = 20;
        Item.maxStack = 999;
        Item.value = 100;
        Item.rare = ;
    }
}