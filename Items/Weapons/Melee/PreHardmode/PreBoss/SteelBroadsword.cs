using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;using WorldGen = On.Terraria.WorldGen;

namespace EverythingFromNowhere.Items.Weapons.Melee.PreHardmode.PreBoss
{
    public class SteelBroadsword : ModItem
    {
        
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Steel Broadsword");
            Tooltip.SetDefault("And they said Chivalry was dead.");
            
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
            Item.damage = 14;
            Item.useTime = 24;
            Item.useAnimation = 24;
            Item.crit = 2;
            Item.knockBack = 7;
            Item.useStyle = 1;
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