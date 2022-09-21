using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace state_pattern.Interface
{
    public interface IRule
    {
        void Condition();
        IRule Check();
    }
}