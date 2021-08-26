using System;

namespace PrimeNumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int divider = 2;
            bool prime = true;

            Console.WriteLine("Please, insert number to check");
            number = int.Parse(Console.ReadLine());

            if (number == 1){
                Console.WriteLine($"Number is prime? {prime}");        
                return;    
            }

            while (number%divider != 0)
            {
              divider++;
              //Console.Write(divider);                
            }

            if(number != divider) prime = !prime;

            Console.WriteLine($"Number is prime? {prime}");            

        }   
    }
}
