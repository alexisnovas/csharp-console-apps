/*
    Recorrer una cantidad de numeros N,
    si el numero es multiplo de 3 imprimir 'fizz'
    en cambio, si el numero es multiplo de 5
    imprimir 'buzz'. Para los numeros que sean
    multiplos de 3 y 5 imprimir 'FizzBuzz'.
*/
using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 0;

            Console.Write("Please, enter the limit: ");
            limit = int.Parse(Console.ReadLine());

            for (int i = 1; i <= limit; i++)
            {
                if(i % 3 == 0 && i % 5 == 0){
                    Console.WriteLine($"{i}fizzbuzz");
                }else if(i % 3 == 0){
                    Console.WriteLine($"{i}fizz");
                }else if(i % 5 == 0){
                    Console.WriteLine($"{i}buzz");
                }else{
                    Console.WriteLine(i);
                }

                
            }
        }
    }
}
