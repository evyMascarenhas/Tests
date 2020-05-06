using System;

namespace CellCrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            FactorialCalculation factorialCalculation = new FactorialCalculation();
            Console.WriteLine(factorialCalculation.CalculateSumFactorial(100).ToString());
        }
    }
}
