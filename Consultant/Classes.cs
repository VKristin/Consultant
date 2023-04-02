using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultant
{
    [Serializable]
    public enum VarType
    {
        Requested,
        Inferred,
        InferredRequested
    }

    [Serializable]
    public class Rule //правила
    {
        public string ruleName;
        public List<Fact> facts; //посылка
        public Fact conclusion; //заключение
        public string ruleDescription; //reason

        public Rule()
        {
            facts = new List<Fact>();
            conclusion = new Fact();
        }

        public Rule(string ruleName, List<Fact> facts, Fact conclusion, string ruleDescription)
        {
            this.ruleName = ruleName;
            this.facts = facts;
            this.conclusion = conclusion;
            this.ruleDescription = ruleDescription;
        }
    }
    [Serializable]
    public class Domain //домен
    {
        public string domainName;
        public List<DomainValue> value;

        public Domain()
        {
            value = new List<DomainValue>();
        }
        public Domain (string domainName, List<DomainValue> value)
        {
            this.domainName = domainName;
            this.value = value;
        }
    }
    [Serializable]
    public class Var //переменная
    {
        public string varName;
        public Domain varDomain;
        public string question;
        public VarType varType;

        public Var() { }

        public Var(string varName, Domain varDomain, string question, VarType varType)
        {
            this.varName = varName;
            this.varDomain = varDomain;
            this.question = question;
            this.varType = varType;
        }
    }
    [Serializable]
    public class Fact //факт посылки или заключение
    {
        public Var var;
        public DomainValue value; //подумать над типом

        public Fact() { }
        public Fact(Var var, DomainValue domainValue)
        {
            this.var = var;
            this.value = domainValue;
        }
    }
    [Serializable]
    public class KnowledgeBase //база знаний
    {
        public string baseName;
        public List<Rule> rules;
        public List<Var> vars;
        public List<Domain> domains;

        public KnowledgeBase()
        {
            baseName = string.Empty;
            rules = new List<Rule>();
            domains = new List<Domain>();
            vars= new List<Var>();
        }
    }
    public class WorkingMemory //рабочая память
    {
        public List<Rule> rules;
        public List<Var> vars;
        public Var goal;

        public WorkingMemory()
        {
            rules = new List<Rule>();
            vars = new List<Var>();
            goal = new Var();
        }
    }
    [Serializable]
    public class DomainValue
    {
        public string value;
    }
    public class MLV
    {
        public MLV() { }
    }

    public class ExpertSystemShell
    {
        public KnowledgeBase knowledgeBase;
        public WorkingMemory workingMemory;
        public MLV mlv;

        public ExpertSystemShell()
        {
            knowledgeBase = new KnowledgeBase();
            workingMemory = new WorkingMemory();
            mlv = new MLV();
        }
    }
}
