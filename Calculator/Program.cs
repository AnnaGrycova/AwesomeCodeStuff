using System;
using System.Linq;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the first number:");
            string inputNum1 = Console.ReadLine();
            bool inputNum1IsNumber = Double.TryParse(inputNum1, out double number1);
            if (!inputNum1IsNumber)
            {
                Console.WriteLine("Input " + inputNum1 + " is not a number.");
                return;
            }
            Console.WriteLine("Insert an operator:");
            string inputOp = (Console.ReadLine());
            string[] operators = { "+", "-", "/", "*", "^" };

            if (!operators.Contains(inputOp))
            {
                Console.WriteLine("Input " + inputOp + " is not a valid operator.");
                return;
            }
            Console.WriteLine("Insert the second number:");
            string inputNum2 = (Console.ReadLine());
            bool number2IsNumber = Double.TryParse(inputNum2, out double number2);
            if (!number2IsNumber)
            {
                Console.WriteLine("Input " + inputNum2 + " is not a number.");
                return;
            }
            double result = 0;
            switch (inputOp)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                case "^":
                    if (number2 < 0)
                    {
                        Console.WriteLine("Inserted number is not positive or zero.");
                        return;
                    }
                    else
                    {
                        result = 1;
                        int number2Positive = (int)number2;
                        for (int i = 0; i < number2Positive; i++)
                        {
                            result = result * number1;
                        }
                    }
                    break;

            }
            Console.WriteLine($"{number1} {inputOp} {number2} = {result}");



            Console.ReadKey();
        }
    }
}
