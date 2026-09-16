using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUni2
{
    public class ComicStock
    {
        public int totalInStockJoker { get; set; }
        public int totalInStockBatman { get; set; }
        public int totalInStockCat { get; set; }
        public int totalInStockPenguin { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Processor login = new Processor();
            login.Process();
            Console.ReadKey();
        }
    }
    class Processor
    {
        public void Process()
        {
            int totalInStockJoker = 398;
            int jokerComicValue = 13;

            int totalInStockBatman = 1203;
            int batmanComicValue = 22;

            int totalInStockCat = 452;
            int catComicValue = 11;

            int totalInStockRiddler = 100;
            int riddlerComicValue = 15;

            int totalInStockPenguin = 201;
            int penguinComicValue = 19;

            int totalStockAll = totalInStockJoker + totalInStockBatman + totalInStockCat + totalInStockRiddler + totalInStockPenguin;
            string stockStatus = "Normal";

            // Login interface
            while (true)
            {
                Console.Write("Please provide username to access the ComicX system (test user: admin): ");
                string username = Console.ReadLine();

                Console.Write("Please provide password (test user: adminpass): ");
                string password = Console.ReadLine();

                if (username != "admin" || password != "adminpass")
                {
                    Console.Clear();
                    Console.WriteLine(
                        "You are not authorized to access this service\n" +
                        "Press enter to try logging in again."
                    );
                    Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            // Options interface
            while (true)
            {
                Console.Clear();

                Console.WriteLine(
                    "****** Here are your options ******\n" +
                    "Please select the action.\n" +
                    "1. Show stock count for each theme of books.\n" +
                    "2. Show total value of each theme type for all comic books in stock.\n" +
                    "3. Register one comic book sold for a given theme.\n" +
                    "4. Get stock status // veryLow, Low, Normal, Over"
                );

                int option = int.Parse(Console.ReadLine());

                // Stock print
                if (option == 1)
                {
                    Console.Clear();

                    Console.WriteLine(
                        $"Joker comic book stock: {totalInStockJoker}\n" +
                        $"Batman comic book stock: {totalInStockBatman}\n" +
                        $"Cat comic book stock: {totalInStockCat}\n" +
                        $"Riddler comic book stock: {totalInStockRiddler}\n" +
                        $"Penguin comic book stock: {totalInStockPenguin}"
                    );

                    Console.WriteLine("\nPress Enter to return to the menu...");
                    Console.ReadLine();
                }
                // Stock value print
                else if (option == 2)
                {
                    Console.Clear();

                    Console.WriteLine(
                        $"Total value of Joker comics: ${totalInStockJoker * jokerComicValue}\n" +
                        $"Total value of Batman comics: ${totalInStockBatman * batmanComicValue}\n" +
                        $"Total value of Cat comics: ${totalInStockCat * catComicValue}\n" +
                        $"Total value of Riddler comics: ${totalInStockRiddler * riddlerComicValue}\n" +
                        $"Total value of Penguin comics: ${totalInStockPenguin * penguinComicValue}"
                    );

                    Console.WriteLine($"\nPress enter to return to the menu...");
                    Console.ReadLine();

                }
                // Sold message
                else if (option == 3)
                {
                    Console.Clear();

                    Console.WriteLine("Register one comic book sold, themes are below.\n" +
                        $"1. Joker (stock: {totalInStockJoker})\n" +
                        $"2. Batman (stock: {totalInStockBatman})\n" +
                        $"3. Cat (stock: {totalInStockCat})\n" +
                        $"4. Riddler (stock: {totalInStockRiddler})\n" +
                        $"5. Penguin (stock: {totalInStockPenguin})"
                        );
                    int registerOption = int.Parse(Console.ReadLine());
                    if (registerOption == 1)
                    {
                        Console.Clear();
                        Console.WriteLine($"A Joker comic has been sold!\n");
                        Console.WriteLine("\nPress Enter to return to the menu...");
                        Console.ReadLine();

                    }
                    else if (registerOption == 2)
                    {
                        Console.Clear();
                        Console.WriteLine($"A Batman comic has been sold!\n");
                        Console.WriteLine("\nPress Enter to return to the menu...");
                        Console.ReadLine();

                    }
                    else if (registerOption == 3)
                    {
                        Console.Clear();
                        Console.WriteLine($"A Cat comic has been sold!\n");
                        Console.WriteLine("\nPress Enter to return to the menu...");
                        Console.ReadLine();

                    }
                    else if (registerOption == 4)
                    {
                        Console.Clear();
                        Console.WriteLine($"A Riddler comic has been sold!\n");
                        Console.WriteLine("\nPress Enter to return to the menu...");
                        Console.ReadLine();

                    }
                    else if (registerOption == 5)
                    {
                        Console.Clear();
                        Console.WriteLine($"A Penguin comic has been sold!\n");
                        Console.WriteLine("\nPress Enter to return to the menu...");
                        Console.ReadLine();

                    }




                }
                // Stock status
                else if (option == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Total stock of every comic book is...\n" +
                        $"{totalStockAll}");
                    if(totalStockAll <= 1000)
                    {
                        stockStatus = "Very Low";
                    }
                    else if(totalStockAll <= 1000 && totalStockAll >= 1500)
                    {
                        stockStatus = "Low";
                    }
                    else if(totalStockAll >= 1500)
                    {
                        stockStatus = "Normal";
                    }
                    else if(totalStockAll >= 5000)
                    {
                        stockStatus = "Over";
                    }
                    Console.WriteLine("Stock status is...\n" +
                        $"{stockStatus}");
                    Console.WriteLine("\nPress Enter to return to the menu...");
                    Console.ReadLine();

                }
            }

        }
    }
}