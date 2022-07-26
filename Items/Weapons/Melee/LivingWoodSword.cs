using EverythingFromNowhere.Items.Materials;
using Humanizer;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.Items.Weapons.Melee;

public class LivingWoodSword : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Living Wood Sword");
        Tooltip.SetDefault("Finally a use for that silly wand.");
    }

    public override void SetDefaults()
    {
        Item.damage = 7;
        Item.DamageType = DamageClass.Melee;
        Item.knockBack = 6;
        Item.useTime = 25;
        Item.useAnimation = 25;
        Item.useStyle = 1;
        Item.autoReuse = true;
        Item.UseSound = SoundID.Item1;
    }
    
    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.Wood, 7);
        recipe.AddTile(TileID.WorkBenches);
        recipe.AddTile(TileID.LivingWood);
        recipe.Register();
    }
}