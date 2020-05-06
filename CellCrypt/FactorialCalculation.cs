using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace CellCrypt
{
   public class FactorialCalculation
    {
        /// <summary>
        /// Function to return the factorial of a given number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public BigInteger CalculateFactorial(int number)
        {
           
                if (number == 1)
                    return 1;
                else
                    return number * CalculateFactorial(number - 1);
           
        }

        /// <summary>
        /// Calculates the sum of the digits of a factorial of a given number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int CalculateSumFactorial(int number )
        {
            //calculate the factorial
            BigInteger factorial = CalculateFactorial(number);
            BigInteger sum = 0;
            //here the division by 10 is used to "split" the digits
            //for example 120 would become 12 on the first round, then 1 on the second round, then 0 on the last round
            //meanwhile the variable sum keeps receiving the remainder of the division 
            //becoming 0 (zero) on the first round, 2 on the second round and 3 on the last round
            while (factorial !=0)
            {
                sum += factorial % 10;
                factorial /= 10;

            }
            return (int) sum;
 
        }
    }
}
