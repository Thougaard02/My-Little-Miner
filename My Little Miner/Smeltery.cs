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

        public enum SmeltMinerals
        {
            Stone,
            Coal,
            Iron,
            Gold,
            Diamond
        }

        public void MineralSmelt(Player player)
        {
            string userinput = Console.ReadLine();
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
        }
    }
}

//loop igennem for at få raw mineraler
//Change raw minerals to smelted minerals
//clear raw minerals
//add smelted minerals to backpack