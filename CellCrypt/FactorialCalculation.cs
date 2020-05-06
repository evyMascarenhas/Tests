using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace CellCrypt
{
   public class FactorialCalculation
    {
        
        public void CalculateFactorial(int x, ArrayList results)
        {
            int adder = 0;
            int size = results.Count;
            //instead of using a big number, the result of the factorial will be stored in the array

            for (int i = 0; i < size; i++)
            {
                // Calculate the factorial by multiplying the current number and sum to the adder value
                int res = adder + (int)results[i] * x;

                // update the array with the result of the factorial
                //and if the result of the factorial has more digits than the current one, we create a new position in the array
                //We know that if the variable adder has any values
                
                results[i] = res % 10;
                adder = res / 10;
            } 
            //it's like doing multiplication by hand, if the number is greater than 9,
            //we keep the first part and the other part goes up to be added to the next number multiplied
            while (adder != 0)
            {
                results.Add(adder % 10);
                adder /= 10;
            }
        }

        public ArrayList getMultiplyResults(int number)
        {
            ArrayList results = new ArrayList();
            results = new ArrayList();
            results.Add(1); // adds 1 to the end  

            // One by one multiply i to current vector  
            // and update the vector.  
            for (int i = 1; i <= number; i++)
                CalculateFactorial(i, results);
            return results;
        }

        /// <summary>
        /// Calculates the sum of the digits of a factorial of a given number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int CalculateSumFactorial(int number )
        {
            ArrayList results = getMultiplyResults(number);


            // Find sum of digits in vector v[]  
            int sum = 0;
            int size = results.Count;
            for (int i = 0; i < size; i++)
                sum += (int)results[i];
            return sum;

        }
    }
}
