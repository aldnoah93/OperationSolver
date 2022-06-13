﻿using OperationsSolver.Logic.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsSolver.Test.Logic.Operations
{
    public class MaxTest
    {
        [Theory]
        [InlineData(new double[] { 1, 2, 3, 4, 5.5 }, 5.5)]
        [InlineData(new double[] { 1, 2, 3, 4, 5 }, 5)]
        [InlineData(new double[] { 1, 2, 3, 4 }, 4)]
        public void Calculate_Max_Successfully(IEnumerable<double> input, double expectedResult)
        {
            IOperation<double> operation = new Max();

            var result = operation.Calculate(input);

            Assert.Equal<double>(expectedResult, result);
        }

        [Theory]
        [InlineData(new double[] { 1, 2, 3, 4, 5.5 }, 6)]
        [InlineData(new double[] { 1, 2, 3, 4, 5 }, 4)]
        [InlineData(new double[] { 1, 2, 3, 4 }, 3)]
        public void Calculate_Max_Not_Successfully(IEnumerable<double> input, double expectedResult)
        {
            IOperation<double> operation = new Max();

            var result = operation.Calculate(input);

            Assert.NotEqual<double>(expectedResult, result);
        }
    }
}