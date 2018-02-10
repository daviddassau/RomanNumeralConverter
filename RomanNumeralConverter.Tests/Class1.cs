using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using RomanNumeralConverter.App;

namespace RomanNumeralConverter.Tests
{
    [TestFixture]
    public class NumberConverterTests
    {
        [Test]
        public void Entering_a_number_results_in_that_number_being_converted_to_a_roman_numeral()
        {
            // Arrange
            int numberOne = 1;
            var numberConverter = new NumberConverter();

            // Act
            var result = numberConverter.Parse(numberOne);

            // Assert
            Assert.AreEqual("I", result);
        }
    }
}
