using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static double GetNumber()
        {
            Console.WriteLine("Please type a number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            return number;
        }

        static double Addition(double value1, double value2)
        {
            // double decnumber1 = Convert.ToDouble(value1);
            //double decnumber2 = Convert.ToDouble(value2);
            double calcvalue = value1 + value2;
            return calcvalue;
        }

        static double Subtraction(double value1, double value2)
        {
            //double decnumber1 = Convert.ToDouble(value1);
            //double decnumber2 = Convert.ToDouble(value2);
            double calcvalue = value1 - value2;
            return calcvalue;
        }

        static double Multiplication(double value1, double value2)
        {
            double calcvalue = value1 * value2;
            return calcvalue;
        }

        static double Division(double value1, double value2)
        {
            double calcvalue = value1 / value2;
            return calcvalue;
        }

        static void Main(string[] args)
        {
            int mainchoise;
            do
            {
                Console.Clear();
                Console.WriteLine("What would you like to do:(please type the corresponding number)");
                Console.WriteLine("1. Addition.");
                Console.WriteLine("2. Subtraction.");
                Console.WriteLine("3. Multiplication.");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit.");
                mainchoise = Convert.ToInt32(Console.ReadLine());

                if (mainchoise == 1)
                {
                    double value1 = GetNumber();
                    double value2 = GetNumber();
                    double sum = Addition(value1, value2);
                    Console.WriteLine("The addition resulted in: " + sum);
                    Console.ReadKey();
                }
                else if (mainchoise == 2)
                {
                    double value1 = GetNumber();
                    double value2 = GetNumber();
                    double subvalue = Subtraction(value1, value2);
                    Console.WriteLine("The subtraction resulted in: " + subvalue);
                    Console.ReadKey();
                }
                else if (mainchoise == 3)
                {
                    double value1 = GetNumber();
                    double value2 = GetNumber();
                    double mulvalue = Multiplication(value1, value2);
                    Console.WriteLine("The multiplication resulted in: " + mulvalue);
                    Console.ReadKey();
                }
                else if (mainchoise == 4)
                {
                    Console.WriteLine("Please type in the numerator:");
                    double value1 = GetNumber();
                    double value2;
                    do
                    {
                        Console.WriteLine("Please type in a legal denominator:");
                        value2 = GetNumber();
                    }
                    while (value2 == 0);
                    double divvalue = Division(value1, value2);
                    Console.WriteLine("The division resulted in: " + divvalue);
                    Console.ReadKey();

                }
                else if (mainchoise >= 6)
                {
                    Console.WriteLine("This function is not yet implemented. Please choose another option.");
                    Console.ReadKey();
                }
            }
            while (mainchoise != 5);
        }
    }
}
