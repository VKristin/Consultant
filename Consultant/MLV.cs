using Consultant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultant
{
    public class MLV
    {
        public MLV() { }
        public void StartConsultation(Consultation consultation)
        {
            var thread = new Thread(new ParameterizedThreadStart(Consult));
            thread.IsBackground = true;
            thread.Start(consultation);
        }
        public void Consult(object _consultation)
        {
            Consultation consultation = (Consultation) _consultation;
            if (FindGoalValue(consultation.exs.workingMemory.goal, 0, consultation))
            {
                consultation.PrintSuccess();
            }
            else
            {
                consultation.PrintUnSuccess();
            }
        }

        public bool FindGoalValue(Var goal, int startIdx, Consultation consult)
        {
            var rules = consult.knowledgeBase.rules;

            //проход по всем правилам
            for (int i = startIdx; i < rules.Count; i++)
            {
                //проверяем правило, если в заключении есть целевая переменная
                if (rules[i].conclusion.var.varName == goal.varName)
                {
                    for (int j = 0; j < rules[i].facts.Count; j++)
                    {
                        if (!FindGoalValue(rules[i].facts[j].var, i, consult))
                            break;
                    }
                    if (CheckRule(rules[i], consult.exs.workingMemory.vars))
                    {
                        consult.exs.workingMemory.AddRule(rules[i], goal);
                        return true;
                    }
                }

            }

            if (goal.varType != VarType.Inferred)
            {
                return AskVariable(goal, consult);
            }
            return false;
        }
        private bool AskVariable(Var goal, Consultation consult)
        {
            if (consult.exs.workingMemory.FindUsedVar(goal))
                return true;

            consult.PrintQuestion(goal);

            consult.pressed = false;
            while (!consult.pressed)
                Thread.Sleep(200);

            string answer = consult.answer;
            DomainValue value = new DomainValue(answer);
            consult.workingMemory.AddUsedVar(new Fact(goal, value));
            return true;
        }
        public bool CheckRule(Rule rule, List<Fact> facts)
        {
            foreach (var c in rule.facts)
            {
                if (facts.FindIndex(item => item.var.varName == c.var.varName && item.value.value == c.value.value) == -1)
                    return false;
            }
            return true;
        }
    }

}
