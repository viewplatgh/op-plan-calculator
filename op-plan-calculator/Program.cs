using System;

namespace op_plan_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please ennter purchase price(Default 500.00):");
            double purchasePrice = 500;
            if (!double.TryParse(Console.ReadLine(), out purchasePrice))
                purchasePrice = 500;
            Console.Write("Please ennter purchase date(Default today):");
            DateTime purchaseDate = new DateTime();
            if(!DateTime.TryParse(Console.ReadLine(), out purchaseDate))
                purchaseDate = DateTime.Today;
            Console.WriteLine(String.Format("Purchase price: {0:C}, Purchase date: {1}", purchasePrice, purchaseDate.ToShortDateString()));

            if (purchasePrice >= 100 && purchasePrice < 1000)
            {
                Console.WriteLine("Plan option 1: ");
                Console.WriteLine(String.Format("Deposit: {0:C}", purchasePrice * 0.2));
                double instalment = purchasePrice * 0.8 / 5.0;
                for (int i = 1; i < 6; ++i)
                {
                    Console.WriteLine(String.Format("Instalment {0:C} amount {1} due on {2}", i, instalment, purchaseDate.AddDays(15 * i).ToShortDateString()));
                }
                Console.WriteLine("Plan option 2: ");
                Console.WriteLine(String.Format("Deposit: {0:C}", purchasePrice * 0.3));
                instalment = purchasePrice * 0.7 / 4.0;
                for (int i = 1; i < 5; ++i)
                {
                    Console.WriteLine(String.Format("Instalment {0:C} amount {1} due on {2}", i, instalment, purchaseDate.AddDays(15 * i).ToShortDateString()));
                }
            }
            else if (purchasePrice >= 1000 && purchasePrice < 10000)
            {
                Console.WriteLine(String.Format("Deposit: {0:C}", purchasePrice * 0.25));
                double instalment = purchasePrice * 0.75 / 4.0;
                for (int i = 1; i < 5; ++ i)
                {
                    Console.WriteLine(String.Format("Instalment {0:C} amount {1} due on {2}", i, instalment, purchaseDate.AddDays(30 * i).ToShortDateString()));
                }
            }
            else
            {
                Console.WriteLine("Plans not offered");
            }
        }
    }
}
