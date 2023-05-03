using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;using WorldGen = On.Terraria.WorldGen;

namespace EverythingFromNowhere.Items.Weapons.Melee.PreHardmode.PreBoss
{
    public class CatClaws : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cat Claws");
            Tooltip.SetDefault("Forged from the cuteness of a thousand kittens.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 15;
            Item.height = 15;
            Item.maxStack = 1;
            Item.value = 0;
            Item.rare = ItemRarityID.White;
            Item.DamageType = DamageClass.Melee;
            Item.UseSound = SoundID.Item1;
            Item.damage = 9;
            Item.useTime = 5;
            Item.useAnimation = 5;
            Item.autoReuse = true;
            Item.crit = 1;
            Item.knockBack = 5;
            Item.useStyle = 1;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Silk, 14);
            recipe.AddIngredient(ItemID.Cobweb, 26);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}