using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;using WorldGen = On.Terraria.WorldGen;

namespace EverythingFromNowhere.Items.Weapons.Melee.PreHardmode.PreBoss
{
    public class RubberBat : ModItem
    {
        
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rubber Bat");
            Tooltip.SetDefault("Beater of Fat Italians everywhere.");
            
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
            Item.damage = 16;
            Item.useTime = 16;
            Item.useAnimation = 16;
            Item.crit = 2;
            Item.knockBack = 9;
            Item.useStyle = 1;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Gel, 50);
            recipe.AddTile(TileID.Solidifier);
            recipe.Register();
        }
    }
}