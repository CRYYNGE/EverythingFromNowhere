using EverythingFromNowhere.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.Items.Weapons.Ranged;

public class ImprovisedZapper : ModItem
{
    
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Impromptu Zapper");
        Tooltip.SetDefault("Kinda like a gun, but uses electricity instead of bullets.");
    }

    public override void SetDefaults()
    {
        Item.DamageType = DamageClass.Magic;
        Item.mana = 5;
        Item.width = 32;
        Item.height = 32;
        Item.maxStack = 1;
        Item.consumable = false;
        Item.useStyle = 5;
        Item.useTime = 20;
        Item.useAnimation = 20;
        Item.knockBack = 2.5f;
        Item.shootSpeed = 10f;
        Item.damage = 10;
        Item.shoot = ProjectileID.Bullet;
    }

    
    
    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ModContent.ItemType<Components>(), 5);
        recipe.AddIngredient(ModContent.ItemType<ManaBattery>());
        recipe.AddTile(TileID.Anvils);
        recipe.Register();
    }
}