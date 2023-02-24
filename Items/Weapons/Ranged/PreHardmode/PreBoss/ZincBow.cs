using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.Items.Weapons.Ranged.PreHardmode.PreBoss
{
    public class ZincBow : ModItem
    {
        
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zinc Bow");
            
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
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
            Item.damage = 9;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.crit = 2;
            Item.knockBack = 0;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useAmmo = AmmoID.Arrow;
            Item.autoReuse = true;
            Item.shootSpeed = 6f;
            Item.shoot = ProjectileID.PurificationPowder;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Items.Materials.Bars.ZincBar>(8);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
        
    }
}