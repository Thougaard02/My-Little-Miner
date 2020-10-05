using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Little_Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            Pickaxe woodPickaxe = new Pickaxe(PickaxeVariety.Wood);
            Pickaxe stonePickaxe = new Pickaxe(PickaxeVariety.Stone);
        }
    }
}
