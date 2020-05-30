using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            while (!end)
            {
                string num1 = "";
                string num2 = "";
                string op = "";
                double result = 0;
                Console.WriteLine("please enter number 1：");
                num1 = Console.ReadLine();
                Console.WriteLine("please enter number 2：");
                num2 = Console.ReadLine();
                Console.WriteLine("please enter the op：");
                op = Console.ReadLine();

                switch (op)
                {
                    case "+":
                        result = Convert.ToDouble(num1) + Convert.ToDouble(num2);
                        break;
                    case "-":
                        result = Convert.ToDouble(num1) - Convert.ToDouble(num2);
                        break;
                    case "*":
                        result = Convert.ToDouble(num1) * Convert.ToDouble(num2);
                        break;
                    case "/":
                        result = Convert.ToDouble(num1) / Convert.ToDouble(num2);
                        break;
                }

                Console.WriteLine("the result is:");
                Console.WriteLine(Convert.ToString(result));
                Console.Write("Press 'p' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "p")
                    end = true;
                Console.WriteLine("\n");
            }
            return;
        }
    }
}