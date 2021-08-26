/*Escribir un programa que lea 10 números enteros y luego muestre cuántos valores ingresados fueron
múltiplos de 3 y cuántos de 5. Debemos tener en cuenta que hay números que son múltiplos de 3 y de 5 a
la vez. */

using System;

namespace MultiplesOfThreeAndFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 10;
            int number = 0;
            int multiplesOfThree = 0;
            int multiplesOfFive = 0;


            for (int i = 0; i < limit; i++)
            {
                Console.Write($"Please enter digit #{i+1}:");
                number = int.Parse(Console.ReadLine());

                if (number%3 == 0){
                    multiplesOfThree = multiplesOfThree + 1;
                }

                if (number%5 == 0){
                    multiplesOfFive = multiplesOfFive + 1;
                }
            }

            Console.Write($"\nMultiples of Three: {multiplesOfThree}\tMultiples of Five: {multiplesOfFive}");
        }
    }
}
