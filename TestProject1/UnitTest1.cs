using Microsoft.VisualStudio.TestTools.UnitTesting;
using RN;

namespace RomanNumberTest1_lab3_
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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
        public void TestMethod2()
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
        public void TestMethod3()
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
        public void TestMethod4()
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
    }
}