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
            //Menu, MiningScene, Inventory, Smeltery, and shop           
            MainMenu();
            int userinput = Convert.ToInt32(Console.ReadLine());

            //Going to cave and mining
            if (userinput == 1)
            {
                Console.Clear();
                Console.WriteLine("Going to the cave...");
                //Thread.Sleep(1000);
                Console.WriteLine("1. Being Mining!");
                MiningScene(player);
            }

            //Show player's inventory
            else if (userinput == 2)
            {
                Inventory(player);
            }

            //Smeltery "Smelt your raw minerals in player backpack"
            else if (userinput == 3)
            {
                SmelteryScene(player);
                Console.ReadKey();

            }
        }
        public void MainMenu()
        {
            //Main Menu
            Console.WriteLine("My LITTLE MINER" + "\n" + "1. Go to the cave and mine" + "\n" + "2. Open your inventory" + "\n" + "3. Smelt your stuff in the smeltery" + "\n" + "4. Go to Shop");
        }
        public void MiningScene(Player player)
        {
            //Player mining minerals
            while (true)
            {
                int userinput = Convert.ToInt32(Console.ReadLine());
                //Player keeps mining minerals
                if (userinput == 1)
                {
                    Console.Clear();
                    Console.WriteLine("1. Keep Mining" + "\n" + "2. Return To Villages" + "\n" + "You got a new mineral " + mine.GoMining(player));
                }

                //Player returing to villages (Main Menu)
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
            //Open players' backpack inventory of minerals
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Inventory: \n--------------------------\n{player.ShowInventory()}--------------------------\n1. Close backpack  ");
                int userinput = Convert.ToInt32(Console.ReadLine());
                if (userinput == 1)
                {
                    Console.Clear();
                    Scene(player);
                }
            }
        }

        public void SmelteryScene(Player player)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the smeltery" + "\n");
                Console.WriteLine($"Inventory \n-------------------------- \n{smeltery.Inventory(player)}--------------------------");
                Console.WriteLine("Enter the number of the mineral you want to refined");
                Console.WriteLine(smeltery.MineralSmelt(player));
                Console.WriteLine("0. Return To Villages");
                int userinput = Convert.ToInt32(Console.ReadLine());
                if (userinput == 0)
                {
                    Console.Clear();
                    Scene(player);
                }
            }

        }
    }
}
