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
        Shop shop = new Shop();
        public void Scene(Player player)
        {
            try
            {
                Console.WriteLine($"Player Name {player.Name} | Pickaxe type {player.MyPickaxe.PickaxeType}  | Money {player.Money}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("1. Go to the cave and mine" + "\n" + "2. Open your inventory" + "\n" + "3. Smelt your stuff in the smeltery" + "\n" + "4. Go to Shop");

                Console.SetCursorPosition(0, 6);
                int userinput = Convert.ToInt32(Console.ReadLine());
                if (userinput == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Going to the cave...");
                    Thread.Sleep(1000);
                    Console.Clear();

                    MiningScene(player);
                }
                else if (userinput == 2)
                {
                    Inventory(player);
                }
                else if (userinput == 3)
                {
                    SmelteryScene(player);
                    Console.ReadKey();
                }
                else if (userinput == 4)
                {
                    Console.Clear();
                    ShopScene(player);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Wrong input");
                Thread.Sleep(500);
                Console.Clear();
                Scene(player);
                throw;
            }

        }
        public void MiningScene(Player player)
        {
            try
            {
                while (true)
                {

                    Console.WriteLine("1. Keep Mining" + "\n" + "2. Return To Villages" + "\n" + "You got a new mineral " + mine.GoMining(player));
                    int userinput = Convert.ToInt32(Console.ReadLine());
                    if (userinput == 1)
                    {
                        Console.Clear();
                        MiningScene(player);

                    }
                    if (userinput == 2)
                    {
                        Console.WriteLine("Returning to villages...");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Scene(player);
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Wrong input");
                Thread.Sleep(500);
                Console.Clear();

                Scene(player);
                throw;
            }

        }
        public void Inventory(Player player)
        {
            //Inventory
            try
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Inventory:" + "\n" + "--------------------------");
                    Console.WriteLine(player.ShowInventory() + "--------------------------");
                    Console.WriteLine("1. Close backpack");
                    int userinput = Convert.ToInt32(Console.ReadLine());
                    if (userinput == 1)
                    {
                        Console.Clear();
                        Scene(player);
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception)
            {

                Console.Clear();
                Console.WriteLine("Wrong input");
                Thread.Sleep(500);
                Console.Clear();
                Inventory(player);
                throw;
            }
        }
        public void SmelteryScene(Player player)
        {
            try
            {

                while (true)
                {
                    Console.Clear();
                    CheckInventory(player);
                    Console.WriteLine("Welcome to the smeltery" + "\n");
                    Console.WriteLine($"Inventory \n-------------------------- \n{smeltery.Inventory(player)}--------------------------");
                    Console.WriteLine("Enter the number of the mineral you want to refined");
                    Console.WriteLine(smeltery.MineralSmelt(player));

                    Console.WriteLine("--------------------------" + "\n" + "0. Keep smelt minerals");
                    Console.WriteLine("1. Return To Villages");
                    int userinput = Convert.ToInt32(Console.ReadLine());
                    userinput--;
                    if (userinput == -1)
                    {
                        Console.Clear();
                        SmelteryScene(player);
                    }
                    else if (userinput == 0)
                    {
                        Console.Clear();
                        Scene(player);
                    }
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Wrong input");
                Thread.Sleep(500);
                Console.Clear();
                SmelteryScene(player);
                throw;
            }
        }
        public void ShopScene(Player player)
        {
            try
            {
                while (true)
                {

                    Console.WriteLine("Welcome to the shop");
                    Console.WriteLine("1. Buy stuff" + "\n" + "2. Sell mineral" + "\n" + "3. Return To Villages");

                    int userinput = Convert.ToInt32(Console.ReadLine());
                    if (userinput == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("1. Buy Pickaxe" + "\n" + "2. Buy Food" + "\n" + "3. Return To Shop");
                        int BuyStuffInput = Convert.ToInt32(Console.ReadLine());
                        //PICKAXE SHOP
                        if (BuyStuffInput == 1)
                        {
                            Console.Clear();
                            Console.WriteLine(shop.ShopPickaxe());
                            Console.WriteLine(shop.BuyPickaxe(player));
                            Console.Clear();
                        }

                        //FOOD SHOP FIX
                        else if (BuyStuffInput == 2)
                        {
                            Console.Clear();
                            Console.WriteLine($"Apple = 2 | Bread = 5 | Cookie = 10 | Steak = 20 | Fish = 30");
                            Console.WriteLine(shop.ShopFood());
                            Console.WriteLine(shop.BuyFood(player));


                            Console.WriteLine("1. Continue to shopping");
                            Console.WriteLine("2. Return to Shop");
                            int input = Convert.ToInt32(Console.ReadLine());
                            if (input == 1)
                            {
                                Console.Clear();
                                Console.WriteLine($"Apple = 2 | Bread = 5 | Cookie = 10 | Steak = 20 | Fish = 30");
                                Console.WriteLine(shop.ShopFood());
                                Console.WriteLine(shop.BuyFood(player));
                            }
                            else if (input == 2)
                            {
                                Console.Clear();
                                Scene(player);
                                Console.Clear();
                            }
                        }
                    }
                    //SELL MINERALS
                    else if (userinput == 2)
                    {
                        

                        Console.Clear();
                        CheckInventory(player);
                        Console.WriteLine($"Inventory \n-------------------------- \n{shop.Inventory(player)}--------------------------");
                        Console.WriteLine("Enter the number of the mineral you want to sell");
                        Console.WriteLine(shop.MineralSell(player));

                        Console.WriteLine("\n" + "Press any key to continue shopping");
                        Console.WriteLine("1. Return to Villages");
                        string userintput = Console.ReadLine();
                        Console.Clear();
                        if (userintput == "1")
                        {
                            Console.Clear();
                            Scene(player);
                        }
                    }
                    //RETURN TO VILLAGES
                    else if (userinput == 3)
                    {
                        Console.Clear();
                        Scene(player);
                        Console.Clear();
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Wrong input");
                Thread.Sleep(500);
                Console.Clear();
                ShopScene(player);
                throw;
            }
        }




        public void CheckInventory(Player player)
        {
            bool inventoryIsEmpty = !player.Backpack.Any();
            if (inventoryIsEmpty)
            {
                Console.WriteLine($"Inventory is empty \n-------------------------- \n{shop.Inventory(player)}--------------------------");
                Console.WriteLine("1. Return to villages");
                int userinput = Convert.ToInt32(Console.ReadLine());
                if (userinput == 1)
                {
                    Console.Clear();
                    Scene(player);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong input");
                    Thread.Sleep(500);
                    Console.Clear();
                    CheckInventory(player);
                }
            }
        }

        public void ShopFoodScene(Player player)
        {
            Console.Clear();
            Console.WriteLine($"Apple = 2 | Bread = 5 | Cookie = 10 | Steak = 20 | Fish = 30");
            Console.WriteLine(shop.ShopFood());
            Console.WriteLine(shop.BuyFood(player));


            Console.WriteLine("1. Continue to shopping");
            Console.WriteLine("2. Return to Shop");
        }
    }
}