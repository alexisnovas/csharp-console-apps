/* Realice un programa que reciba 2 numeros y los organice ascendentemente.*/

using System;

namespace SortTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = 0;
            int numberB = 0;
            int temp = 0;

            Console.Write("Insert first number: ");
            numberA = int.Parse(Console.ReadLine());
            
            Console.Write("Insert second number: ");
            numberB = int.Parse(Console.ReadLine());

            if (numberA > numberB){ //If A is greater than B we do the interchange.
                temp = numberA;
                numberA = numberB;
                numberB = temp;
            }

            Console.Write($"\nSorted numbers: {numberA}, {numberB}");

            Console.ReadKey();
        }
    }
}
