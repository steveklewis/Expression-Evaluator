﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vanderbilt.Biostatistics.Wfccm2;

namespace ExpressionEvaluator.Procedures
{
    class Subtraction : TwoOperandOperator
    {
        public Subtraction(int precedance) : base("-", precedance, 2) {}

        override public IOperand Evaluate(IOperand op1, IOperand op2)
        {
            if (IsDoubleDouble(op1, op2))
            {
                return DoubleDouble(op1, op2, (x, y) => x - y);
            }

            throw new ExpressionException("Subtraction operator used incorrectly.");
        }
    }
}