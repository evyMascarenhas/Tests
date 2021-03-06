﻿using CellCrypt;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Xunit;

namespace CellCrypt.Tests
{
   
    public class FactorialTests
    {
        public class NumberAndResult
        {
            public int number { get; set; }
            public BigInteger result { get; set; }

            public NumberAndResult(int number, BigInteger result)
            {
                this.number = number;
                this.result = result;
            }
        }
        [Theory]
        [InlineData(2, "2")]
        [InlineData(3, "6")]
        [InlineData(5, "120")]
        [InlineData(7, "5040")]
        [InlineData(9, "362880")]
        [InlineData (100, "93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000")]
        public void FactorialCalculation_CalculateFactorial_ShouldMatchResult(int number, string result)
        {
            FactorialCalculation calc = new FactorialCalculation();
            //arrange 
            ArrayList array = calc.getMultiplyResults(number);
            array.Reverse();
            String resultFromList = string.Empty ;
            for (int i =0; i< array.Count; i++)
                resultFromList += array[i].ToString();
            
            //Act
            Assert.Equal(result, resultFromList);
        }

        [Fact]
        public void FactorialCalculation_CalculateSumFactorial_ShouldMatchResult()
        {
            FactorialCalculation calc = new FactorialCalculation();
            //arrange 
            List<NumberAndResult> testCases = new List<NumberAndResult>
            {
                new NumberAndResult (2,2),
                new NumberAndResult (3,6),
                new NumberAndResult (5,3),
                new NumberAndResult (7,9),
                new NumberAndResult (9,27),
                new NumberAndResult(100,648)

            };

            //Act
            Assert.All(testCases, item => Assert.Equal(item.result, calc.CalculateSumFactorial(item.number)));
        }

    }
}
