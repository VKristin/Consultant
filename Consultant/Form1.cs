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
    public partial class Consultant : Form
    {
        ExpertSystemShell expertSystemShell = new ExpertSystemShell();
        public Consultant()
        {
            InitializeComponent();
            btnChangeRule.Enabled = false;
            btnDeleteRule.Enabled = false;
            btnChangeVar.Enabled = false;
            btnDeleteVar.Enabled = false;
            btnDomainChange.Enabled = false;
            btnDomainDelete.Enabled = false;
            lvDomains.Items.Clear();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void начатьКонсультациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultation consultation = new Consultation();
            consultation.Show();
        }

        private void показатьОбъяснениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Explanation explanation = new Explanation();
            explanation.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CreateDomain createDomain = new CreateDomain(lvDomain.SelectedIndices[0], lvDomain.SelectedItems[0].Text, expertSystemShell.knowledgeBase);
            createDomain.ShowDialog();
            lvDomain.Items.Clear();
            for (int i = 0; i < expertSystemShell.knowledgeBase.domains.Count(); i++)
            {
                lvDomain.Items.Add(expertSystemShell.knowledgeBase.domains[i].domainName);
            }
        }

        private void lvRules_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRules.SelectedItems.Count != 0)
            {
                btnChangeRule.Enabled = true;
                btnDeleteRule.Enabled = true;
            }
            else
            {
                btnChangeRule.Enabled = false;
                btnDeleteRule.Enabled = false;
            }
        }
        private void lvVars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvVars.SelectedItems.Count != 0)
            {
                btnChangeVar.Enabled = true;
                btnDeleteVar.Enabled = true;
            }
            else
            {
                btnChangeVar.Enabled = false;
                btnDeleteVar.Enabled = false;
            }
        }
        private void lvDomain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDomain.SelectedItems.Count != 0)
            {
                btnDomainChange.Enabled = true;
                btnDomainDelete.Enabled = true;
                PrintDomainValues(lvDomain.SelectedItems[0].Text);
            }
            else
            {
                btnDomainChange.Enabled = false;
                btnDomainDelete.Enabled = false;
                lvDomains.Items.Clear();
            }
        }
        private void PrintDomainValues(string domainName)
        {
            Domain domain = expertSystemShell.knowledgeBase.domains.Find(x=>x.domainName==domainName);
            foreach (DomainValue dv in domain.value)
            {
                lvDomains.Items.Add(dv.value);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateDomain createDomain = new CreateDomain(-1, "", expertSystemShell.knowledgeBase);
            createDomain.ShowDialog();
            lvDomain.Items.Clear();
            for (int i = 0; i < expertSystemShell.knowledgeBase.domains.Count(); i++)
            {
                lvDomain.Items.Add(expertSystemShell.knowledgeBase.domains[i].domainName);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangeRule changeRule = new ChangeRule(-1, expertSystemShell.knowledgeBase); //происходит добавление, а не редактирование
            changeRule.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeRule changeRule = new ChangeRule(lvRules.SelectedIndices[0], expertSystemShell.knowledgeBase);
        }

        private void btnVarAdd_Click(object sender, EventArgs e)
        {
            CreateVar createVar = new CreateVar(-1, expertSystemShell.knowledgeBase);
            createVar.ShowDialog();
        }

        private void btnChangeVar_Click(object sender, EventArgs e)
        {
            CreateVar createVar = new CreateVar(lvVars.SelectedIndices[0], expertSystemShell.knowledgeBase);
            createVar.ShowDialog();
        }
    }
}
