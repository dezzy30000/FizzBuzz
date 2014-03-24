using System;

namespace FizzBuzz.Objects.Interfaces
{
    public interface IRulesEngine
    {
        Func<int, bool>[] Rules { get; }
        string GetOutput(Func<int, bool> rule);
    }
}
