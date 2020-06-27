using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            do
            {
                Console.WriteLine("Enter your Product name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the price: ");
                string input = Console.ReadLine();
                double price = Convert.ToDouble(input);
                double price_after_taxes;

                price_after_taxes = price * 0.15 + price;
                Console.WriteLine("price = " + price + " Total price = " + price_after_taxes);
                Console.ReadLine();
                Console.WriteLine("Do you want to continue? Y/N ");
                response = Console.ReadLine();

            } while (response == "y");

            
                         
         }
        
     
    }
}
