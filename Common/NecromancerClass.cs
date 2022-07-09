using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace EverythingFromNowhere.Common
{
    
    public class Necromancer : ModPlayer
    {

        public int Souls;

        public override void Initialize()
        {
            Souls = 0;

            base.Initialize();
        }

        public override void SaveData(TagCompound tag)
        {
            
            tag.Add("killskey", Souls);



        }

        public override void LoadData(TagCompound tag)
        {
            if (tag.ContainsKey("killskey"))
            {
                Souls = tag.GetInt("killskey");
            }
        }

    }

}