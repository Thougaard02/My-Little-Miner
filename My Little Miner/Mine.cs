﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Little_Miner
{
    class Mine
    {
        public List<Mineral> GoMining(Player player)
        {
            //Chance for minerals
            //Stone = 50%  1/50
            //Coal = 30% 51/81
            //Iron = 10% 82/92
            //Gold = 5% = 93/98
            //Diamond 2% 99/100
            Random r = new Random(Guid.NewGuid().GetHashCode());
            int value = r.Next(1, 100);

            if (value <= 50)
            {                
                return PickaxeFortune(player, MineralsVariety.Stone);
            }
            else if (value >= 51 && value <= 81)
            {
                return PickaxeFortune(player, MineralsVariety.Coal);
            }
            else if (value >= 82 && value <= 92)
            {
                return PickaxeFortune(player, MineralsVariety.Iron);
            }
            else if (value >= 93 && value <= 98)
            {
                return PickaxeFortune(player, MineralsVariety.Gold);
            }
            else if (value >= 99 && value <= 100)
            {
                return PickaxeFortune(player, MineralsVariety.Diamond);
            }
            return null;
        }

        public List<Mineral> PickaxeFortune(Player player, MineralsVariety variety)
        {

            //Chacne of getting extra minerals
            Random rd = new Random();

            int chance = rd.Next(1, 100);
            if (chance > 90)
            {
                for (int i = 0; i < 2; i++)
                {
                    player.Backpack.Add(new Mineral(variety));
                }
            }
            else
            {
                player.Backpack.Add(new Mineral(variety));
                player.Backpack.Add(new Mineral(variety));
                player.Backpack.Add(new Mineral(variety));
                player.Backpack.Add(new Mineral(variety));
                player.Backpack.Add(new Mineral(variety));
                player.Backpack.Add(new Mineral(variety));
                player.Backpack.Add(new Mineral(variety));
                player.Backpack.Add(new Mineral(variety));
                player.Backpack.Add(new Mineral(variety));
                player.Backpack.Add(new Mineral(variety));
                player.Backpack.Add(new Mineral(variety));
            }
            return player.Backpack;
        }
    }
}
