using System;

namespace DaysNumberCalculatorV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int years = 0;
            int months = 0;
            int weeks = 0;
            int days = 0;
            int daysAux = 0;

            Console.Write("Please enter number of days to evaluate: ");
            days = int.Parse(Console.ReadLine());
            daysAux = days;

            if(days >= 7){
                while (days > 365)
                {
                    years = years + 1;
                    days = days - 365;
                }
                days = daysAux;
                while (days >= 30)
                {
                    months = months + 1;
                    days = days - 30;
                }
                days = daysAux;
                while (days >= 7)
                {
                    weeks = weeks + 1;
                    days = days - 7;
                }
            }else{
                Console.WriteLine("No se ha ingresado más de 7 días.");
            }

            Console.WriteLine($"En {daysAux} días, hay años:{years}, meses:{months}, semanas: {weeks}");
        }
    }
}
