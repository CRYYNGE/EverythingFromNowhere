/*using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EveryNo.Items.Accessories
{
    [AutoloadEquip(EquipType.Wings)]
    public class Glider : ModItem
    {
        //A pair of wings that allow the player to glide.
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glider");
            Tooltip.SetDefault("Good for going anywhere but up.");
        }
        
        //Set the item properties.
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 20;
            Item.value = Item.buyPrice(0, 0, 5, 0);
            Item.rare = ItemRarityID.Green;
            Item.accessory = true;
        
        
        //Add the wings to the player.
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.wingTimeMax = 0;
        }
        
        //Recipes.
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Silk, 50);
            recipe.AddIngredient(ItemID.Wood, 25);
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}*/