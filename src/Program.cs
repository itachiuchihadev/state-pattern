// See https://aka.ms/new-console-template for more information
using state_pattern.Interface;
using state_pattern.Rules;

RunRule();

void RunRule()
{
    var ruleContext = new RuleContext(new Validate());
    ruleContext.Run();
}