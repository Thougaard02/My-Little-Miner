﻿using System;
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
                inventory += $"{i + 1} {player.Backpack[i].StageOfMineral} {player.Backpack[i].MineralsType} \n";
            }
            return inventory;
        }

        public string MineralSell(Player player)
        {
            string mineralSold = "";
            int userintput = Convert.ToInt32(Console.ReadLine());
            userintput--;
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

        public string ShopPickaxe()
        {
            string pickaxeList = "";
            Type pickaxeType = typeof(PickaxeVariety);
            string[] pickaxeName = pickaxeType.GetEnumNames();
            for (int i = 0; i < pickaxeName.Length; i++)
            {
                pickaxeList += $"{i + 1}. Pickaxe {pickaxeName[i]}\n";
            }
            return pickaxeList;
        }

        public string BuyPickaxe(Player player)
        {
            //minus med player.money
            string pickaxeBought = "";
            int userinput = Convert.ToInt32(Console.ReadLine());

            if (userinput == 1 && player.Money >= 50)
            {
                player.Money -= 50;
                player.MyPickaxe.PickaxeType = PickaxeVariety.Wood;
                pickaxeBought = $"You bought {player.MyPickaxe.PickaxeType}";

            }
            else if (userinput == 2 && player.Money >= 100)
            {
                player.Money -= 100;
                player.MyPickaxe.PickaxeType = PickaxeVariety.Stone;
                pickaxeBought = $"You bought {player.MyPickaxe.PickaxeType}";
            }
            else if (userinput == 3 && player.Money >= 200)
            {
                player.Money -= 200;
                player.MyPickaxe.PickaxeType = PickaxeVariety.Iron;
                pickaxeBought = $"You bought {player.MyPickaxe.PickaxeType}";
            }
            else if (userinput == 4 && player.Money >= 400)
            {
                player.Money -= 400;
                player.MyPickaxe.PickaxeType = PickaxeVariety.Gold;
                pickaxeBought = $"You bought {player.MyPickaxe.PickaxeType}";
            }
            else if (userinput == 5 && player.Money >= 1000)
            {
                player.Money -= 1000;
                player.MyPickaxe.PickaxeType = PickaxeVariety.Diamond;
                pickaxeBought = $"You bought {player.MyPickaxe.PickaxeType}";
            }

            return pickaxeBought;
        }

    }
}
