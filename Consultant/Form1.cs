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
        public Consultant()
        {
            InitializeComponent();
            btnChangeRule.Enabled = false;
            btnDeleteRule.Enabled = false;
            btnChangeVar.Enabled = false;
            btnDeleteVar.Enabled = false;
            btnDomainChange.Enabled = false;
            btnDomainDelete.Enabled = false;
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
            CreateDomain createDomain = new CreateDomain(lvDomain.SelectedIndices[0]);
            createDomain.ShowDialog();
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
            if (lvRules.SelectedItems.Count != 0)
            {
                btnDomainChange.Enabled = true;
                btnDomainDelete.Enabled = true;
            }
            else
            {
                btnDomainChange.Enabled = false;
                btnDomainDelete.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateDomain createDomain = new CreateDomain(-1);
            createDomain.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangeRule changeRule = new ChangeRule(-1); //происходит добавление, а не редактирование
            changeRule.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeRule changeRule = new ChangeRule(lvRules.SelectedIndices[0]);
        }

        private void btnVarAdd_Click(object sender, EventArgs e)
        {
            CreateVar createVar = new CreateVar(-1);
            createVar.ShowDialog();
        }

        private void btnChangeVar_Click(object sender, EventArgs e)
        {
            CreateVar createVar = new CreateVar(lvVars.SelectedIndices[0]);
            createVar.ShowDialog();
        }
    }
}
