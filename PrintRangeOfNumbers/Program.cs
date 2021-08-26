/*Realizar un programa que imprima en pantalla los números del 1 a N*/

using System;

namespace PrintRangeOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int limit = 0;

            Console.Write("Please, enter the desired number limit: ");
            limit = int.Parse(Console.ReadLine());

            while (x <= limit)
            {
                Console.WriteLine(x++); // This set the variable first and make the increment after.
                // Console.WriteLine(++x); // This make the increment first and then set the variable.
                // Console.Write(x+=1); // Also usefull for increment.\
                
                // Other Solutions:
                // Console.WriteLine(x);
                // x = x + 1             
            }

            // Same solutions with for
            // for (int i = 0; i < limit; i++)
            // {
            //     Console.WriteLine(x++);
            // }

            // for (int i = 1; i < limit; i++)
            // {
            //     Console.WriteLine(i);
            // }

            Console.ReadKey();
        }
    }
}
