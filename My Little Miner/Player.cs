using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        static void BackpackInventory(List<Mineral> backpack)
        {
            foreach (Mineral mineral in backpack )
            {
                Console.WriteLine(mineral.MineralsType.ToString());
            }
        }


       
    }
}
