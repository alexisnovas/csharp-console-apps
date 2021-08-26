using System;
using System.Collections.Generic;


namespace GetWeekDayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> weekDays = new Dictionary<int,string>();
            string dayName = "";
            int dayNumber = 0;

            weekDays.Add(1, "Domingo");
            weekDays.Add(2, "Lunes");
            weekDays.Add(3, "Martes");
            weekDays.Add(4, "Miércoles");
            weekDays.Add(5, "Jueves");
            weekDays.Add(6, "Sábado");
            
            try
            {
                Console.Write("Please, enter the number of the day to evaluate: ");
                dayNumber = int.Parse(Console.ReadLine());

                weekDays.TryGetValue(dayNumber, out dayName);

                Console.Write($"\nThe day entered is: {dayName}");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
