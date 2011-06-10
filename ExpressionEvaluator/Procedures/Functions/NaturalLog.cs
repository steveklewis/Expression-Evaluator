﻿using System;
using Vanderbilt.Biostatistics.Wfccm2;

namespace ExpressionEvaluator.Procedures
{
    class NaturalLog : Function
    {
        public NaturalLog(int precedance) : base("ln", precedance, 1) { }

        override public IOperand Evaluate(IOperand op1)
        {
            if (op1.Type == typeof(double))
            {
                var dOp1 = op1 as GenericOperand<double>;
                return new GenericOperand<double>(Math.Log(dOp1.Value));
            }

            throw new ExpressionException("NaturalLog Function used incorrectly.");
        }
    }
}