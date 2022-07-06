using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.Items.Materials;

public class BirdBone : ModItem
{
    
    public void SetStaticDefaults()
    {
        DisplayName.SetDefault("Bird Bone");
        Tooltip.SetDefault("Gross.");
    }
    
    public override void SetDefaults()
    {
        Item.width = 20;
        Item.height = 20;
        Item.maxStack = 999;
        Item.value = 100;
        Item.rare = 1;
    }
}