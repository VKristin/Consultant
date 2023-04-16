using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultant
{
    public class WorkingMemory //рабочая память
    {
        public Dictionary<string, Rule> rules;
        public List<Fact> vars; //used vars and their values
        public Var goal;

        public WorkingMemory()
        {
            rules = new Dictionary<string, Rule>();
            vars = new List<Fact>();
            goal = new Var();
        }
        public void AddRule(Rule rule, Var goal)
        {
            foreach (var c in rule.facts)
                AddUsedVar(c);

            if (!rules.ContainsKey(goal.varName))
            {
                rules.Add(goal.varName, rule);
                AddUsedVar(rule.conclusion);
            }
        }
        public bool FindUsedVar(Var goal)
        {
            return vars.Find(item => item.var.varName == goal.varName) != null;
        }
        public void AddUsedVar(Fact fact)
        {
            if (vars.Find(item => item.var.varName == fact.var.varName && item.value.value == fact.value.value) == null)
                vars.Add(fact);
        }
        public string ReturnGoalResult()
        {
            if (rules.ContainsKey(goal.varName))
                return rules[goal.varName].conclusion.value.value;
            return (vars.Find(x => x.var.varName == goal.varName).value.value);
        }
    }
}
