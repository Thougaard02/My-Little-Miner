using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace My_Little_Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            Pickaxe pickaxe = new Pickaxe(PickaxeVariety.Wood);
            Player player = new Player("Rasmus", true, pickaxe);
            Mine game = new Mine();

            while (true)
            {
                Console.WriteLine("You got a new mineral: " + game.GoMining(player));                                            
                Console.ReadKey();
                Console.Clear();
            }                   
        }
    }
}
