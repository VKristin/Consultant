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
    public partial class Consultation : Form
    {
        ExpertSystemShell exs;
        KnowledgeBase knowledgeBase;
        WorkingMemory workingMemory;
        public Consultation(ExpertSystemShell exs)
        {
            InitializeComponent();
            rtbDialog.Text = "Консультант: Выберете цель консультации.";
            this.exs = exs;
            knowledgeBase = exs.knowledgeBase;
            FillGoals();
        }

        private void FillGoals()
        {
            //Посылка - все переменные, заключение - только выводимые
            foreach (Var variable in knowledgeBase.vars)
            {
                if (variable.varType == VarType.Inferred || variable.varType == VarType.InferredRequested)
                    cbAnswer.Items.Add(variable.varName);
            }
            if (cbAnswer.Items.Count == 0)
                cbAnswer.SelectedIndex = 0;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (cbAnswer.SelectedIndex != -1) 
            { 
                rtbDialog.Text += "\nВы: " + cbAnswer.Text;
            }
        }
    }
}
