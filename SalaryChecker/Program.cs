using System;

/* Ingresar el sueldo de una persona, si supera los 3000 pesos mostrar un mensaje en pantalla
indicando que debe abonar impuestos. */

namespace SalaryChecker
{
    class Program
    {
        static void Main(string[] args)
        {  
            double salary = 0;
            const int salaryLimit = 3000;

            Console.Write("Please, write your salary: ");
            salary = double.Parse(Console.ReadLine());

            if(salary > salaryLimit) Console.Write("You have to pay taxes.");
            else Console.Write("You don't have to pay taxes.");
            
            Console.ReadKey();

        }
    }
}
