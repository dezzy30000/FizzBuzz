using FizzBuzz.Objects.Interfaces;

namespace FizzBuzz.Objects
{
    public class FizzBuzzer
    {
        private readonly IRulesEngine _rulesEngine;

        public FizzBuzzer(IRulesEngine rulesEngine)
        {
            _rulesEngine = rulesEngine;
        }

        public string Process(int number)
        {
            foreach (var rule in _rulesEngine.Rules)
            {
                if (rule(number))
                {
                    return _rulesEngine.GetOutput(rule);
                }
            }

            return number.ToString();
        }
    }
}
