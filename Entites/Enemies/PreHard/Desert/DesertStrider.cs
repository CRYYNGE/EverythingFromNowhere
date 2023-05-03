using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.Entites.Enemies.PreHard.Desert
{
    public class DesertStrider : ModNPC
    {
        private const float MaxSpeed = 12f;
        private const float TurnSpeed = 0.54f;
        private const float TurnThreshold = 120f;
        private const float MinDistance = 100f;

        private float MaxDistance = 500f; // Declare and initialize MaxDistance here

        private bool charging;
        private Vector2 chargeDirection;
        private float chargeSpeed;
        private float turnSpeed;
        private float turnProgress;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Desert Strider");
            Main.npcFrameCount[NPC.type] = 5;
        }

        public override void SetDefaults()
        {
            NPC.width = 32;
            NPC.height = 32;
            NPC.aiStyle = -1;
            NPC.damage = 20;
            NPC.defense = 10;
            NPC.lifeMax = 200;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.value = 100f;
            NPC.knockBackResist = 0f;
        }

        public override void AI()
        {
            Player player = Main.player[NPC.target];
            Vector2 targetDirection = player.Center - NPC.Center;
            float targetDistance = targetDirection.Length();

            if (charging)
            {
                NPC.velocity = chargeDirection * chargeSpeed;
                turnProgress = 0f;

                if (targetDistance > MinDistance || NPC.collideX || NPC.collideY)
                {
                    charging = false;
                    turnSpeed = TurnSpeed;
                }
            }
            else
            {
                float speedLimit = MaxSpeed * NPC.scale;
                float currentSpeed = NPC.velocity.Length();
                float speedChange = speedLimit - currentSpeed;

                if (speedChange > 0f)
                {
                    NPC.velocity += Vector2.Normalize(targetDirection) * speedChange;
                }

                float angleToTarget = targetDirection.ToRotation();
                float angleDifference = MathHelper.WrapAngle(angleToTarget - NPC.velocity.ToRotation());

                if (Math.Abs(angleDifference) < TurnThreshold)
                {
                    NPC.velocity = NPC.velocity.RotatedBy(-angleDifference * turnSpeed);
                    turnProgress += Math.Abs(angleDifference) * turnSpeed;

                    if (turnProgress >= 1f)
                    {
                        charging = true;
                        chargeDirection = NPC.velocity;
                        chargeSpeed = NPC.velocity.Length();
                        turnProgress = 0f;
                    }
                }
                else
                {
                    NPC.velocity = NPC.velocity.RotatedBy(TurnThreshold * Math.Sign(angleDifference));
                    turnProgress = 0f;
                }
            }
        }
    }
}