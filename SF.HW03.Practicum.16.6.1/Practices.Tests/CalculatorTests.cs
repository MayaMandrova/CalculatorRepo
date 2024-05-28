using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;

namespace Practices.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        public Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new Calculator();
        }

        [Test]
        public void AdditionalMustReturnNotNullValue()
        {
            // Использование Assert.True
            Assert.True(calculator.Additional(15, 5) == 20);
            Assert.True(calculator.Additional(-42, -50) == -92);

            // Использование Assert.That
            Assert.That(calculator.Additional(70, 30), Is.EqualTo(100));
            Assert.That(calculator.Additional(-55, 80), Is.EqualTo(25));
        }

        [Test]
        public void SubtractionMustReturnNotNullValue()
        {
            // Использование Assert.True
            Assert.True(calculator.Subtraction(100, 5) == 95);
            Assert.True(calculator.Subtraction(-90, -70) == -20);

            // Использование Assert.That
            Assert.That(calculator.Subtraction(50, 40), Is.EqualTo(10));
            Assert.That(calculator.Subtraction(-77, 33), Is.EqualTo(-110));
        }

        [Test]
        public void MultiplicationMustReturnNotNullValue()
        {
            // Использование Assert.True
            Assert.True(calculator.Miltiplication(7, 7) == 49);
            Assert.True(calculator.Miltiplication(-6, -9) == 54);

            // Использование Assert.That
            Assert.That(calculator.Miltiplication(9, 3), Is.EqualTo(27));
            Assert.That(calculator.Miltiplication(-9, 7), Is.EqualTo(-63));
        }

        [Test]
        public void DivisionMustReturnNotNullValue()
        {
            // Использование Assert.True
            Assert.True(calculator.Division(80, 4) == 20);
            Assert.True(calculator.Division(-112, 2) == -56);

            // Использование Assert.That
            Assert.That(calculator.Division(25, 5), Is.EqualTo(5));
            Assert.That(calculator.Division(8, -4), Is.EqualTo(-2));
        }

        [Test]
        public void DivisionMustThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Division(50, 0));
        }
    }
}