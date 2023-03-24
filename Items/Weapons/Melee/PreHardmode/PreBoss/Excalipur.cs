using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;using WorldGen = On.Terraria.WorldGen;

namespace EverythingFromNowhere.Items.Weapons.Melee.PreHardmode.PreBoss
{
    public class Excalipur : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Excalipur");
            Tooltip.SetDefault("A blade forged from a Dollar Store.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
            Item.value = 0;
            Item.rare = 0;
            Item.DamageType = DamageClass.Melee;
            Item.UseSound = SoundID.Item1;
            Item.damage = 15;
            Item.useTime = 24;
            Item.useAnimation = 24;
            Item.crit = 1;
            Item.knockBack = 5;
            Item.useStyle = 1;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Items.Weapons.Melee.PreHardmode.PreBoss.SteelBroadsword>(1);
            recipe.AddIngredient(ItemID.FallenStar, 7);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}