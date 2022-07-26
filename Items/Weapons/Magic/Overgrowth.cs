using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.Items.Weapons.Magic;

public class Overgrowth : ModItem
{
    
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Overgrowth");
        Tooltip.SetDefault("Carved from Ancient Wood, this weapon fires a bolt of nature's power.");
    }

    public override void SetDefaults()
    {
        Item.damage = 4;
        Item.DamageType = DamageClass.Magic;
        Item.useTime = 30;
        Item.useAnimation = 30;
        Item.useStyle = 2;
        Item.autoReuse = true;
        Item.UseSound = SoundID.Item1;
    }
    
    // Shoot a Overgrowth Projectile to the cursor position
    /*public override bool UseItem(Player player)
    {
        int proj = Projectile.NewProjectile(player.position.X, player.position.Y, 0, 0, mod.ProjectileType("OvergrowthProjectile"), Item.damage, 0, player.whoAmI);
        return true;
    }*/
}