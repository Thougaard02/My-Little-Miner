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
        private string name;
        public string Name { get; set; }

        private bool isMale;
        public bool IsMale { get; set; }

        private Pickaxe myPickaxe;
        public Pickaxe MyPickaxe{ get; set; }

        private List<Mineral> backpack;

        public List<Mineral> Backpack { get; set; }



        //Constructor
        public Player(string name, bool gender, Pickaxe myPickaxe)
        {
            Name = name;
            IsMale = gender;
            MyPickaxe = myPickaxe;
            Backpack = new List<Mineral>();
        }

        void BackPackInventory(List<Mineral> backpack)
        {
            foreach (Mineral minerals in backpack)
            {
                Console.WriteLine(minerals.MineralsType);
            }
        }

    }
}
