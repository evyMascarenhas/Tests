using System;

namespace CellCrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            FactorialCalculation factorialCalculation = new FactorialCalculation();
            string input = string.Empty;
            int number = 3000;
           
            while (number <= 0 || number > 2000)
            {
                Console.WriteLine("Please enter the number to be tested (between 1 and 2000): ");
                input = Console.ReadLine();
                Int32.TryParse(input, out number);
            }

            Console.WriteLine("The sum of the digits of the factorial of "+ input + " is: " + factorialCalculation.CalculateSumFactorial(number).ToString());
        }
    }
}
