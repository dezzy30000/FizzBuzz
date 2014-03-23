using FizzBuzz.Objects;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace FizzBuzz.Tests
{
    public class FizzBuzzExtendedRulesTests
    {
        private IDictionary<Func<int, bool>, string> _extendedFizzBuzzRules = new Dictionary<Func<int, bool>, string>
        {
            { number => number % 3 == 0 && number % 5 == 0, "FizzBuzz" },
            { number => number % 3 == 0 || number.ToString().Contains("3"), "Fizz" },
            { number => number % 5 == 0 || number.ToString().Contains("5"), "Buzz" }
        };

        [Test]
        public void GivenNumbersThatAreNotMultiplesOfFiveOrThreeAndDoesNotContainFiveOrThreeWhenEachOneIsProcessedThenTheNumberIsOutput()
        {
            var fizzBuzzer = new FizzBuzzer(_extendedFizzBuzzRules);

            foreach (var number in new[] { 1, 2, 4, 7, 8, 11, 14, 16, 17, 19, 22, 26, 28, 29, 41, 44, 46, 47, 49, 61, 62, 64, 67, 68, 71, 74, 76, 77, 79, 82, 86, 88, 89, 91, 92, 94, 97, 98 })
            {
                Assert.AreEqual(number.ToString(), fizzBuzzer.Process(number));
            }
        }

        [Test]
        public void GivenNumbersThatAreMultiplesOfThreeOrContainsThreeWhenEachOneIsProcessedThenFizzAlertIsOutput()
        {
            var fizzBuzzer = new FizzBuzzer(_extendedFizzBuzzRules);

            foreach (var number in new[] { 3, 6, 9, 12, 13, 18, 21, 23, 24, 27, 31, 32, 33, 34, 35, 36, 37, 38, 39, 42, 43, 48, 51, 53, 54, 57, 63, 66, 69, 72, 73, 78, 81, 83, 84, 87, 93, 96, 99 })
            {
                Assert.AreEqual("Fizz", fizzBuzzer.Process(number));
            }
        }

        [Test]
        public void GivenNumbersThatAreMultiplesOfFiveOrContainsFiveThenWhenEachOneIsProcessedThenBuzzAlertIsOutput()
        {
            var fizzBuzzer = new FizzBuzzer(_extendedFizzBuzzRules);

            foreach (var number in new[] { 5, 10, 20, 25, 40, 50, 52, 55, 56, 58, 59, 65, 70, 80, 85, 95, 100 })
            {
                Assert.AreEqual("Buzz", fizzBuzzer.Process(number));
            }
        }
        
        [Test]
        public void GivenNumbersThatAreMultiplesOfFiveAndThreeThenWhenEachOneIsProcessedWithExtendedRulesThenFizzBuzzAlertIsOutput()
        {
            var fizzBuzzer = new FizzBuzzer(_extendedFizzBuzzRules);

            foreach (var number in new[] { 15, 30, 45, 60, 75, 90 })
            {
                Assert.AreEqual("FizzBuzz", fizzBuzzer.Process(number));
            }
        }
    }
}
