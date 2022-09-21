using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using state_pattern.Interface;

namespace state_pattern.Rules
{
    public class Validate : IRule
    {
        public IRule Check()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Checking the Validation ...");
            Thread.Sleep(1000);
            return new ClientKYC();
        }

        public void Condition()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Validating Input ...");
            Thread.Sleep(1000);
        }
    }
}