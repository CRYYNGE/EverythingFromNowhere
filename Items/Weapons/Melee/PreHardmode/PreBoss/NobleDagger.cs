using EverythingFromNowhere.Projectiles.Melee;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.Items.Weapons.Melee.PreHardmode.PreBoss
{
    public class NobleDagger : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Noble Dagger");
            Tooltip.SetDefault("A Dagger given to all who rise to Nobility by tradition.");
        }

        public override void SetDefaults()
        {
            Item.width = 36;
            Item.height = 36;
            Item.maxStack = 1;
            Item.value = 0;
            Item.rare = ItemRarityID.Blue;
            Item.DamageType = DamageClass.MeleeNoSpeed;
            Item.damage = 16;
            Item.useTime = 12;
            Item.useAnimation = 12;
            Item.crit = 1;
            Item.knockBack = 5;
            Item.useStyle = ItemUseStyleID.Rapier;

            Item.noUseGraphic = true;
            Item.noMelee = true;

            Item.shoot = ModContent.ProjectileType<NobleDaggerProj>();
            Item.shootSpeed = 2.1f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.IronBar, 10);
            recipe.AddIngredient<Items.Materials.SteelBar>(7);
            recipe.AddIngredient(ItemID.Sapphire, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}