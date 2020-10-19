using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Little_Miner
{
    class Player
    {

        //Property        
        public string Name { get; set; }

        public bool IsMale { get; set; }

        public Pickaxe MyPickaxe { get; set; }

        public List<Mineral> Backpack { get; set; }

        //Constructor
        public Player(string name, bool gender, Pickaxe myPickaxe)
        {
            Name = name;
            IsMale = gender;
            MyPickaxe = myPickaxe;
            Backpack = new List<Mineral>();
        }

        public string ShowMiningInventory()
        {
            string showInventory = "";
            for (int i = 0; i < Backpack.Count; i++)
            {
                 showInventory += Backpack[i].MineralsType.ToString();
               
                Console.Clear();
            }                       
            return showInventory;
        }
        //public string BackpackInventory()
        //{
        //    foreach (Mineral mineral in Backpack)
        //    {
        //        return mineral.MineralsType.ToString();
        //    }
        //    return null;
        //}
        
    }
}
