using System.ComponentModel.Design;
using System.Dynamic;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Assignment3
{
    public class Game
    {
        public string itemNumber { get; set; }
        public int userRating { get; set; }
        public double price { get; set; }
        public string itemName { get; set; }
        public Game(string? itemNumber, string? itemName, double price, int userRating)
        {
            this.itemNumber = itemNumber;
            this.itemName = itemName;
            this.userRating = userRating;
            this.price = price;
        }
        public override string ToString()
        {
            return $"{itemNumber} | {itemName} | {price} | {userRating}";
        }
    }
    internal class Program
    {
        private static List<string> itNum = new List<string>();
        public static string breakline { get; set; } = "";
        private static string GenerateItemNum()
        { string numBer;
            do
            {
                Random Numb = new Random();
                numBer = Numb.Next(1, 10000).ToString("D4");
            } while (itNum.Contains(numBer));
                itNum.Add(numBer);
            return numBer;
        }
        private static void AddProduct()
        {
            Console.WriteLine(breakline + "\n-------------- ADD NEW ITEM--------------\n" + breakline);
            Console.WriteLine("This function to add Items\n" + "existing Item number/Auto Generate Item Number for New Items\n");
           
            //Ask for input from "user in each variable
            string itemNumber = "";
            string chkItemnum = @"^\d{4}$";
            Regex ChkNumb = new Regex(chkItemnum);
            Console.WriteLine("🔢 Do you have an Item Number Answer as a number (0 (No), 1(Yes)) :");
            string Ans = Console.ReadLine();
            if (Ans == "1")
            {
                Console.WriteLine("Please Enter Item Number 4 digits : ");
                string ItemNumber = Console.ReadLine(); 
                if (Regex.IsMatch(ItemNumber, chkItemnum))
                {
                    itemNumber = ItemNumber;
                    Console.WriteLine("Your Item Number input validated");
                }
            else{
                    Console.WriteLine("❌ Invalid Item Number input");
                    itemNumber = GenerateItemNum();
                }
            }
            if (itemNumber == "")
            {
                itemNumber = GenerateItemNum();
            }   
            Console.WriteLine("✅ New Item code is :" + itemNumber);
            Console.WriteLine("🎮 Please Enter Product Name:");
            var itemName = Console.ReadLine();
            Console.WriteLine("New Item Name is :" + itemName);

            //-------------------------------------------------------------
            int userRating; //use do while loop to validate input 0-5
            do
            {
                Console.WriteLine("📈 Please Enter Product Rating 0-5: ");
                userRating = int.Parse(Console.ReadLine());
                if (userRating < 0 || userRating > 5)
                {
                    Console.WriteLine("❌Invalid Rating Value Please enter only 0 - 5");
                }
            } while (userRating < 0 || userRating > 5);
            Console.WriteLine("Item Rating is :" + userRating);
            Console.WriteLine("Please Enter Item Price : ");
            var price = double.Parse(Console.ReadLine());
            Console.WriteLine("Item Price is :" + price + "💰");
            var newGame = new Game(itemNumber, itemName, price, userRating);
            Console.WriteLine(breakline + "\nNew Item Add 🎮 \n" + newGame);
            string Lined = newGame.ToString();
            string filepath = Path.Combine(@"/Users/ben_p/GBC/COMP1202/ConsoleApp1", "videogames.txt");
            F(filepath, Lined + Environment.NewLine);
            Console.WriteLine("✅ New Item add to system \n " + breakline);
            Main();            
        }
        public static void FindItemNumber()
        {
            Console.WriteLine(breakline + "\n-------------- SEARCH ITEMS -------------- \n" + "This page use Item Number As Indicator"
            + "\nItem Number Characteristic is 4 digits [0-9]{4}$\n" + breakline);
            Console.WriteLine("This function use Item Number (XXXX) for reference");
            Console.WriteLine("Please Enter Item Number 4 digits :");
            var NumberRef = Console.ReadLine();
            var Paths = Path.Combine(@"/Users/ben_p/GBC/COMP1202/ConsoleApp1", "videogames.txt");
            var lines = File.ReadAllLines(Paths);
            bool found = false;
            foreach (var line in lines)
            {
                if (line.StartsWith(NumberRef + " | "))
                {
                    found = true;
                    Console.WriteLine(line);
                    break;
                } 
            }
            if (!found) {
                Console.WriteLine("Not Match");
            }
        }
        public static void Listprice()
        {
            Console.WriteLine(breakline + "\n-------------- List Items Function --------------\n" +
            "This Page base on Maximum Price to find an Item\n");
            Console.WriteLine("Please Enter Items Price :");
            Double refPrice = Console.ReadLine();
            Console.WriteLine("Your Input Reference Price is : " + refPrice)
            bool Look = false;
            var Direct = Path.Combine(@"/Users/ben_p/GBC/COMP1202/ConsoleApp1", "videogames.txt");
            var Liner = File.ReadAllText(Direct)



        }

         private static void Main()
        {
            Console.WriteLine("Welcome To GameStore System");
            Console.WriteLine("------------------- MENU ------------------\n" + breakline + "\n DIRECTORIES");
            Console.WriteLine("1. ➕Add Product\n" + "2. 🔎 Search by Item No.####\n" + "3. 👀Product Lookup\n" + "4. 📊Product Analysis\n" + breakline);
            Console.WriteLine("Please Enter 1-5 to Navigate to Function Page : ");
            string inPut = Console.ReadLine();
            Console.WriteLine("Your Input Reference Item No. is : " + inPut);
            switch (inPut)
            {
                case "1":
                    Console.WriteLine("➕ Add New Product \n" + "To add new video game to the existing inventory");
                    AddProduct();
                    break;
                case "2":
                    Console.WriteLine("🔎 Search Function" + "<Item Number Reference>");
                    FindItemNumber();
                    break;
                case "3":
                    Console.WriteLine("List Product(Indicate by Maximum Price)");
                    Listprice();
                    break;
                case "4":
                    Console.WriteLine("Product Analysis (Analyst Price of Product)");
                    break;
                default:
                    Console.WriteLine("Invalid Input Please Re-Enter only 1-5 to proceed to Next step");
                    break;
            }




        }

    }
}