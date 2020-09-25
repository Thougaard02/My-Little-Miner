using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Little_Miner
{
    class Player
    {

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Pickaxe playerPickaxe;
        public Pickaxe PlayerPickaxe
        {
            get { return playerPickaxe; }
            set { playerPickaxe = value; }
        }

        private int HealthBar;
        public int healthBar
        {
            get { return healthBar; }
            set { healthBar = value; }
        }
        public Player(string name, Pickaxe pickaxe, int healthBar)
        {
            Name = "Miner " + name;
            PlayerPickaxe = pickaxe;
            HealthBar = healthBar;
        }


                        
    }
}
