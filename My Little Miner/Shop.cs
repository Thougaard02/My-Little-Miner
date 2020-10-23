using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Little_Miner
{
    class Shop
    {
        //Money of mineral
        //Cobblestone = 10
        //Coal ore = 25
        //Iron ore = 40
        //Gold ore = 70
        //Diamond ore = 80

        public string Inventory(Player player)
        {
            string inventory = "";

            for (int i = 0; i < player.Backpack.Count; i++)
            {
                inventory += $"{i} {player.Backpack[i].StageOfMineral} {player.Backpack[i].MineralsType} \n";
            }
            return inventory;
        }

        public string MineralSell(Player player)
        {
            string mineralSold = "";
            int userintput = Convert.ToInt32(Console.ReadLine());
            
            switch (player.Backpack[userintput].MineralsType)
            {
                case MineralsVariety.Cobblestone:
                    player.Money += 10 + StageValue(player.Backpack[userintput]);
                    mineralSold = $"You have sold {player.Backpack[userintput].MineralsType}";
                    player.Backpack.RemoveAt(userintput);
                    break;
                case MineralsVariety.CoalOre:
                    player.Money += 25 + StageValue(player.Backpack[userintput]);
                    mineralSold = $"You have sold {player.Backpack[userintput].MineralsType}";
                    player.Backpack.RemoveAt(userintput);
                    break;
                case MineralsVariety.IronOre:
                    player.Money += 40 + StageValue(player.Backpack[userintput]);
                    mineralSold = $"You have sold {player.Backpack[userintput].MineralsType}";
                    player.Backpack.RemoveAt(userintput);
                    break;
                case MineralsVariety.GoldOre:
                    player.Money += 70 + StageValue(player.Backpack[userintput]);
                    mineralSold = $"You have sold {player.Backpack[userintput].MineralsType}";
                    player.Backpack.RemoveAt(userintput);
                    break;
                case MineralsVariety.DiamondOre:
                    player.Money += 100 + StageValue(player.Backpack[userintput]);
                    mineralSold = $"You have sold {player.Backpack[userintput].MineralsType}";
                    player.Backpack.RemoveAt(userintput);
                    break;
            }
            return mineralSold;
        }

        public int StageValue(Mineral mineral)
        {
            switch (mineral.StageOfMineral)
            {
                case Stage.Raw:
                    return 0;
                case Stage.Refined:
                    return 10;
                default:
                    return 0;
            }
        }

        
    }
}
