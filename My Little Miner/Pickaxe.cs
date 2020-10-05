using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Little_Miner
{
    public enum PickaxeVariety
    {
        Wood,
        Stone,
        Iron,
        Gold,
        Diamond
    }
    class Pickaxe
    {
        private PickaxeVariety pickaxeType;
        public PickaxeVariety PickaxeType { get; set; }

        private int pickaxehealth;
        public int PickaxeHealth { get; set; }

        private int pickaxedamage;
        public int PickaxeDamage { get; set; }

        public Pickaxe(PickaxeVariety pickaxe)
        {
            PickaxeHealth = pickaxehealth;
            PickaxeDamage = pickaxedamage;
            PickaxeType = pickaxe;
        }
    }
}
