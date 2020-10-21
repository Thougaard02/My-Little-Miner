using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Little_Miner
{
    class Mine
    {
        public string GoMining(Player player)
        {
            //Chance for minerals
            //Stone = 50%  1/50
            //Coal = 30% 51/81
            //Iron = 10% 82/92
            //Gold = 5% = 93/98
            //Diamond 2% 99/100
            
            string temp = "";
            Random r = new Random(Guid.NewGuid().GetHashCode());
            int value = r.Next(1, 100);
            
            if (value <= 50)
            {
                temp = PickaxeFortune(player, MineralsVariety.Cobblestone, temp);
                return temp;
            }
            else if (value >= 51 && value <= 81)
            {
                temp = PickaxeFortune(player, MineralsVariety.CoalOre, temp);
                return temp;
            }
            else if (value >= 82 && value <= 92)
            {
                temp = PickaxeFortune(player, MineralsVariety.IronOre, temp);
                return temp;
            }
            else if (value >= 93 && value <= 98)
            {
                temp = PickaxeFortune(player, MineralsVariety.GoldOre, temp);
                return temp;
            }
            else if (value >= 99 && value <= 100)
            {
                temp = PickaxeFortune(player, MineralsVariety.DiamondOre, temp);
                return temp;
            }
            return null;
        }
        public string PickaxeFortune(Player player, MineralsVariety variety,string temp)
        {
            //returing minerals to players' backpack           
            Random rd = new Random();
            int chance = rd.Next(1, 100);
            
            //Chance of getting 2x minerals
            if (chance >= 90)
            {
                for (int i = 0; i < 2; i++)
                {
                    player.Backpack.Add(new Mineral(variety));
                    temp = FormatEnum(variety) + " 2x"; 
                }
                return temp;
            }
            //Return 1x mineral
            else
            {
                player.Backpack.Add(new Mineral(variety));
                temp = FormatEnum(variety);
                return temp;
            }
        }

        private string FormatEnum(MineralsVariety mineralsVariety)
        {
            //Print mined minerals name
            switch (mineralsVariety)
            {
                case MineralsVariety.Cobblestone:
                    break;
                case MineralsVariety.CoalOre:
                    return "Coal Ore";                    
                case MineralsVariety.IronOre:
                    return "Iron Ore";                    
                case MineralsVariety.GoldOre:
                    return "Gold Ore";
                case MineralsVariety.DiamondOre:
                    return "Diamond Ore";
            }
            return mineralsVariety.ToString();
        }
    }
}
