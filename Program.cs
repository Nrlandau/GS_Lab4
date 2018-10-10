/* Lab_4 by Nicholas Landau
    This program takes a number and finds the squares and cubes of all of the numbers below and equal to it.
 */

using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 0;
            while (number != -1)
            {
                System.Console.WriteLine("Input a positive number or -1 to quit:");
                number = int.Parse(System.Console.ReadLine());
                if(number < 1)
                {
                    continue;
                }
                System.Console.WriteLine("{0,-13} {1,-13} {2,-13}","Number","Squared","Cubed");
                System.Console.WriteLine("{0,-13} {0,-13} {0,-13}","=======");
                for(long i =1; i <= number; i++)
                {
                    System.Console.WriteLine("{0,-13} {1,-13} {2,-13}",i, i * i, i * i * i);
                }
            }
        }
    }
}
