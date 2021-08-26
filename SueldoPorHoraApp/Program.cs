/*Veamos un primer programa para el calculo del sueldo de un operario conociendo la cantidad de horas
trabajadas y el costo por hora . Primera realizamos el diagrama de flujo: */

using System;

namespace SueldoPorHoraApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int workHours = 0;
            double hourCost = 0;
            double salary = 0;

            Console.Write("Insert work hours: ");
            workHours = int.Parse(Console.ReadLine());
            
            Console.Write("Insert cost per hour: ");
            hourCost = float.Parse(Console.ReadLine());

            salary = workHours * hourCost;

            Console.WriteLine($"Salary to pay: ${salary}");

            Console.ReadKey();
        }
    }
}
