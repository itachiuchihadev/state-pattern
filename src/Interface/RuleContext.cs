using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace state_pattern.Interface
{
    public class RuleContext
    {
        public RuleContext(IRule _rule)
        {
            _NextRule = _rule;
        }
        public IRule _NextRule { get; set; }
        public void Run()
        {
            do
            {
                _NextRule.Condition();
                _NextRule = _NextRule.Check();
            } while(_NextRule != null);
        }
        // public abstract bool IsPassed { get; set;}
    }
}