using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Consultant
{
    public partial class ChangeRule : Form
    {
        List<Rule> rules;
        Rule rule;
        KnowledgeBase knowledgeBase;
        string ruleName;
        int mode;
        int idx;
        public ChangeRule(int ruleIndex, int idx, string ruleName,  KnowledgeBase knowledgeBase)
        {
            InitializeComponent();
            this.idx = idx;
            mode = ruleIndex;
            this.ruleName = ruleName;
            this.rules = knowledgeBase.rules;
            this.knowledgeBase = knowledgeBase;
            if (ruleIndex != -1) //загрузка информации о правиле
            {
                Rule r = knowledgeBase.rules.Find(x => x.ruleName == ruleName);
                rule = new Rule(r.ruleName, new List<Fact>(r.facts), r.conclusion, r.ruleDescription);
                tbRuleName.Text = ruleName;
                lvConclusion.Items.Add(rule.conclusion.var.varName + " = " + rule.conclusion.value.value);
                FillLV();
                rtbDescription.Text = rule.ruleDescription;
            }
            else
            {
                tbRuleName.Text = CreateRuleName(rules);
                rule = new Rule();
            }
            btnDeleteConclusion.Enabled = false;
            btnDeletePackage.Enabled = false;
            btnChangeConclusion.Enabled = false;
            btnChangePackage.Enabled = false;
        }

        private void FillLV()
        {
            foreach (Fact f in rule.facts)
            {
                lvPackage.Items.Add(f.var.varName + " = " + f.value.value);
            }
        }

        private void lvPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPackage.SelectedItems.Count != 0)
            {
                btnChangePackage.Enabled = true;
                btnDeletePackage.Enabled = true;
            }
            else
            {
                btnChangePackage.Enabled = false;
                btnDeletePackage.Enabled = false;
            }
        }

        private void lvConclusion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvConclusion.SelectedItems.Count != 0)
            {
                btnChangeConclusion.Enabled = true;
                btnDeleteConclusion.Enabled = true;
            }
            else
            {
                btnChangeConclusion.Enabled = false;
                btnDeleteConclusion.Enabled = false;
            }
        }


        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            CreateFact createFact = new CreateFact(-1, "", 0, rule, knowledgeBase);
            createFact.ShowDialog();
            FillListPkg();
        }
        private void btnChangePackage_Click(object sender, EventArgs e)
        {
            CreateFact createFact = new CreateFact(lvPackage.SelectedIndices[0], lvPackage.SelectedItems[0].Text, 0, rule, knowledgeBase);
            createFact.ShowDialog();
            FillListPkg();
        }

        private void btnAddConclusion_Click(object sender, EventArgs e)
        {
            CreateFact createFact = new CreateFact(-1, "", 1, rule, knowledgeBase);
            createFact.ShowDialog();
            FillConclusion();
        }
        private void FillListPkg()
        {
            lvPackage.Items.Clear();
            foreach (Fact fact in rule.facts)
                lvPackage.Items.Add(fact.var.varName +  " = " + fact.value.value);
        }
        private void FillConclusion()
        {
            lvConclusion.Items.Clear();
            if (rule.conclusion.var != null)
                lvConclusion.Items.Add(rule.conclusion.var.varName + " = " + rule.conclusion.value.value);
        }
        private string CreateRuleName(List<Rule> rules)
        {
            string name = "";
            int i = 1;
            while (name=="")
            {
                string n = "Rule" + i;
                if (rules.FindIndex(x => x.ruleName == n) == -1)
                    return n;
                i++;
            }
            return name;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (lvConclusion.Items.Count == 0)
            {
                MessageBox.Show("Для правила обязательно должно быть заключение.", "Ошибка!");
                return;
            }
            if (lvPackage.Items.Count == 0)
            {
                MessageBox.Show("Правило должно содержать минимум одну посылку.", "Ошибка!");
                return;
            }
            if (mode == -1) //т.е. происходить добавление правила
            {
                if (knowledgeBase.rules.FindIndex(x=>x.ruleName == tbRuleName.Text) != -1)
                {
                    MessageBox.Show("Правило с таким именем уже существует.", "Ошибка!");
                    return;
                }
                rule.ruleName = tbRuleName.Text;
                rule.ruleDescription = rtbDescription.Text;
                knowledgeBase.rules.Add(rule);
                if (idx != -1)
                    knowledgeBase.rules.Insert(idx+1, rule);
                else
                    knowledgeBase.rules.Add(rule);
            }
            else
            {
                Rule r = knowledgeBase.rules.Find(x => x.ruleName == ruleName);
                r.ruleName = tbRuleName.Text;
                r.ruleDescription = rtbDescription.Text;
                r.facts = rule.facts;
                r.conclusion = rule.conclusion;
            }
            this.Close();
        }

        private void btnDeletePackage_Click(object sender, EventArgs e)
        {
            rule.facts.RemoveAt(lvPackage.SelectedItems[0].Index);
            lvPackage.Items.Remove(lvPackage.SelectedItems[0]); //удалили из списка
        }

        private void btnDeleteConclusion_Click(object sender, EventArgs e)
        {
            lvConclusion.Clear();
            rule.conclusion = null;
        }

        private void btnChangeConclusion_Click(object sender, EventArgs e)
        {
            CreateFact createFact = new CreateFact(lvConclusion.SelectedIndices[0], lvConclusion.SelectedItems[0].Text, 1, rule, knowledgeBase);
            createFact.ShowDialog();
            FillConclusion();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
