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
        public void Entering_number_one_results_in_that_number_being_converted_to_a_roman_numeral()
        {
            // Arrange
            int numberOne = 1;
            var numberConverter = new NumberConverter();

            // Act
            var result = numberConverter.Parse(numberOne);

            // Assert
            Assert.AreEqual("I", result);
        }

        [Test]
        public void Entering_number_five_results_in_that_number_being_converted_to_a_roman_numeral()
        {
            // Arrange
            int numberFive = 5;
            var numberConverter = new NumberConverter();

            // Act
            var result = numberConverter.Parse(numberFive);

            // Assert
            Assert.AreEqual("V", result);
        }

        [Test]
        public void Entering_number_nine_results_in_that_number_being_converted_to_a_roman_numeral()
        {
            // Arrange
            int numberNine = 9;
            var numberConverter = new NumberConverter();

            // Act
            var result = numberConverter.Parse(numberNine);

            // Assert
            Assert.AreEqual("IV", result);
        }

        //[Test]
        //public void Entering_a_number_between_one_through_nine_results_in_that_number_being_converted_to_a_roman_numeral()
        //{
        //    // Arrange
        //    List<int> rnOneThroughNine = new List<int>() { 1, 5, 9 };
        //    var numberConverter = new NumberConverter();

        //    // Act
        //    var result = numberConverter.Parse(rnOneThroughNine);

        //    // Assert
        //    Assert.AreEqual("I", "V", "IV", result);
        //}
    }
}
