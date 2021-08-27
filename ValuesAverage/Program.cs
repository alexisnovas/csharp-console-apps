using System;
using System.Linq;

namespace ValuesAverage
{
    class Program
    {
        static void Main(string[] args)
        {
           int numberLimit = 4;
           //double value = 0;
           // double sum = 0;
           double[] arrValues = new double [4];

           for (int i = 0; i < numberLimit; i++)
           {
               Console.Write($"Enter value #{i+1}: ");
               //value = double.Parse(Console.ReadLine());
               //sum = sum + value;
               arrValues[i] = double.Parse(Console.ReadLine());
           }

           //double average = sum/numberLimit; This could stay for make the code more understandable.
           //Console.Write($"The average is {sum/numberLimit}");

           Console.Write($"The average is {arrValues.Average()}");


        }
    }
}
