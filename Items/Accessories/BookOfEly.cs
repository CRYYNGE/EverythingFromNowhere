using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.Items.Accessories;

public class BookOfEly : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Beginners Guide to the Elysium");
        Tooltip.SetDefault("A Tome with Knowledge of the land above.\n"
                           + "With time and recourses you may attune to the Elysium more.\n"
                           + "6% increased Health Regen.\n"
                           + "6% increased Mana Gain\n"
                           + "6% increased Melee Damage");

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
        player.lifeRegen += 6;
        player.manaRegen += 6;
        player.GetDamage(DamageClass.Melee) += 0.06f;
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient<Items.Accessories.BookOfAid>();
        recipe.AddIngredient<Items.Accessories.BookOfAttack>();
        recipe.AddIngredient<Items.Accessories.BookOfMana>();
        recipe.AddTile(TileID.Bookcases);
        recipe.Register();
    }
}