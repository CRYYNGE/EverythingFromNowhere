/*using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.NPCs.Enemies.PreHardmode;

public class Demo_Bird : ModNPC
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Explosive Bird");
        Main.npcFrameCount[Type] = 1;
    }

    public override void SetDefaults()
    {
        NPC.width = 18;
        NPC.height = 18;
        NPC.damage = 0;
        NPC.defense = 0;
        NPC.lifeMax = 5;
        NPC.HitSound = SoundID.NPCHit1;
        NPC.DeathSound = SoundID.NPCDeath1;
        NPC.value = 10f;
        NPC.knockBackResist = 0.5f;
        NPC.aiStyle = 0;
        NPC.noGravity = true;
        NPC.noTileCollide = true;
    }
    
    // When it hits the ground, it explodes into feathers
    public override void OnHitGround(int i, int j, int type)
    {
        for (int k = 0; k < 10; k++)
        {
            int dust = Dust.NewDust(new Vector2(npc.position.X, npc.position.Y), npc.width, npc.height, mod.DustType("Demo_Feather"), 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust].noGravity = true;
        }
        npc.active = false;
    }
}*/