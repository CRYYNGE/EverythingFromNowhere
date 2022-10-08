using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;using WorldGen = On.Terraria.WorldGen;

namespace EverythingFromNowhere.Items.Weapons.Ranged.PreHardmode.PreBoss
{
    public class SteelBow : ModItem
    {
        
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Steel Bow");
        }
        
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
            Item.value = 0;
            Item.rare = 0;
            Item.DamageType = DamageClass.Ranged;
            Item.UseSound = SoundID.Item5;
            Item.damage = 11;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.crit = 2;
            Item.knockBack = 7;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useAmmo = AmmoID.Arrow;
            Item.autoReuse = true;
            Item.shootSpeed = 7f;
            Item.shoot = ProjectileID.PurificationPowder;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Items.Materials.SteelBar>(9);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
        
    }
}