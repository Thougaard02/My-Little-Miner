using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace My_Little_Miner
{
    class Menu
    {

        public void MainMenu()
        {
            Pickaxe pickaxe = new Pickaxe(PickaxeVariety.Wood);
            Player player = new Player("Rasmus", true, pickaxe);
            Mine game = new Mine();


            lort();
            int userinput = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

        }

        public void lort()
        {
            Console.WriteLine("My Little Miner");
            Console.WriteLine("1. Go Mine");
            Console.WriteLine("2. Open inventory");
            Console.WriteLine("3. Smeltery");
            Console.WriteLine("4. Go to shop");
        }
    }
}
