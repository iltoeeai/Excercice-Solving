using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondHw
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature;
            double price = 1.30;
            
            bool softener = false;
            bool spinning = false;
            bool drying = false;
            double priceSoftener = 0.7;
            double priceSpinning = 1.6;
            double priceDrying = 2;

            Console.WriteLine("Please enter the washing temperature: ");
            temperature = int.Parse(Console.ReadLine());
           
            if (temperature > 30)
            {
                price = 1.3 + ((temperature - 30) * 0.02);
            }
            
            Console.WriteLine("Do you need softener? (Y/N):");
            char answer = (char)Console.Read();
            if (answer == 'Y')
                softener = true;
            Console.ReadLine(); //reads the rest of the line

            Console.WriteLine("Do you need spinning? (Y/N)");
            answer = (char)Console.Read();
            if (answer == 'Y')
                spinning = true;
            Console.ReadLine();

            Console.WriteLine("Do you need drying? (Y/N)");
            answer = (char)Console.Read();
            if (answer == 'Y')
                drying = true;
            Console.ReadLine();

            if (softener)
            {
                price += priceSoftener;
            }

            if (spinning)
            {
                price += priceSpinning;
            }

            if (drying)
            {
                price += priceDrying;
            }

            Console.WriteLine("You need to pay {0:f2} eur.", price);


        }
    }
}
