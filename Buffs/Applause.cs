using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EverythingFromNowhere.Buffs
{
	// This class serves as an example of a debuff that causes constant loss of life
	// See ExampleLifeRegenDebuffPlayer.UpdateBadLifeRegen at the end of the file for more information
	public class Applause : ModBuff
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Applause"); // Buff display name
			Description.SetDefault("Listen here you jerk! Increased Mana Regen."); // Buff description
			Main.debuff[Type] = false;  // Is it a debuff?
			Main.pvpBuff[Type] = true; // Players can give other players buffs, which are listed as pvpBuff
			Main.buffNoSave[Type] = true; // Causes this buff not to persist when exiting and rejoining the world
			BuffID.Sets.LongerExpertDebuff[Type] = false; // If this buff is a debuff, setting this to true will make this buff last twice as long on players in expert mode
		}

		// Allows you to make this buff give certain effects to the given player
		public override void Update(Player player, ref int buffIndex) {
			player.manaRegen += 2;
		}
	}

	public class ExampleLifeRegenDebuffPlayer : ModPlayer
	{
		// Flag checking when life regen debuff should be activated
		public bool manaRegenBuff = false;

		public override void ResetEffects() {
			manaRegenBuff = false;
		}

		// Allows you to give the player a negative life regeneration based on its state (for example, the "On Fire!" debuff makes the player take damage-over-time)
		// This is typically done by setting player.lifeRegen to 0 if it is positive, setting player.lifeRegenTime to 0, and subtracting a number from player.lifeRegen
		// The player will take damage at a rate of half the number you subtract per second
		public override void UpdateBadLifeRegen() {
			if (manaRegenBuff) {
				// These lines zero out any positive lifeRegen. This is expected for all bad life regeneration effects
				if (Player.manaRegen > 0)
					Player.manaRegen = 0;
				// Player.lifeRegenTime uses to increase the speed at which the player reaches its maximum natural life regeneration
				// So we set it to 0, and while this debuff is active, it never reaches it
				//Player.manaRegen = 0;
				// lifeRegen is measured in 1/2 life per second. Therefore, this effect causes 8 life lost per second
				Player.manaRegen += 16;
			}
		}
	}
}