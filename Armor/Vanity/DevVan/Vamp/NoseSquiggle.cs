using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.Armor.Vanity.DevVan.Vamp
{
    // This tells tModLoader to look for a texture called MinionBossMask_Head, which is the texture on the player
    // and then registers this item to be accepted in head equip slots
    [AutoloadEquip(EquipType.Head)]
    public class NoseSquiggle : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Nose Squiggle");
            Tooltip.SetDefault("How's it feel being a dirty cheater, or me?");
            ArmorIDs.Head.Sets.DrawFullHair[Item.headSlot] = true;

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults() {
            Item.width = 22;
            Item.height = 28;

            // Common values for every boss mask
            Item.rare = ItemRarityID.Purple;
            Item.value = Item.sellPrice(gold: 1);
            Item.vanity = true;
            Item.maxStack = 1;
        }
    }
}