using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create an application which manages an inventory of products. 
 * Create a product class which has a price, id, and quantity on hand.
 * Then create an inventory class which keeps track of various products and can sum up the inventory value.*/

namespace ProductInventoryProject
{
    class Program
    {
        private static void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now} - {message}");
        }
        private static void ClearScreen()
        {
            Console.Clear();
        }
        private static ConsoleKeyInfo PromptForEnterKey()
        {
            return Console.ReadKey();
        }

        static void Main(string[] args)
        {
            var Session = true;
            var InventoryInProgress = false;
            Inventory ProductInit = new Inventory();
            Console.WriteLine("Hello! Welcome to your Inventory Management. Please select 'Enter' to begin.");
            var initInput = Program.PromptForEnterKey();
            if (initInput.Key == ConsoleKey.Enter)
            {
                while (Session)
                {
                    Console.WriteLine("--MENU--");
                    Console.WriteLine("Select {1} to continue");
                    Console.WriteLine("Select {2} to add product");
                    Console.WriteLine("Select {3} to remove product");
                    Console.WriteLine("Select {4} to count the number of products");
                    var Select = Program.PromptForEnterKey();
                    
                    if (Select.Key == ConsoleKey.D1 || Select.Key == ConsoleKey.NumPad1)
                    {
                        InventoryInProgress = true;
                    }
                    
                    else if (Select.Key == ConsoleKey.D2 || Select.Key == ConsoleKey.NumPad2)
                    {
                        var RenderNextProduct = true;
                        while (RenderNextProduct)
                        {
                            Console.WriteLine("\nEnter the products name:");
                            var NewProductName = Console.ReadLine();
                            Product NewProduct = new Product(NewProductName);
                            ProductInit.Add(NewProduct);

                            Console.WriteLine("Would you like to add another? Enter {y} or {n}");
                            var response = Console.ReadLine();
                            
                            if (response.ToLower() == "y" || response.ToLower() == "yes")
                            {
                                continue;
                            }
                            else
                            {
                                RenderNextProduct = false;
                            }
                        }
                    }

                    else if (Select.Key == ConsoleKey.D3 || Select.Key == ConsoleKey.NumPad3)
                    {
                        Console.WriteLine("\nEnter the products name to remove: ");
                        var RemoveProduct = Console.ReadLine();
                        Product PurgeProduct = new Product(RemoveProduct);
                        ProductInit.Remove(PurgeProduct);
                    }
                    else if (Select.Key == ConsoleKey.D4 || Select.Key == ConsoleKey.NumPad4)
                    {
                        Console.WriteLine("\nInit number of customers: " + ProductInit.NumberOfProducts);
                        Console.WriteLine("\nCurrent number of products: " + ProductInit.ProductCount());
                    }

                    Console.WriteLine("\n");
                    while (InventoryInProgress)
                    {
                            var contResponse = Program.PromptForEnterKey();
                            if (initInput.Key == ConsoleKey.Enter)
                            {
                                Program.ClearScreen();
                                InventoryInProgress = false;
                            }
                            else
                            {
                                Console.WriteLine("Exiting Application");
                                Environment.Exit(0);
                            }
                        }
                    }
                }
            }
        }
    }

