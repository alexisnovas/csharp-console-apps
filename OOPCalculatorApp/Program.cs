using System;

namespace OOPCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char option;
            char keepGoing = ' ';
            double result = 0;

            do
            {
                Console.WriteLine("|**********************************************************|");
                Console.WriteLine("|*                                                        *|");
                Console.WriteLine("|*           1.- Add             (x + y)                  *|");
                Console.WriteLine("|*           2.- Substract       (x - y)                  *|");
                Console.WriteLine("|*           3.- Divide          (x / y)                  *|");
                Console.WriteLine("|*           4.- Mutiply         (x * y)                  *|");
                Console.WriteLine("|*           5.- All operations                           *|");
                Console.WriteLine("|*                                                        *|");
                Console.WriteLine("|*           0.- Exit                                     *|");
                Console.WriteLine("|*                                                        *|");
                Console.WriteLine("|**************************************AlexisNovas*********|");
                Console.Write("\n");
                Console.Write("Enter an option: ");


                do
                {
                    option = Console.ReadKey(true).KeyChar; //If the intercept parameter is true , the pressed key
                                                            //is intercepted and not displayed in the console window; otherwise, the pressed key is displayed.

                } while (option < '0' || option > '5');

                Console.Write("\n");
                Calculator calculator = new Calculator();
                var operands = GetOperands();

                switch (option)
                {
                    case '0':
                        Environment.Exit(0);
                        break;
                    case '1':
                        result = calculator.Add(operands.Item1, operands.Item2);
                        Console.Write(result);
                        break;
                    case '2':
                        result = calculator.Substract(operands.Item1, operands.Item2);
                        Console.Write(result);
                        break;
                    case '3':
                        result = calculator.Divide(operands.Item1, operands.Item2);
                        Console.Write(result);
                        break;
                    case '4':
                        result = calculator.Multyply(operands.Item1, operands.Item2);
                        Console.Write(result);
                        break;
                    case '5':
                        Console.WriteLine($"Add Operation: {calculator.Add(operands.Item1, operands.Item2)}");
                        Console.WriteLine($"Substract Operation: {calculator.Substract(operands.Item1, operands.Item2)}");
                        Console.WriteLine($"Divide Operation: {calculator.Divide(operands.Item1, operands.Item2)}");
                        Console.WriteLine($"Multiply Operation: {calculator.Multyply(operands.Item1, operands.Item2)}");
                        break;
                }

                Console.WriteLine("\n-------------------------------");
                Console.Write("continue? y/n: ");
                keepGoing = Console.ReadKey(true).KeyChar;
                Console.Clear();

            } while (keepGoing != 'n');

        }

        private static Tuple<double,double> GetOperands (){
            double operand1;
            double operand2;

            Console.Write("Please, enter the first operand: ");
            operand1 = double.Parse(Console.ReadLine());

            Console.Write("Please, enter the second operand: ");
            operand2 = double.Parse(Console.ReadLine());


            var operandsTuple = new Tuple<double, double>(operand1, operand2);

            return operandsTuple;
        }
    }
}
