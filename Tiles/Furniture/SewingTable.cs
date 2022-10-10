using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace EverythingFromNowhere.Tiles.Furniture
{
    public class SewingTable : ModTile
    {
        public override void SetStaticDefaults() {
            // Properties
            Main.tileTable[Type] = false;
            Main.tileSolidTop[Type] = false;
            Main.tileNoAttach[Type] = false;
            Main.tileLavaDeath[Type] = true;
            Main.tileFrameImportant[Type] = true;
            TileID.Sets.DisableSmartCursor[Type] = true;
            TileID.Sets.IgnoredByNpcStepUp[Type] = true; // This line makes NPCs not try to step up this tile during their movement. Only use this for furniture with solid tops.
            
            AdjTiles = new int[] { TileID.Loom };

            // Placement
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
            TileObjectData.newTile.CoordinateHeights = new[] { 18 };
            TileObjectData.addTile(Type);

            // Etc
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Sewing Table");
            AddMapEntry(new Color(200, 200, 200), name);
        }

        public override void NumDust(int x, int y, bool fail, ref int num) {
            num = fail ? 1 : 3;
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY) {
            Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 16, ModContent.ItemType<Items.Placeables.Furniture.SewingTableItem>());
        }
    }
}