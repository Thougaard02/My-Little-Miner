using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace My_Little_Miner
{
    public enum MineralsVariety
    {
        Stone,
        Coal,
        Iron,
        Gold,
        Diamond
        
    }
    class Mineral
    {

        private MineralsVariety mineralsType;

        public MineralsVariety MineralsType { get; set; }

        private int health;
        public int Health { get; set; }

        private float cost;
        public float Cost { get; set; }

        public Mineral(MineralsVariety mineral)
        {
            MineralsType = mineral;
            Health = health;
            Cost = cost;

        }
    }
}
