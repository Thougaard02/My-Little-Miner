using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace My_Little_Miner
{
    class Smeltery
    {

        public string Inventory(Player player)
        {
            string inventory = "";
            for (int i = 0; i < player.Backpack.Count; i++)
            {

        public void MineralSmelt(Player player)
        {
            string refinedMineral = "";

            int userinput = Convert.ToInt32(Console.ReadLine());
            userinput--;
            for (int i = 0; i < player.Backpack.Count; i++)
            {
                if ((int)player.Backpack[i].MineralsType == (int)player.Backpack[i].MineralsType * 3)
                {
                    if (userinput == player.Backpack[i].MineralsType.ToString())
                    {
                        player.Backpack.Remove();
                    }
                }
            }
            return mineralsVariety.ToString();
        }
    }
}