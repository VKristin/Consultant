using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultant
{
    enum VarType
    {
        Requested,
        Inferred,
        InferredRequested
    }

    public class Rule //правила
    {
        public string ruleName;
        List<Fact> facts; //посылка
        Fact conclusion; //заключение
        string ruleDescription; //reason
    }
    public class Domain //домен
    {
        public string domainName;
        public List<DomainValue> value;

        public Domain()
        {
            value = new List<DomainValue>();
        }
    }
    public class Var //переменная
    {
        public string varName;
        Domain varDomain;
        //добавить вопрос для запрашиваемой перменной
        string question;
        VarType varType;
    }
    public class Fact //факт посылки или заключение
    {
        Var var;
        int value; //подумать над типом
    }
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
