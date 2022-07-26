using ExampleMod.Content.BossBars;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.NPCs.Bosses.WitchWoods;

[AutoloadBossHead]
public class WitchWoods : ModNPC
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Witch of the Woods");
        Main.npcFrameCount[Type] = 1;
    }
    
    public override void SetDefaults() {
        NPC.width = 110;
        NPC.height = 110;
        NPC.damage = 12;
        NPC.defense = 10;
        NPC.lifeMax = 2000;
        NPC.HitSound = SoundID.NPCHit1;
        NPC.DeathSound = SoundID.NPCDeath1;
        NPC.knockBackResist = 0f;
        NPC.noGravity = true;
        NPC.noTileCollide = true;
        NPC.value = Item.buyPrice(gold: 5);
        NPC.SpawnWithHigherTime(30);
        NPC.boss = true;
        NPC.npcSlots = 10f; // Take up open spawn slots, preventing random NPCs from spawning during the fight

        // Don't set immunities like this as of 1.4:
        // NPC.buffImmune[BuffID.Confused] = true;
        // immunities are handled via dictionaries through NPCID.Sets.DebuffImmunitySets

        // Custom AI, 0 is "bound town NPC" AI which slows the NPC down and changes sprite orientation towards the target
        NPC.aiStyle = -1;

        // Custom boss bar
        //NPC.BossBar = ModContent.GetInstance<WitchWoodBar>();

        // The following code assigns a music track to the boss in a simple way.
        /*if (!Main.dedServ) {
            Music = MusicLoader.GetMusicSlot(Mod, "Assets/Music/Ropocalypse2");
        }*/
    }
}