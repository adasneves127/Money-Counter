using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Counter
{
    class Program
    {
        static decimal Money = 0;
        static decimal Variance = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Money Counter!");
            Console.WriteLine("Please Select a Mode of Operation:");
            Console.WriteLine("     1: Count");
            Console.WriteLine("     2: Calculate");
            string mode = Console.ReadLine();
            if (mode == "1")
            { 
            Money = Count();
                Main(null);
            }
            if (mode == "2")
            {
                Variance = Calculate(Money);
                Console.Read();
            }
        }
        static decimal Count()
        {
        //Coin Count
        #region Pennies
        Pennies:
            Console.Write("0.01: ");
            int pennies = 0;
            try
            {
                pennies = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error: Number not valid!");
                goto Pennies;
            }
        #endregion
        #region Nickles
        Nickles:
            Console.Write("0.05: ");
            int nickles = 0;
            try
            {
                nickles = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error: Number not valid!");
                goto Nickles;
            }
        #endregion
        #region Dimes
        Dimes:
            Console.Write("0.10: ");
            int dimes = 0;
            try
            {
                dimes = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error: Number not valid!");
                goto Dimes;
            }
        #endregion
        #region Quarters
        Quarters:
            Console.Write("0.25: ");
            int quarters = 0;
            try
            {
                quarters = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error: Number not valid!");
                goto Quarters;
            }
        #endregion

        //Bill Count
        #region Ones
        Ones:
            Console.Write("1: ");
            int ones = 0;
            try
            {
                ones = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error: Number not valid!");
                goto Ones;
            }
        #endregion
        #region Fives
        Fives:
            Console.Write("5: ");
            int fives = 0;
            try
            {
                fives = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error: Number not valid!");
                goto Fives;
            }
        #endregion
        #region Tens
        Tens:
            Console.Write("10: ");
            int tens = 0;
            try
            {
                tens = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error: Number not valid!");
                goto Tens;
            }
        #endregion
        #region Twenties
        Twenties:
            Console.Write("20: ");
            int twenties = 0;
            try
            {
                twenties = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error: Number not valid!");
                goto Twenties;
            }
            #endregion

            #region Confirm
            Console.WriteLine("Please Confirm:");
            Console.WriteLine("$0.01's: " + pennies);
            Console.WriteLine("$0.05's: " + nickles);
            Console.WriteLine("$0.10's: " + dimes);
            Console.WriteLine("$0.25's: " + quarters);
            Console.WriteLine();
            Console.WriteLine("$1's: " + ones);
            Console.WriteLine("$5's: " + fives);
            Console.WriteLine("$10's: "+ tens);
            Console.WriteLine("$20's: "+ twenties);
            Console.WriteLine("Is this correct? [Y]es or [N]o?");
            string choice = Console.ReadLine().ToLower();
            decimal Total = 0;
            decimal Profit = 0;
            if (choice == "y")
            {
                decimal totalCoins = pennies + (nickles * 5) + (dimes * 10) + (quarters * 25);
                long totalBills = ones + (fives * 5) + (tens * 10) + (twenties * 20);

                Console.WriteLine("Total Coins: " + totalCoins/100);
                Console.WriteLine("Total Bills: " + totalBills);
                Console.WriteLine();
                Total = Convert.ToDecimal(totalBills + (totalCoins/100));
                Console.WriteLine("Total: " + Total);
                Profit = Total - 100.00M;
                Console.WriteLine("Drawer Profit: " + Profit);
            }
            if (choice == "n")
            {
                goto Pennies;
            }
            #endregion
            return Profit;
        }

        static decimal Calculate(decimal DrawerTotal)
        {
            decimal variance = 0;
            Console.Write("Please enter the expected total: ");
            decimal expected = Convert.ToDecimal(Console.ReadLine());
            variance = expected - DrawerTotal;
            Console.Write("Variance: ");
            if (variance <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("(" + variance + ")");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine(variance);
            }
            return variance;
        }
    }
}
