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
        Mine mine = new Mine();
        Smeltery smeltery = new Smeltery();
        public void Scene(Player player)
        {            
            MainMenu();
            int userinput = Convert.ToInt32(Console.ReadLine());
            if (userinput == 1)
            {
                Console.Clear();
                Console.WriteLine("Going to the cave...");
                Thread.Sleep(1000);
                Console.WriteLine("1. Being Mining!");
                MiningScene(player);
            }
            else if (userinput == 2)
            {
                Inventory(player);
            }           
        }
        public void MainMenu()
        {
            Console.WriteLine("My LITTLE MINER" + "\n" + "1. Go to the cave and mine" + "\n" + "2. Open your inventory" + "\n" + "3. Smelt your stuff in the smeltery" + "\n" + "4. Go to Shop");
        }
        public void MiningScene(Player player)
        {
            while (true)
            {
                int userinput = Convert.ToInt32(Console.ReadLine());
                if (userinput == 1)
                {
                    Console.Clear();
                    Console.WriteLine("1. Keep Mining" + "\n" + "2. Return To Villages" + "\n" + "You got a new mineral " + mine.GoMining(player));
                }
                if (userinput == 2)
                {
                    Console.WriteLine("Returning to villages...");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Scene(player);
                }
            }
        }
        public void Inventory(Player player)
        {
            //Inventory
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Inventory:" + "\n" + "--------------------------" + "\n");
                Console.WriteLine(player.ShowInventory() + "\n" + "--------------------------");
                Console.WriteLine("1. Close backpack");
                int userinput = Convert.ToInt32(Console.ReadLine());
                if (userinput == 1)
                {
                    Console.Clear();
                    Scene(player);
                }
            }
        }
        //public void SmelteryMinerals()
        //{
        //    Console.WriteLine(smeltery.MineralSmelt(Player player));
        //}
    }
}
