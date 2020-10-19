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

        public string BackPackInventory()
        {
            for (int i = 0; i < Backpack.Count; i++)
            {
                string showInventory = Backpack[i].MineralsType.ToString();
                return showInventory;
            }
            

            //foreach (Mineral minerals in Backpack)
            //{
            //    string showInventory = minerals.MineralsType.ToString();
            //    return showInventory;
            //}
            return null;
        }

    }
}
