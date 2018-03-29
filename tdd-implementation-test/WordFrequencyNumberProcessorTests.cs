using System.Collections.Generic;

namespace tdd_implementation_test
{
    using tdd_implementation;

    using Xunit;

    public class WordFrequencyNumberProcessorTests
    {
        [Fact]
        public void Should_retuen_empty_when_input_empty_string()
        {
            // Given
            var inputStr = string.Empty;
            var expectedResult = string.Empty;
            var frequencyNumberProcessor = new WordFrequencyNumberProcessor();

            // When
            var result = frequencyNumberProcessor.caculate(inputStr);

            // Then
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Should_retuen_one1_when_input_one()
        {
            // Given
            var inputStr = "one";
            var expectedResult = "one 1";
            var frequencyNumberProcessor = new WordFrequencyNumberProcessor();

            // When
            var result = frequencyNumberProcessor.caculate(inputStr);

            // Then
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Should_retuen_one1two1_when_input_one_two() //开始重构，抽取模式
        {
            // Given
            var inputStr = "one two";
            var expectedResult = "one 1\r\ntwo 1";
            var frequencyNumberProcessor = new WordFrequencyNumberProcessor();

            // When
            var result = frequencyNumberProcessor.caculate(inputStr);

            // Then
            Assert.Equal(expectedResult, result);
        }


        [Fact]
        public void Should_retuen_one2_when_input_one_one()
        {
            // Given
            var inputStr = "one one two";
            var expectedResult = "one 2\r\ntwo 1";
            var frequencyNumberProcessor = new WordFrequencyNumberProcessor();

            // When
            var result = frequencyNumberProcessor.caculate(inputStr);

            // Then
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Should_retuen_two2one1_when_input_abb()
        {
            // Given
            var inputStr = "one two two";
            var expectedResult = "two 2\r\none 1";
            var frequencyNumberProcessor = new WordFrequencyNumberProcessor();

            // When
            var result = frequencyNumberProcessor.caculate(inputStr);

            // Then
            Assert.Equal(expectedResult, result);
        }


    }
}
