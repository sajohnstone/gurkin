using gurkin;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Gherkin.Quick;

namespace test
{
    [FeatureFile("./gurkin/AddTwoNumbers.feature")]
    public sealed class Calculator : Feature
    {
        private readonly gurkin.Calculator _calculator = new gurkin.Calculator();

        [Given(@"I chose (\d+) as first number")]
        public void I_chose_first_number(int firstNumber)
        {
            _calculator.SetFirstNumber(firstNumber);
        }

        [And(@"I chose (\d+) as second number")]
        public void I_chose_second_number(int secondNumber)
        {
            _calculator.SetSecondNumber(secondNumber);
        }

        [When(@"I press add")]
        public void I_press_add()
        {
            _calculator.AddNumbers();
        }

        [Then(@"the result should be (\d+) on the screen")]
        public void The_result_should_be_z_on_the_screen(int expectedResult)
        {
            var actualResult = _calculator.Result;

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
