using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace EverythingFromNowhere.Common
{
    
    public class Necromancer : ModPlayer
    {

        public int kills;

        public override void Initialize()
        {
            kills = 0;

            base.Initialize();
        }

        public override void SaveData(TagCompound tag)
        {
            
            tag.Add("killskey", kills);



        }

        public override void LoadData(TagCompound tag)
        {
            if (tag.ContainsKey("killskey"))
            {
                kills = tag.GetInt("killskey");
            }
        }

    }

}