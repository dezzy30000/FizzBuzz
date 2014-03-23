using FizzBuzz.Objects;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzStandardRulesTests
    {
        private IDictionary<Func<int, bool>, string> _standardFizzBuzzRules = new Dictionary<Func<int, bool>, string>
        {
            { number => number % 3 == 0 && number % 5 == 0, "FizzBuzz" },
            { number => number % 3 == 0, "Fizz" },
            { number => number % 5 == 0, "Buzz" }
        };

        [Test]
        public void GivenNumbersThatAreNotMultiplesOfFiveOrThreeWhenEachOneIsProcessedThenTheNumberIsOutput()
        {
            var fizzBuzzer = new FizzBuzzer(_standardFizzBuzzRules);

            foreach (var number in new[] { 1, 2, 4, 7, 8, 11, 13, 14, 16, 17, 19, 22, 23, 26, 28, 29, 31, 32, 34, 37, 38, 41, 43, 44, 46, 47, 49, 52, 53, 56, 58, 59, 61, 62, 64, 67, 68, 71, 73, 74, 76, 77, 79, 82, 83, 86, 88, 89, 91, 92, 94, 97, 98 })
            {
                Assert.AreEqual(number.ToString(), fizzBuzzer.Process(number));
            }
        }

        [Test]
        public void GivenNumbersThatAreMultiplesOfThreeWhenEachOneIsProcessedThenFizzAlertIsOutput()
        {
            var fizzBuzzer = new FizzBuzzer(_standardFizzBuzzRules);

            foreach (var number in new[] { 3, 6, 9, 12, 18, 21, 24, 27, 33, 36, 39, 42, 48, 51, 54, 57, 63, 66, 69, 72, 78, 81, 84, 87, 93, 96, 99 })
            {
                Assert.AreEqual("Fizz", fizzBuzzer.Process(number));
            }
        }

        [Test]
        public void GivenNumbersThatAreMultiplesOfFiveThenWhenEachOneIsProcessedThenBuzzAlertIsOutput()
        {
            var fizzBuzzer = new FizzBuzzer(_standardFizzBuzzRules);

            foreach (var number in new[] { 5, 10, 20, 25, 35, 40, 50, 55, 65, 70, 80, 85, 95, 100 })
            {
                Assert.AreEqual("Buzz", fizzBuzzer.Process(number));
            }
        }

        [Test]
        public void GivenNumbersThatAreMultiplesOfFiveAndThreeThenWhenEachOneIsProcessedThenFizzBuzzAlertIsOutput()
        {
            var fizzBuzzer = new FizzBuzzer(_standardFizzBuzzRules);

            foreach (var number in new[] { 15, 30, 45, 60, 75, 90 })
            {
                Assert.AreEqual("FizzBuzz", fizzBuzzer.Process(number));
            }
        }
    }
}
