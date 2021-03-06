// ReSharper disable InconsistentNaming
using System;
using NUnit.Framework;
using Vanderbilt.Biostatistics.Wfccm2;

namespace ExpressionEvaluatorTests
{
    [TestFixture]
    public class LesserThanOperatorTests
    {
        Expression func;

        [SetUp]
        public void init()
        { this.func = new Expression(""); }

        [TearDown]
        public void clear()
        { func.Clear(); }
        
        [Test]
        public void LesserThanOperator_PositiveWholeWithPositiveWhole_IsCorrect()
        {
            func.Function = "2 < 2";
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveWholeWithPositiveFraction_IsCorrect()
        {
            func.Function = "2 < 0.5";
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveWholeWithNegativeWhole_IsCorrect()
        {
            func.Function = "2 < -2";
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveWholeWithNegativeFraction_IsCorrect()
        {
            func.Function = "2 < -0.5";
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveFractionWithPositiveWhole_IsCorrect()
        {
            func.Function = "0.5 < 2";
            Assert.AreEqual(true, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveFractionWithPositiveFraction_IsCorrect()
        {
            func.Function = "0.5 < 0.5";
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveFractionWithNegativeWhole_IsCorrect()
        {
            func.Function = "0.5 < -2";
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveFractionWithNegativeFraction_IsCorrect()
        {
            func.Function = "0.5 < -0.5";
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeWholeWithPositiveWhole_IsCorrect()
        {
            func.Function = "-2 < 2";
            Assert.AreEqual(true, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeWholeWithPositiveFraction_IsCorrect()
        {
            func.Function = "-2 < 0.5";
            Assert.AreEqual(true, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeWholeWithNegativeWhole_IsCorrect()
        {
            func.Function = "-2 < -2";
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeWholeWithNegativeFraction_IsCorrect()
        {
            func.Function = "-2 < -0.5";
            Assert.AreEqual(true, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeFractionWithPositiveWhole_IsCorrect()
        {
            func.Function = "-0.5 < 2";
            Assert.AreEqual(true, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeFractionWithPositiveFraction_IsCorrect()
        {
            func.Function = "-0.5 < 0.5";
            Assert.AreEqual(true, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeFractionWithNegativeWhole_IsCorrect()
        {
            func.Function = "-0.5 < -2";
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeFractionWithNegativeFraction_IsCorrect()
        {
            func.Function = "-0.5 < -0.5";
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveWholeWithPositiveWholeWithLeftVariable_IsCorrect()
        {
            func.Function = "a < 2";
			func.AddSetVariable("a", 2d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveWholeWithPositiveFractionWithLeftVariable_IsCorrect()
        {
            func.Function = "a < 0.5";
			func.AddSetVariable("a", 2d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveWholeWithNegativeWholeWithLeftVariable_IsCorrect()
        {
            func.Function = "a < -2";
			func.AddSetVariable("a", 2d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveWholeWithNegativeFractionWithLeftVariable_IsCorrect()
        {
            func.Function = "a < -0.5";
			func.AddSetVariable("a", 2d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveFractionWithPositiveWholeWithLeftVariable_IsCorrect()
        {
            func.Function = "a < 2";
			func.AddSetVariable("a", 0.5d);
            Assert.AreEqual(true, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveFractionWithPositiveFractionWithLeftVariable_IsCorrect()
        {
            func.Function = "a < 0.5";
			func.AddSetVariable("a", 0.5d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveFractionWithNegativeWholeWithLeftVariable_IsCorrect()
        {
            func.Function = "a < -2";
			func.AddSetVariable("a", 0.5d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveFractionWithNegativeFractionWithLeftVariable_IsCorrect()
        {
            func.Function = "a < -0.5";
			func.AddSetVariable("a", 0.5d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeWholeWithPositiveWholeWithLeftVariable_IsCorrect()
        {
            func.Function = "a < 2";
			func.AddSetVariable("a", -2d);
            Assert.AreEqual(true, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeWholeWithPositiveFractionWithLeftVariable_IsCorrect()
        {
            func.Function = "a < 0.5";
			func.AddSetVariable("a", -2d);
            Assert.AreEqual(true, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeWholeWithNegativeWholeWithLeftVariable_IsCorrect()
        {
            func.Function = "a < -2";
			func.AddSetVariable("a", -2d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeWholeWithNegativeFractionWithLeftVariable_IsCorrect()
        {
            func.Function = "a < -0.5";
			func.AddSetVariable("a", -2d);
            Assert.AreEqual(true, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeFractionWithPositiveWholeWithLeftVariable_IsCorrect()
        {
            func.Function = "a < 2";
			func.AddSetVariable("a", -0.5d);
            Assert.AreEqual(true, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeFractionWithPositiveFractionWithLeftVariable_IsCorrect()
        {
            func.Function = "a < 0.5";
			func.AddSetVariable("a", -0.5d);
            Assert.AreEqual(true, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeFractionWithNegativeWholeWithLeftVariable_IsCorrect()
        {
            func.Function = "a < -2";
			func.AddSetVariable("a", -0.5d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeFractionWithNegativeFractionWithLeftVariable_IsCorrect()
        {
            func.Function = "a < -0.5";
			func.AddSetVariable("a", -0.5d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveWholeWithPositiveWholeWithRightVariable_IsCorrect()
        {
            func.Function = "2 < a";
			func.AddSetVariable("a", 2d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveWholeWithPositiveFractionWithRightVariable_IsCorrect()
        {
            func.Function = "2 < a";
			func.AddSetVariable("a", 0.5d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveWholeWithNegativeWholeWithRightVariable_IsCorrect()
        {
            func.Function = "2 < a";
			func.AddSetVariable("a", -2d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveWholeWithNegativeFractionWithRightVariable_IsCorrect()
        {
            func.Function = "2 < a";
			func.AddSetVariable("a", -0.5d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveFractionWithPositiveWholeWithRightVariable_IsCorrect()
        {
            func.Function = "0.5 < a";
			func.AddSetVariable("a", 2d);
            Assert.AreEqual(true, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveFractionWithPositiveFractionWithRightVariable_IsCorrect()
        {
            func.Function = "0.5 < a";
			func.AddSetVariable("a", 0.5d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveFractionWithNegativeWholeWithRightVariable_IsCorrect()
        {
            func.Function = "0.5 < a";
			func.AddSetVariable("a", -2d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveFractionWithNegativeFractionWithRightVariable_IsCorrect()
        {
            func.Function = "0.5 < a";
			func.AddSetVariable("a", -0.5d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeWholeWithPositiveWholeWithRightVariable_IsCorrect()
        {
            func.Function = "-2 < a";
			func.AddSetVariable("a", 2d);
            Assert.AreEqual(true, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeWholeWithPositiveFractionWithRightVariable_IsCorrect()
        {
            func.Function = "-2 < a";
			func.AddSetVariable("a", 0.5d);
            Assert.AreEqual(true, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeWholeWithNegativeWholeWithRightVariable_IsCorrect()
        {
            func.Function = "-2 < a";
			func.AddSetVariable("a", -2d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeWholeWithNegativeFractionWithRightVariable_IsCorrect()
        {
            func.Function = "-2 < a";
			func.AddSetVariable("a", -0.5d);
            Assert.AreEqual(true, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeFractionWithPositiveWholeWithRightVariable_IsCorrect()
        {
            func.Function = "-0.5 < a";
			func.AddSetVariable("a", 2d);
            Assert.AreEqual(true, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeFractionWithPositiveFractionWithRightVariable_IsCorrect()
        {
            func.Function = "-0.5 < a";
			func.AddSetVariable("a", 0.5d);
            Assert.AreEqual(true, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeFractionWithNegativeWholeWithRightVariable_IsCorrect()
        {
            func.Function = "-0.5 < a";
			func.AddSetVariable("a", -2d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeFractionWithNegativeFractionWithRightVariable_IsCorrect()
        {
            func.Function = "-0.5 < a";
			func.AddSetVariable("a", -0.5d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveWholeWithPositiveWholeWithVariable_IsCorrect()
        {
            func.Function = "a < b";
			func.AddSetVariable("a", 2d);
			func.AddSetVariable("b", 2d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveWholeWithPositiveFractionWithVariable_IsCorrect()
        {
            func.Function = "a < b";
			func.AddSetVariable("a", 2d);
			func.AddSetVariable("b", 0.5d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveWholeWithNegativeWholeWithVariable_IsCorrect()
        {
            func.Function = "a < b";
			func.AddSetVariable("a", 2d);
			func.AddSetVariable("b", -2d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveWholeWithNegativeFractionWithVariable_IsCorrect()
        {
            func.Function = "a < b";
			func.AddSetVariable("a", 2d);
			func.AddSetVariable("b", -0.5d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveFractionWithPositiveWholeWithVariable_IsCorrect()
        {
            func.Function = "a < b";
			func.AddSetVariable("a", 0.5d);
			func.AddSetVariable("b", 2d);
            Assert.AreEqual(true, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveFractionWithPositiveFractionWithVariable_IsCorrect()
        {
            func.Function = "a < b";
			func.AddSetVariable("a", 0.5d);
			func.AddSetVariable("b", 0.5d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveFractionWithNegativeWholeWithVariable_IsCorrect()
        {
            func.Function = "a < b";
			func.AddSetVariable("a", 0.5d);
			func.AddSetVariable("b", -2d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_PositiveFractionWithNegativeFractionWithVariable_IsCorrect()
        {
            func.Function = "a < b";
			func.AddSetVariable("a", 0.5d);
			func.AddSetVariable("b", -0.5d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeWholeWithPositiveWholeWithVariable_IsCorrect()
        {
            func.Function = "a < b";
			func.AddSetVariable("a", -2d);
			func.AddSetVariable("b", 2d);
            Assert.AreEqual(true, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeWholeWithPositiveFractionWithVariable_IsCorrect()
        {
            func.Function = "a < b";
			func.AddSetVariable("a", -2d);
			func.AddSetVariable("b", 0.5d);
            Assert.AreEqual(true, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeWholeWithNegativeWholeWithVariable_IsCorrect()
        {
            func.Function = "a < b";
			func.AddSetVariable("a", -2d);
			func.AddSetVariable("b", -2d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeWholeWithNegativeFractionWithVariable_IsCorrect()
        {
            func.Function = "a < b";
			func.AddSetVariable("a", -2d);
			func.AddSetVariable("b", -0.5d);
            Assert.AreEqual(true, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeFractionWithPositiveWholeWithVariable_IsCorrect()
        {
            func.Function = "a < b";
			func.AddSetVariable("a", -0.5d);
			func.AddSetVariable("b", 2d);
            Assert.AreEqual(true, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeFractionWithPositiveFractionWithVariable_IsCorrect()
        {
            func.Function = "a < b";
			func.AddSetVariable("a", -0.5d);
			func.AddSetVariable("b", 0.5d);
            Assert.AreEqual(true, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeFractionWithNegativeWholeWithVariable_IsCorrect()
        {
            func.Function = "a < b";
			func.AddSetVariable("a", -0.5d);
			func.AddSetVariable("b", -2d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        public void LesserThanOperator_NegativeFractionWithNegativeFractionWithVariable_IsCorrect()
        {
            func.Function = "a < b";
			func.AddSetVariable("a", -0.5d);
			func.AddSetVariable("b", -0.5d);
            Assert.AreEqual(false, func.EvaluateBoolean());
        }

        [Test]
        [ExpectedException(typeof(ExpressionException), ExpectedMessage = "Operator error", MatchType = MessageMatch.Contains)]
        public void LesserThanOperator_MalformedExpressionPositiveWholeLeftOfOperator_ThrowsException()
        {
            func.Function = "2 <";
        }

        [Test]
        [ExpectedException(typeof(ExpressionException), ExpectedMessage = "Operator error", MatchType = MessageMatch.Contains)]
        public void LesserThanOperator_MalformedExpressionPositiveFractionLeftOfOperator_ThrowsException()
        {
            func.Function = "0.5 <";
        }

        [Test]
        [ExpectedException(typeof(ExpressionException), ExpectedMessage = "Operator error", MatchType = MessageMatch.Contains)]
        public void LesserThanOperator_MalformedExpressionNegativeWholeLeftOfOperator_ThrowsException()
        {
            func.Function = "-2 <";
        }

        [Test]
        [ExpectedException(typeof(ExpressionException), ExpectedMessage = "Operator error", MatchType = MessageMatch.Contains)]
        public void LesserThanOperator_MalformedExpressionNegativeFractionLeftOfOperator_ThrowsException()
        {
            func.Function = "-0.5 <";
        }

        [Test]
        [ExpectedException(typeof(ExpressionException), ExpectedMessage = "Operator error", MatchType = MessageMatch.Contains)]
        public void LesserThanOperator_MalformedExpressionPositiveWholeRightOfOperator_ThrowsException()
        {
            func.Function = "< 2";
        }

        [Test]
        [ExpectedException(typeof(ExpressionException), ExpectedMessage = "Operator error", MatchType = MessageMatch.Contains)]
        public void LesserThanOperator_MalformedExpressionPositiveFractionRightOfOperator_ThrowsException()
        {
            func.Function = "< 0.5";
        }

        [Test]
        [ExpectedException(typeof(ExpressionException), ExpectedMessage = "Operator error", MatchType = MessageMatch.Contains)]
        public void LesserThanOperator_MalformedExpressionNegativeWholeRightOfOperator_ThrowsException()
        {
            func.Function = "< -2";
        }

        [Test]
        [ExpectedException(typeof(ExpressionException), ExpectedMessage = "Operator error", MatchType = MessageMatch.Contains)]
        public void LesserThanOperator_MalformedExpressionNegativeFractionRightOfOperator_ThrowsException()
        {
            func.Function = "< -0.5";
        }

    }
}
