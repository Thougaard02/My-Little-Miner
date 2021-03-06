﻿using System.Collections.Generic;

namespace My_Little_Miner
{
    class Player
    {

        //Property        
        public string Name { get; set; }

        public bool IsMale { get; set; }

        public Pickaxe MyPickaxe { get; set; }

        public int Money { get; set; }

        public List<Mineral> Backpack { get; set; }

        public int Health { get; set; }


        //Constructor
        public Player(string name, bool gender, Pickaxe myPickaxe, int PlayerHealth)
        {
            Name = name;
            IsMale = gender;
            MyPickaxe = myPickaxe;
            Money = Money;
            Backpack = new List<Mineral>();
            Health = PlayerHealth;

        }
        public string ShowInventory()
        {
            string backpack = "";
            for (int i = 0; i < Backpack.Count; i++)
            {
                backpack += FormatEnum(Backpack[i].MineralsType) + "\n";
            }
            return backpack;
        }
        private string FormatEnum(MineralsVariety mineralsVariety)
        {
            //Print minerals name out in inventory
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