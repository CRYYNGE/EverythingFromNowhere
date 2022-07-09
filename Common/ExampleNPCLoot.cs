using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using EverythingFromNowhere.Items.Materials;


namespace EverythingFromNowhere.Common;

public class ExampleNPCLoot : GlobalNPC
{
    public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
    {
        if (npc.type == NPCID.Bird)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BirdBone>(), 1));
            if (Main.rand.Next(0, 100) > 90)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<DocumentShred>(), 1));
            }
        }

        if (npc.type == NPCID.BirdBlue)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BirdBone>(), 1));
            if (Main.rand.Next(0, 100) > 90)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<DocumentShred>(), 1));
            }
        }

        if (npc.type == NPCID.BirdRed)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BirdBone>(), 1));
            if (Main.rand.Next(0, 100) > 90)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<DocumentShred>(), 1));
            }
        }

        if (npc.type == NPCID.GoldBird)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BirdBone>(), 1));
        }

        if (npc.type == NPCID.Vulture)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BirdBone>(), 1));
            npcLoot.Add(ItemDropRule.Common(ItemID.IronOre, 1));
        }
    }
}