using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsumeWS
{
    class Program
    {
        static readonly MyWebService.WebService1 calculator = new MyWebService.WebService1();

        static void Main(string[] args)
        {
            List<double> listOfNumbers = new List<double>();

            for (; ;)
            {
                Console.Write("type:");
                string entry = Console.ReadLine();

                if (IsNumeric(entry,out double r))
                {
                    listOfNumbers.Add(r);
                }
                else
                {
                 
                    switch (entry)
                    {
                        case "+":
                            Console.WriteLine("Sum: {0}",calculator.Add(listOfNumbers.ToArray()));
                            break;

                        case "-":
                            Console.WriteLine("Difference: {0}", calculator.Subtract(listOfNumbers.ToArray()));
                            break;

                        case "*":
                            Console.WriteLine("Product: {0}", calculator.Multiply(listOfNumbers.ToArray()));
                            break;

                        case "/":
                            Console.WriteLine("Quotient: {0}", calculator.Divide(listOfNumbers.ToArray()));
                            break;

                        case "help":
                            PrintInstructions();
                            break;

                        case "exit":
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid entry");
                            break;
                    }

                    listOfNumbers.Clear();
                }

           }
         

        }

        static bool IsNumeric(string s, out double result)
        {
            bool flag = double.TryParse(s, out double r);
            result = r;
            return flag;
        }

        static void PrintInstructions()
        {
            Console.WriteLine("\nKeep entering numbers. When you want to perform a calculation enter the operator (+,-,/,*)");
            Console.WriteLine("Type 'exit' to close the console\n");
        }
    }
}
