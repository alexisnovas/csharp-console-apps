using System;

namespace ValuesAverage
{
    class Program
    {
        static void Main(string[] args)
        {
           int numberLimit = 4;
           double value = 0;
           double sum = 0;

           for (int i = 0; i < numberLimit; i++)
           {
               Console.Write($"Enter value #{i+1}: ");
               value = double.Parse(Console.ReadLine());
               sum = sum + value;
           }

           //double average = sum/numberLimit; This could stay for make the code more understandable.
           Console.Write($"The average is {sum/numberLimit}");


        }
    }
}
