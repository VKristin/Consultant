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

    class Rule //правила
    {
        string ruleName;
        List<Fact> facts; //посылка
        Fact conclusion; //заключение
        string ruleDescription; //reason
    }
    class Domain //домен
    {
        string domainName;
        List<DomainValue> value; //сделать не string
    }
    class Var //переменная
    {
        string varName;
        Domain varDomain;
        //добавить вопрос для запрашиваемой перменной
        string question;
        VarType varType;
    }
    class Fact //факт посылки или заключение
    {
        Var var;
        int value; //подумать над типом
    }
    class KnowledgeBase //база знаний
    {
        
    }
    class WorkingMemory //рабочая память
    {

    }
    class DomainValue
    {
        string value;
    }
}
