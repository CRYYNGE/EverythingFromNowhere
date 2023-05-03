using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.Items.Accessories;

public class BookOfAttack : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Attack Tome");
        Tooltip.SetDefault("A Tome with Knowledge of Attack\n"
                           + "6% increased Melee Damage.\n");

        CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
        Item.accessory = true;
        Item.maxStack = 1;
        Item.width = 32;
        Item.height = 32;
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.GetDamage(DamageClass.Melee) += 0.06f;

    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient<Items.Accessories.EmptyTome>();
        recipe.AddIngredient<Items.Weapons.Melee.PreHardmode.PreBoss.Excalipur>();
        recipe.AddIngredient(ItemID.WoodenSword);
        recipe.AddIngredient(ItemID.IronBroadsword);
        recipe.AddIngredient(ItemID.SilverBroadsword);
        recipe.AddIngredient(ItemID.Gel, 100);
        recipe.AddIngredient(ItemID.Torch, 100);
        recipe.AddTile(TileID.Bookcases);
        recipe.Register();
    }
}