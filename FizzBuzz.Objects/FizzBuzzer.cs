using System;
using System.Collections.Generic;

namespace FizzBuzz.Objects
{
    public class FizzBuzzer
    {
        private readonly IDictionary<Func<int, bool>, string> _rules;

        public FizzBuzzer(IDictionary<Func<int, bool>, string> rules)
        {
            _rules = rules;
        }

        public string Process(int number)
        {
            foreach (var predicate in _rules.Keys)
            {
                if (predicate(number))
                {
                    return _rules[predicate];
                }
            }

            return number.ToString();
        }
    }
}
