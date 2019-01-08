using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simple_Calculator;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();
        [TestMethod]
        public void ConvertValidStringInputIntoDouble()
        {
            string InputNumber = "5";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(InputNumber);
            Assert.AreEqual(5, convertedNumber);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringInputIntoDouble()
        {
            string InputNumber = "!";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(InputNumber);
            Assert.AreEqual(5, convertedNumber);

        }

    }
}
