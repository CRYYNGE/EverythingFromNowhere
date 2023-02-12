using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.IO;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace EverythingFromNowhere.Tiles.Ores.PreHardmode
{
    public class LithiumOreTile : ModTile
    {
        public override void SetStaticDefaults()
        {
            TileID.Sets.Ore[Type] = true;
            Main.tileSpelunker[Type] = true; // The tile will be affected by spelunker highlighting
            Main.tileOreFinderPriority[Type] = 410; // Metal Detector value, see https://terraria.gamepedia.com/Metal_Detector
            Main.tileShine2[Type] = true; // Modifies the draw color slightly.
            Main.tileShine[Type] = 975; // How often tiny dust appear off this tile. Larger is less frequently
            Main.tileMergeDirt[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Lithium Ore");
            AddMapEntry(new Color(230, 230, 230), name);

            DustType = 84;
            ItemDrop = ModContent.ItemType<Items.Materials.Ores.LithiumOreItem>();
            HitSound = SoundID.Tink;
            // MineResist = 4f;
            // MinPick = 200;
        }
    }

    public class LithiumGen : ModSystem
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));

            if (ShiniesIndex != -1)
            {
                tasks.Insert(ShiniesIndex + 1, new LithiumOrePass("Lithium", 237.4298f));
            }
        }

        public class LithiumOrePass : GenPass
        {
            public LithiumOrePass(string name, float loadWeight) : base(name, loadWeight)
            {
            }

            protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
            {
                progress.Message = "Placing Lithium...";

                for (int k = 0; k < (int) (Main.maxTilesX * Main.maxTilesY * 6E-05); k++)
                {
                    int x = WorldGen.genRand.Next(0, Main.maxTilesX);

                    int y = WorldGen.genRand.Next((int) WorldGen.worldSurfaceLow, Main.maxTilesY);
                    
                    WorldGen.TileRunner(x, y, WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6),
                        ModContent.TileType<LithiumOreTile>());
                }
            }
        }
    }
}