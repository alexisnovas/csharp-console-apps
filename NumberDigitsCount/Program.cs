/*Se ingresa por teclado un número positivo de uno o dos dígitos (1..99) mostrar un mensaje indicando si el
número tiene uno o dos dígitos.*/

using System;

namespace NumberDigitsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (true)
            {
                Console.Write("Please, enter the number to check: ");
                
                if (!(int.TryParse(Console.ReadLine(), out number))){
                    Console.Write("Please enter just numbers.\n");
                    continue;
                }else if (number < 1){
                    Console.Write("The number must be greater than 0.\n");
                    continue;
                };

                string setCorrectLetter() => number >= 10 ? "s" : "";

                Console.Write($"\n The number has {number.ToString().Length} digit{setCorrectLetter()}.");

                Console.ReadKey();
                break;
            }
        }
    }
}
