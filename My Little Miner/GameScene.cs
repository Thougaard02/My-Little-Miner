using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace My_Little_Miner
{
    class GameScene
    {
        public void MyLittleMinerScene()
        {
            Mine game = new Mine();
            Pickaxe pickaxe = new Pickaxe(PickaxeVariety.Wood);
            Player player = new Player("Rasmus", true, pickaxe);



            Menu();
            while (true)
            {

                //try
                //{
                int userinput = Convert.ToInt32(Console.ReadLine());
                if (userinput == 1)
                {
                    Console.Clear();
                    player.Backpack.AddRange(game.GoMining(player));
                   
                    Console.ReadKey();
                    Console.WriteLine("1. Keep mining");
                    Console.WriteLine("2. Return to world");
                }
                else if (userinput == 2)
                {
                    Menu();


                }

                //}
                //catch (Exception)
                //{
                //    Console.WriteLine("Wrong input");
                //    Console.ReadKey();
                //    Console.Clear();
                //    Menu();
                //}
            }
        }

        public string Menu()
        {
            Console.WriteLine("My LITTLE MINER");
            Console.WriteLine("1. Go to the cave and mine");
            Console.WriteLine("2. Open your inventory");
            Console.WriteLine("3. Smelt your stuff in the smeltery");
            Console.WriteLine("4. Go to Shop");
            return "";
        }
    }
}
