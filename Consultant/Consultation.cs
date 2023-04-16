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
        public ExpertSystemShell exs;
        public KnowledgeBase knowledgeBase;
        public WorkingMemory workingMemory;
        public bool pressed = false;
        bool goal = true;
        public string answer;
        Consultant cons;

        public Consultation(ExpertSystemShell exs, Consultant cons)
        {
            this.exs = exs;
            InitializeComponent();
            if (exs.knowledgeBase.vars.FindAll(x => x.varType == VarType.Requested || x.varType == VarType.InferredRequested).Count() != 0)
            {
                SetGoal(exs);
                this.cons = cons;
                llExpl.Visible = false;
            }
            else
            {
                cbAnswer.Enabled = false;
                btnSend.Enabled = false;
                llExpl.Visible = false;
                rtbDialog.Text = "Консультант: Простите, но консультация невозможна. Используемая Вами база знаний не имеет переменных, которые могли бы подойти в качестве цели консультации.";
            }
        }
        private void ShowExpl()
        {
            cbAnswer.Invoke(new Action(() => cbAnswer.Items.Clear()));
            cbAnswer.Invoke(new Action(() => cbAnswer.Enabled = false));
            btnSend.Invoke(new Action(() => btnSend.Visible = false));
            llExpl.Invoke(new Action(() => llExpl.Visible = true));
        }

        private void SetGoal(ExpertSystemShell exs)
        {
            rtbDialog.Text = "Консультант: Выберете цель консультации.";
            this.exs = exs;
            knowledgeBase = exs.knowledgeBase;
            workingMemory= exs.workingMemory;
            FillGoals();
            exs.mlv = new MLV();
        }

        private void FillGoals()
        {
            //Посылка - все переменные, заключение - только выводимые
            foreach (Var variable in knowledgeBase.vars)
            {
                if (variable.varType == VarType.Inferred || variable.varType == VarType.InferredRequested)
                    cbAnswer.Items.Add(variable.varName);
            }
            if (cbAnswer.Items.Count != 0)
                cbAnswer.SelectedIndex = 0;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (cbAnswer.SelectedIndex != -1) 
            { 
                rtbDialog.AppendText("\nВы: " + cbAnswer.Text);
            }
            if (goal) //если была запрошена цель консультации
            {
                exs.workingMemory = new WorkingMemory();
                workingMemory = exs.workingMemory;
                Var v = knowledgeBase.vars.Find(x => x.varName == cbAnswer.SelectedItem.ToString());
                //exs.mlv.StartConsultation(this);
                exs.workingMemory.goal = v;
                exs.mlv.StartConsultation(this);
                goal = false;
            }
            else
            {
                answer = cbAnswer.SelectedItem.ToString();
                pressed = true;
            }
        }

        public void PrintQuestion(Var goal)
        {
            SetVariable(goal);

            string question = "";
            if (goal.varType != VarType.Inferred )
                question = goal.question;

            rtbDialog.Invoke(new Action (() => rtbDialog.Text += $"\nКонсультант: {question}"));
            rtbDialog.Invoke(new Action(() => rtbDialog.SelectionStart = rtbDialog.Text.Length));
            rtbDialog.Invoke(new Action(() => rtbDialog.ScrollToCaret()));

        }
        private void SetVariable(Var goal)
        {
            cbAnswer.Invoke(new Action(() => cbAnswer.Items.Clear()));
            foreach (var value in goal.varDomain.value)
            {
                cbAnswer.Invoke(new Action(() => cbAnswer.Items.Add(value.value)));
            }
            cbAnswer.Invoke(new Action(() => cbAnswer.SelectedIndex = 0));
        }

        private void llExpl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Explanation expl = new Explanation(workingMemory);
            expl.ShowDialog();
        }
        public void PrintSuccess()
        {
            rtbDialog.Invoke(new Action(() => rtbDialog.AppendText($"\nКонсультант: Цель консультации была достигнута!\n")));
            rtbDialog.Invoke(new Action(() => rtbDialog.AppendText(
                $"Консультант: {exs.workingMemory.goal.varName} = {exs.workingMemory.ReturnGoalResult()}\n")));
            rtbDialog.Invoke(new Action(() => rtbDialog.SelectionStart = rtbDialog.Text.Length));
            rtbDialog.Invoke(new Action(() => rtbDialog.ScrollToCaret()));
            ShowExpl();
        }
        public void PrintUnSuccess()
        {
            rtbDialog.Invoke(new Action(() => rtbDialog.AppendText($"\nКонсультант: Цели консультации не удалось достигнуть.")));
            rtbDialog.Invoke(new Action(() => rtbDialog.SelectionStart = rtbDialog.Text.Length));
            rtbDialog.Invoke(new Action(() => rtbDialog.ScrollToCaret()));
            ShowExpl();
        }

    }
}
