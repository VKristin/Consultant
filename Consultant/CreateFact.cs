using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultant
{
    public partial class CreateFact : Form
    {
        KnowledgeBase knowledgeBase;
        Fact fact;
        Var var;
        Rule rule;
        byte mode;
        int factIndex;
        public CreateFact(int factIndex, string factName, byte mode, Rule rule, KnowledgeBase knowledgeBase)
        {
            InitializeComponent();
            this.rule = rule;
            this.factIndex = factIndex;
            this.knowledgeBase = knowledgeBase;
            this.mode = mode; //переменная отвечает за то, для чего нужен факт
            //т.е. является ли он посылкой или заключением
            //= 0 - посылка
            //= 1 - заключение
            FillVarsList();
            if (factIndex == -1)
            {
                if (knowledgeBase.vars.Count != 0)
                {
                    fact = new Fact();
                    if (cbVar.Items.Count != 0)
                    {
                        cbVar.SelectedIndex = 0;
                        cbDomainValue.SelectedIndex = 0;
                    }
                    var = knowledgeBase.vars[FindVarIndex()];
                    FillDomainValueList();
                    cbDomainValue.SelectedIndex = 0;
                }
            }
            else
            {
                if (mode == 0)
                {
                    fact = rule.facts[factIndex];
                    
                }
                else
                {
                    fact = rule.conclusion;

                }
                for (int i = 0; i < cbVar.Items.Count; i++)
                {
                    if (cbVar.Items[i].ToString() == fact.var.varName)
                    {
                        cbVar.SelectedIndex = i;
                        break;
                    }
                }
                var = knowledgeBase.vars[FindVarIndex()]; 
                FillDomainValueList();
                for (int i = 0; i < cbDomainValue.Items.Count; i++)
                {
                    if (cbDomainValue.Items[i].ToString() == fact.value.value)
                    {
                        cbDomainValue.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private int FindVarIndex()
        {
            int idx = -1;
            for (int i = 0; i < knowledgeBase.vars.Count(); i++)
            {
                if (knowledgeBase.vars[i].varName == cbVar.SelectedItem.ToString())
                    return i;
            }
            return idx;
        }

        private void FillVarsList()
        {
            //Посылка - все переменные, заключение - только выводимые
            cbVar.Items.Clear();
            if (mode == 0)
                foreach (Var variable in knowledgeBase.vars)
                {
                    cbVar.Items.Add(variable.varName);
                }
            else
                foreach (Var variable in knowledgeBase.vars)
                {
                    if (variable.varType == VarType.Inferred || variable.varType == VarType.InferredRequested)
                        cbVar.Items.Add(variable.varName);
                }
        }
        private void FillDomainValueList()
        {
            cbDomainValue.Items.Clear();
            foreach (DomainValue dv in var.varDomain.value)
                cbDomainValue.Items.Add(dv.value);

        }

        private void btnAddVar_Click(object sender, EventArgs e)
        {
            CreateVar createVar = new CreateVar(-1, "", knowledgeBase);
            createVar.ShowDialog();
            FillVarsList();
            if (cbVar.Items.Count != 0 && cbVar.SelectedIndex == -1)
            {
                cbVar.SelectedIndex = 0;
                cbDomainValue.SelectedIndex = 0;
            }
        }

        private void cbVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var = knowledgeBase.vars[cbVar.SelectedIndex];
            for (int i = 0; i < knowledgeBase.vars.Count(); i++)
            {
                if (knowledgeBase.vars[i].varName == cbVar.Items[cbVar.SelectedIndex].ToString())
                {
                    var = knowledgeBase.vars[i];
                }
            }
            FillDomainValueList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (mode == 0 && factIndex == -1)
            {
                fact = new Fact(var, var.varDomain.value[cbDomainValue.SelectedIndex]);
                rule.facts.Add(fact);
            }
            if (mode == 0 && factIndex > -1)
            {
                fact = new Fact(var, var.varDomain.value[cbDomainValue.SelectedIndex]);
                rule.facts[factIndex] = fact;
            }
            if (mode == 1)
            {
                fact = new Fact(var, var.varDomain.value[cbDomainValue.SelectedIndex]);
                rule.conclusion = fact;
            }
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
