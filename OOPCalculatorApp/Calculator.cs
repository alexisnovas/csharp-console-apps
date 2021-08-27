using System;
using System.Collections.Generic;
using System.Text;

namespace OOPCalculatorApp
{
    class Calculator
    {
        private double _result;

        public Calculator()
        {
            _result = 0;
        }

        //public double result { get => _result; set => _result = value; }
        
        public double Add(double operand1, double operand2)
        {
            _result = operand1 + operand2;
            return _result;
        }

        public double Substract(double operand1, double operand2)
        {
            _result = operand1 - operand2;
            return _result;
        }

        public double Divide(double operand1, double operand2)
        {
            _result = operand1 / operand2;
            return _result;
        }

        public double Multyply(double operand1, double operand2)
        {
            _result = operand1 * operand2;
            return _result;
        }
    }
}
