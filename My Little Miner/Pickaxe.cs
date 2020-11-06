using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Little_Miner
{
    //Variety of Pickaxes
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
        //Property
        public PickaxeVariety PickaxeType { get; set; }

        //Constructor
        public Pickaxe(PickaxeVariety pickaxe)
        {
            PickaxeType = pickaxe;      
        }
    }
}
