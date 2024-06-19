using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17._1
{
    internal class Calculator
    {
        dynamic firstNumber;
        dynamic secondNumber;
        dynamic operation;

        public Calculator(dynamic firstNumber, dynamic operation, dynamic secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.operation = operation;
        }

        public dynamic Add()
        {
            return firstNumber + secondNumber;
        }

        public dynamic Sub()
        {
            return firstNumber - secondNumber;
        }

        public dynamic Multi()
        {
            return firstNumber * secondNumber;
        }

        public dynamic Div()
        {
            if (firstNumber != 0)
            {
                return firstNumber / secondNumber;
            }
            else
            {
                return "You can't division by zero!";
            }
        }

        public dynamic Operation()
        {
            switch (operation)
            {
                case "+":
                    {
                        return Add();
                    }

                case "-":
                    {
                        return Sub();
                    }

                case "*":
                    {
                        return Multi();
                    }

                case "/":
                    {
                        return Div(); 
                    }

                default:
                    {
                        return "Operation not found...";
                    }
            }
        }

        public void Show()
        {
            Console.WriteLine($"Result: {firstNumber} {operation} {secondNumber} = {Operation()}");
        }

    }
}
