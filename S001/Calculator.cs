using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S001
{
    internal class Calculator
    {
        private int a, b;

        public Calculator(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Add() { return a + b; }
        public int Sub() { return a - b; }
        public int Mul() { return a * b; }
        public int Div() { return a / b; }
    }
}
