using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static bool isGreater(int i, int j)
        {
            if (i > j)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void PrintStarTriangle(int n)
        {
            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int i = 3, j = 5;
            if (i < j)
            {
                Console.WriteLine(j);
            }
            else
            {
                Console.WriteLine(i);
            }

            if (isGreater(i, j))
            {
                Console.WriteLine("i is greater than j");
            }
            else
            {
                Console.WriteLine("i is less than j");
            }

            switch (i)
            {
                case 1:
                    Console.WriteLine("Value of i is 1");
                    break;
                case 10:
                    Console.WriteLine("Value of i is 10");
                    break;
                case 3:
                    Console.WriteLine("value of i is 3");
                    break;
                case 4:
                    Console.WriteLine("Value of i is 4");
                    break;
                default:
                    Console.WriteLine("No match");
                    break;
            }

            Console.WriteLine("For loop example");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Decimal for loop example");
            for (double d = 1.01D; d < 1.10; d += 0.01D)
            {
                Console.WriteLine($"D:{d}");
            }

            for (i = 0, j = 0; i + j < 5; i++, j++)
            {
                Console.WriteLine("Value of i:{0}, j:{1}", i, j);
            }

            PrintStarTriangle(3);
        }

        
    }
}
