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

                inventory += $"{i + 1 } {player.Backpack[i].StageOfMineral.ToString()} {player.Backpack[i].MineralsType} \n";
            }
            return inventory;
        }
        public string MineralSmelt(Player player)
        {
            string refinedMineral = "";

            int userinput = Convert.ToInt32(Console.ReadLine());
            userinput--;
            for (int i = 0; i < player.Backpack.Count; i++)
            {
                if (userinput == i && player.Backpack[i].StageOfMineral == Stage.Raw)
                {
                    player.Backpack[i].StageOfMineral = Stage.Refined;
                    refinedMineral = player.Backpack[i].StageOfMineral.ToString() + FormatEnum(player.Backpack[i].MineralsType);
                }
            }
            return refinedMineral;
        }

        private string FormatEnum(MineralsVariety mineralsVariety)
        {
            //Print mined minerals name
            switch (mineralsVariety)
            {
                case MineralsVariety.Cobblestone:
                    return " Cobblestone";
                case MineralsVariety.CoalOre:
                    return " Coal Ore";
                case MineralsVariety.IronOre:
                    return " Iron Ore";
                case MineralsVariety.GoldOre:
                    return " Gold Ore";
                case MineralsVariety.DiamondOre:
                    return " Diamond Ore";
            }
            return mineralsVariety.ToString();
        }
    }
}