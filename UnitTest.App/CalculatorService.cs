﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.App
{
    public class CalculatorService : ICalculatorService
    {

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
