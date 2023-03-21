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

namespace Consultant
{
    public partial class ChangeRule : Form
    {
        List<Rule> rules;
        List<Var> vars;
        KnowledgeBase knowledgeBase;
        public ChangeRule(int ruleIndex, KnowledgeBase knowledgeBase)
        {
            InitializeComponent();
            this.vars = knowledgeBase.vars;
            this.rules = knowledgeBase.rules;
            this.knowledgeBase = knowledgeBase;
            if (ruleIndex != -1) //загрузка информации о правиле
            { }
            else
            {
                tbRuleName.Text = CreateRuleName(rules);
            }
            btnDeleteConclusion.Enabled = false;
            btnDeletePackage.Enabled = false;
            btnChangeConclusion.Enabled = false;
            btnChangePackage.Enabled = false;
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
            CreateFact createFact = new CreateFact(-1, knowledgeBase);
            createFact.ShowDialog();
        }
        private void btnChangePackage_Click(object sender, EventArgs e)
        {
            CreateFact createFact = new CreateFact(lvPackage.SelectedIndices[0], knowledgeBase);
            createFact.ShowDialog();
        }

        private void btnAddConclusion_Click(object sender, EventArgs e)
        {
            CreateFact createFact = new CreateFact(-1, knowledgeBase);
            createFact.ShowDialog();
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

        }
    }
}
