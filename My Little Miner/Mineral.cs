using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Little_Miner
{
    class Mineral
    {
        public enum MineralType
        {
            Wood,
            Iron,
            Gold,
            Diamond,
            Obsidian
        }

        private float cost;
        public float Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        private float health;
        public float Health
        {
            get { return health; }
            set { health = value; }
        }
    }
}
