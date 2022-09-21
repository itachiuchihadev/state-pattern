using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using state_pattern.Interface;

namespace state_pattern.Rules
{
    public class ThirdPartyAccountCheck : IRule
    {
        public IRule Check()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Checking Third Party Database ...");
            Thread.Sleep(1000);
            return null;
        }

        public void Condition()
        {
            Console.WriteLine("Checking Black List Account ...");
            Thread.Sleep(1000);
            Console.WriteLine("Checking Valid Account ...");
            Thread.Sleep(1000);
        }
    }
}