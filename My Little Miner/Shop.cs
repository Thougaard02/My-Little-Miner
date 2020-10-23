using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Little_Miner
{
    class Shop
    {

        public string Inventory(Player player)
        {
            string inventory = "";

            for (int i = 0; i < player.Backpack.Count; i++)
            {
                inventory += $"{i + 1} {player.Backpack[i].StageOfMineral.ToString()} {player.Backpack[i].MineralsType} \n";
            }
            return inventory;
        }


        public string MineralShop(Player player)
        {

            int userintput = Convert.ToInt32(Console.ReadLine());
            switch (player.Backpack[userintput].MineralsType)
            {
                case MineralsVariety.Cobblestone:
                    player.Money += 10 + MineralValue(player.Backpack[userintput]);
                    player.Backpack.RemoveAt(userintput);
                    break;
                case MineralsVariety.CoalOre:
                    player.Money += 25;
                    player.Backpack.RemoveAt(userintput);
                    break;
                case MineralsVariety.IronOre:
                    player.Money += 40;
                    player.Backpack.RemoveAt(userintput);
                    break;
                case MineralsVariety.GoldOre:
                    player.Money += 70;
                    player.Backpack.RemoveAt(userintput);
                    break;
                case MineralsVariety.DiamondOre:
                    player.Money += 100;
                    player.Backpack.RemoveAt(userintput);
                    break;               
            }
            return null;

        }

        public int MineralValue(Mineral mineral)
        {
            switch (mineral.StageOfMineral)
            {
                case Stage.Raw:
                    return 0;
                case Stage.Refined:
                    return 10;
            }
            return 0;
        }
    }
}
