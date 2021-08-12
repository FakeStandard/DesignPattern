using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_method_pattern.calculate
{
    class Operation
    {
        private double _numberA;
        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }
        private double _numberB;
        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }

        public virtual double GetResult()
        {
            double result = 0d;
            return result;
        }
    }
}
