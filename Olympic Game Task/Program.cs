using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympics
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int beginning = 1896;
            int end = 2021;

            Console.WriteLine("Enter the first date: ");
            a = int.Parse(Console.ReadLine());

            if (a >= beginning & a <= end - 1)
            {
                Console.WriteLine("Enter the second date: ");
                b = int.Parse(Console.ReadLine());
                if (b >= beginning + 1 & b <= end)
                {
                    for(int i = a; i < b; i++)
                    {
                        for(int j = beginning; j < end; j += 4)
                        {
                            if (i == j)
                            {
                                if (j == 1916 || j == 1940 || j == 1944 || i == 2020)
                                    continue;       
                                
                               Console.WriteLine(j);
                            }                               
                        }
                    }
                }
                else
                    Console.WriteLine("Wrong date entered!");
            }
            else
                Console.WriteLine("First Olympic games were held in 1896!");           
        }
    }
}
