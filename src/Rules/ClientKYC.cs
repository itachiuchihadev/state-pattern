using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using state_pattern.Interface;

namespace state_pattern.Rules
{
    public class ClientKYC : IRule
    {
        public IRule Check()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Checking Client KYC ...");
            Thread.Sleep(1000);
            return new ThirdPartyAccountCheck();
        }

        public void Condition()
        {
            Console.WriteLine("Checking Adhar Card Number ...");
            Thread.Sleep(1000);
            Console.WriteLine("Checking Voter Id Card ...");
            Thread.Sleep(1000);
            Console.WriteLine("Checking Address Proof ...");
        }
    }
}