using Microsoft.VisualStudio.TestTools.UnitTesting;
using RN;

namespace RomanNumberTest1_lab3_
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PlussCorrect()
        {
            int x = 10;
            int y = 20;
            int expected = 30;
            RomanNumber actual;
            RomanNumber number1 = new RomanNumber(x);
            RomanNumber number2 = new RomanNumber(y);

            actual = number1 + number2;

            Assert.AreEqual(expected, actual.value);
        }

        [TestMethod]
        public void ExeptionPlussMoreThousand()
        {
            int x = 600;
            int y = 600;
            int expected = 0;
            RomanNumber actual;
            RomanNumber number1 = new RomanNumber(x);
            RomanNumber number2 = new RomanNumber(y);

            actual = number1 + number2;
            Assert.AreNotEqual(expected, actual.value, 1000);
        }

        [TestMethod]
        public void ExeptionPlussLessOne()
        {
            int x = -600;
            int y = 500;
            int expected = 0;
            RomanNumber actual;
            RomanNumber number1 = new RomanNumber(x);
            RomanNumber number2 = new RomanNumber(y);

            actual = number1 + number2;
            Assert.AreNotEqual(expected, actual.value, 1000);
        }

        [TestMethod]
        public void MinusCorrect()
        {
            int x = 60;
            int y = 20;
            int expected = 40;
            RomanNumber actual;
            RomanNumber number1 = new RomanNumber(x);
            RomanNumber number2 = new RomanNumber(y);

            actual = number1 - number2;

            Assert.AreEqual(expected, actual.value);
        }

        [TestMethod]
        public void ExeptionMinusMoreThousand()
        {
            int x = 1100;
            int y = 20;
            int expected = 1080;
            RomanNumber actual;
            RomanNumber number1 = new RomanNumber(x);
            RomanNumber number2 = new RomanNumber(y);

            actual = number1 - number2;

            Assert.AreEqual(expected, actual.value);
        }

        [TestMethod]
        public void ExeptionMinusLessOne()
        {
            int x = 50;
            int y = 90;
            int expected = -40;
            RomanNumber actual;
            RomanNumber number1 = new RomanNumber(x);
            RomanNumber number2 = new RomanNumber(y);

            actual = number1 - number2;

            Assert.AreEqual(expected, actual.value);
        }

        [TestMethod]
        public void ExeptionTableMoreThousand()
        {
            int x = 100;
            int y = 20;
            int expected = 2000;
            RomanNumber actual;
            RomanNumber number1 = new RomanNumber(x);
            RomanNumber number2 = new RomanNumber(y);

            actual = number1 * number2;

            Assert.AreEqual(expected, actual.value);
        }

        [TestMethod]
        public void ExeptionTableLessOne()
        {
            int x = -100;
            int y = 20;
            int expected = -2000;
            RomanNumber actual;
            RomanNumber number1 = new RomanNumber(x);
            RomanNumber number2 = new RomanNumber(y);

            actual = number1 * number2;

            Assert.AreEqual(expected, actual.value);
        }

        [TestMethod]
        public void TableCorrect()
        {
            int x = 5;
            int y = 20;
            int expected = 100;
            RomanNumber actual;
            RomanNumber number1 = new RomanNumber(x);
            RomanNumber number2 = new RomanNumber(y);

            actual = number1 * number2;

            Assert.AreEqual(expected, actual.value);
        }

        [TestMethod]
        public void DivCorrect()
        {
            int x = 60;
            int y = 20;
            int expected = 3;
            RomanNumber actual;
            RomanNumber number1 = new RomanNumber(x);
            RomanNumber number2 = new RomanNumber(y);

            actual = number1 / number2;

            Assert.AreEqual(expected, actual.value);
        }

        [TestMethod]
        public void ExeptionDivMoreThousand()
        {
            int x = 5000;
            int y = 2;
            int expected = 2500;
            RomanNumber actual;
            RomanNumber number1 = new RomanNumber(x);
            RomanNumber number2 = new RomanNumber(y);

            actual = number1 / number2;

            Assert.AreEqual(expected, actual.value);
        }

        [TestMethod]
        public void ExeptionDivLessOne()
        {
            int x = -100;
            int y = 2;
            int expected = -50;
            RomanNumber actual;
            RomanNumber number1 = new RomanNumber(x);
            RomanNumber number2 = new RomanNumber(y);

            actual = number1 / number2;

            Assert.AreEqual(expected, actual.value);
        }
    }
}