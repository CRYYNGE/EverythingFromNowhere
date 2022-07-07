using EverythingFromNowhere.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.Items.Weapons;

public class BirdBasher : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Wing Clipper");
        Tooltip.SetDefault("The weapon of a veterinarian.");
    }

    public override void SetDefaults()
    {
        Item.damage = 8;
        Item.DamageType = DamageClass.Melee;
        Item.useTime = 25;
        Item.useAnimation = 25;
        Item.useStyle = 1;
        Item.autoReuse = true;
        Item.UseSound = SoundID.Item1;
    }
    
    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ModContent.ItemType<BirdBone>(), 10);
        recipe.AddTile(TileID.WorkBenches);
        recipe.Register();
    }
}