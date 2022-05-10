using NUnit.Framework;

namespace Summator.Tests
{
    public class SummatorTests
    {
        // Try to sum two +/- floating point numbers
        // For example num1 = +/-5.5; num2 = +/-4.5;
        //----------------------------------------------------
        // Also can try to sum two numbers with many digits after floating point
        // like a = 5.000000000000000000000013; b = 6.000000000000000000000015;
        // --------------------------------------------------------------
        // What will happen if you try to sum two numbers like this -> long.MaxValue + long.MaxValue;
        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {
            long actual = Summator.Sum(new int[] { 5, 7 });

            long expected = 12;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Sum_OnePossitiveNumbers()
        {
            long actual = Summator.Sum(new int[] { 5 });

            long expected = 5;

            Assert.That(actual == expected);
        }

        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            long actual = Summator.Sum(new int[] { -7, -9 });

            long expected = -16;

            Assert.That(actual == expected);
        }

        [Test]
        public void Test_Sum_BeZero()
        {
            long actual = Summator.Sum(new int[] { -7, 7 });

            long expected = 0;

            Assert.That(actual == expected);
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            long actual = Summator.Sum(new int[] {});

            long expected = 0;

            Assert.That(actual == expected);
        }
        
        
        [Test]
        public void Test_Sum_BigValues()
        {
            long actual = Summator.Sum(new int[] {2000000000, 2000000000, 2000000000 });

            long expected = 6000000000;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_ValuesTwoNumbers()
        {
            long actual = Summator.Average(new int[] { 5, 7 });

            int expected = 6;

            Assert.AreEqual(actual,expected);
        }

        [Test]
        public void Test_Average_ValuesDoubleNegativeNum()
        {
            double actual = Summator.Average(new int[] { 1, -9 });

            double expected = -4;

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Test_Average_ValuesMultipleNumbers()
        {
            int actual = Summator.Average(new int[] { 10, 20, 30, 40 });

            int expected = 25;

            Assert.That(actual == expected);
        }

        [Test]
        public void Test_Average_ValuesNegativeNumbers()
        {
            int actual = Summator.Average(new int[] { -10, -10 });

            int expected = -10;

            Assert.That(actual == expected);
        }

        [Test]
        public void Test_Average_ZeroResult()
        {
            int actual = Summator.Average(new int[] { -10, 10 });

            int expected = 0;

            Assert.That(actual == expected);
        }
    }
}
