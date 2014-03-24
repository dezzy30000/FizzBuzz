using FizzBuzz.Objects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.Objects
{
    public class ExtendedFizzBuzzRulesEngine : IRulesEngine
    {
        private IDictionary<Func<int, bool>, string> _rulesEngine = new Dictionary<Func<int, bool>, string>
        {
            { number => number % 3 == 0 && number % 5 == 0, "FizzBuzz" },
            { number => number % 3 == 0 || number.ToString().Contains("3"), "Fizz" },
            { number => number % 5 == 0 || number.ToString().Contains("5"), "Buzz" }
        };

        public Func<int, bool>[] Rules
        {
            get
            {
                return _rulesEngine
                    .Keys
                    .ToArray();
            }
        }

        public string GetOutput(Func<int, bool> rule)
        {
            return _rulesEngine[rule];
        }
    }
}
