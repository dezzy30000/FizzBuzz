using FizzBuzz.Objects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.Objects
{
    public class StandardFizzBuzzRulesEngine : IRulesEngine
    {
        private IDictionary<Func<int, bool>, string> _standardFizzBuzzRules = new Dictionary<Func<int, bool>, string>
        {
            { number => number % 3 == 0 && number % 5 == 0, "FizzBuzz" },
            { number => number % 3 == 0, "Fizz" },
            { number => number % 5 == 0, "Buzz" }
        };

        public Func<int, bool>[] Rules
        {
            get 
            {
                return _standardFizzBuzzRules
                    .Keys
                    .ToArray();
            }
        }

        public string GetOutput(Func<int, bool> rule)
        {
            return _standardFizzBuzzRules[rule];
        }
    }
}
