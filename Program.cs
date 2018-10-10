using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (number != -1)
            {
                System.Console.WriteLine("Input a positive number or -1 to quit:");
                number = int.Parse(System.Console.ReadLine());
                if(number < 1)
                {
                    continue;
                }
                System.Console.WriteLine("{0}\t\t{1}\t\t{2}","Number","Squared","Cubed");
                System.Console.WriteLine("{0}\t\t{0}\t\t{0}","=======");
                for(int i =1; i <= number; i++)
                {
                    System.Console.WriteLine("{0}\t\t{1}\t\t{2}",i, i * i, i * i * i);
                }
            }
        }
    }
}
