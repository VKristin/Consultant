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
            gbDomain.Visible = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    gbDomain.Visible = false;
                    gbPkgOrVar.Visible = true;
                    gbConclusionorDomain.Visible = true;
                    gbPkgOrVar.Text = "Посылка";
                    gbConclusionorDomain.Text = "Заключение";
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    break;
                    //добавить значение домена
                case 1:
                    gbDomain.Visible = false;
                    gbPkgOrVar.Visible = true;
                    gbConclusionorDomain.Visible = true;
                    gbPkgOrVar.Text = "Текст вопроса";
                    gbConclusionorDomain.Text = "Значение домена";
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    break;
                case 2:
                    gbDomain.Visible = true;
                    gbDomain.Text = "Значение домена";
                    gbPkgOrVar.Visible = false;
                    gbConclusionorDomain.Visible = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    break;
            }
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
            if (lvRules.SelectedItems.Count != 0)
            {
                ChangeRule changeRule = new ChangeRule();
                changeRule.Show();
            }
        }

        private void lvRules_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRules.SelectedItems.Count != 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0: break;
                case 1: CreateVar createVar = new CreateVar(); createVar.Show(); break;
                case 2: break;
            }
        }
    }
}
