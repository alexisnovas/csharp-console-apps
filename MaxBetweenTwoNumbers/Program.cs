using System;

/*Realizar un programa que calcule el maximo entre dos numeros y muestre el resultado por pantalla.*/

namespace MaxBetweenTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = 0;
            int numberB = 0;

            Console.Write("Insert first number: ");
            numberA = int.Parse(Console.ReadLine());

            Console.Write("Insert second number: ");
            numberB = int.Parse(Console.ReadLine());

            if(numberA > numberB) Console.WriteLine($"{numberA} is greater than {numberB}");
            else Console.WriteLine($"{numberB} is greater than {numberA}");

            Console.ReadKey();
            
        }
    }
}
