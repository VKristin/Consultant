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
    public partial class CreateVar : Form
    {
        KnowledgeBase knowledgeBase;
        Var var;
        string question = "";
        int mode;
        public string varName = "";
        public VarType vt;
        public CreateVar(int varIndex, string varName, KnowledgeBase knowledgeBase)
        {
            this.knowledgeBase = knowledgeBase;
            InitializeComponent();
            FillCB();
            if (varIndex == -1)
            {
                if (knowledgeBase.domains.Count != 0)
                    cbDomain.SelectedIndex = 0;
                var = new Var();
                tbVarName.Text = CreateVarName(knowledgeBase.vars);
                rbQuestion.Text = tbVarName.Text + '?';
            }
            else
            {
                var = knowledgeBase.vars.Find(x => x.varName == varName);
                tbVarName.Text = varName;
                rbQuestion.Text = var.question;
                cbDomain.SelectedIndex = knowledgeBase.domains.FindIndex(x => x.domainName == var.varDomain.domainName);
                if (var.varType == VarType.Requested)
                    rbRequested.Checked = true;
                if (var.varType == VarType.Inferred)
                    rbInferred.Checked = true;
                if (var.varType == VarType.InferredRequested)
                    rbRequestedInferred.Checked = true;
            }
            mode = varIndex;
        }

        private void FillCB()
        {
            for (int i = 0; i < knowledgeBase.domains.Count(); i++)
            {
                cbDomain.Items.Add(knowledgeBase.domains[i].domainName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateDomain createDomain = new CreateDomain(-1, "", knowledgeBase);
            createDomain.ShowDialog();
            cbDomain.Items.Clear();
            FillCB();
            if (createDomain.insertId > -1)
                cbDomain.SelectedIndex = createDomain.insertId;
            else
            {
                if (knowledgeBase.domains.Count != 0 && cbDomain.SelectedIndex == -1)
                {
                    cbDomain.SelectedIndex = 0;
                }
            }
            if (question == "")
                question = tbVarName.Text + "?";
        }
        private string CreateVarName(List<Var> vars)
        {
            string name = "";
            int i = 1;
            while (name == "")
            {
                string n = "Var" + i;
                if (vars.FindIndex(x => x.varName == n) == -1)
                    return n;
                i++;
            }
            return name;
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            rbQuestion.Enabled = !rbInferred.Checked;
            if (rbInferred.Checked)
            {
                question = rbQuestion.Text;
                rbQuestion.Text = "";
            }
            else
            {
                if (question == "")
                    question = tbVarName.Text + "?";
                rbQuestion.Text = question;
            }
        }
        /*
         * Requested,
        Inferred,
        InferredRequested
        */
        private void btnSaveVar_Click(object sender, EventArgs e)
        {
            if (tbVarName.Text == "")
            {
                MessageBox.Show("Имя переменной не может быть пустым.", "Ошибка!");
                return;
            }
            if (rbQuestion.Text == "" && rbQuestion.Enabled)
            {
                MessageBox.Show("Для заданной переменной должен быть указан вопрос.", "Ошибка!");
                return;
            }
            if (cbDomain.Items.Count == 0)
            {
                MessageBox.Show("Отсутствует домен.", "Ошибка!");
                return;
            }
            if (mode == -1)
            {
                if (knowledgeBase.vars.FindIndex(x => x.varName == tbVarName.Text) != -1)
                {
                    MessageBox.Show("Переменная с таким именем уже существует.", "Ошибка!");
                    return;
                }
                Domain domain = knowledgeBase.domains.Find(x => x.domainName == cbDomain.Text);
                VarType vt = vt = VarType.Requested;
                if (rbRequested.Checked)
                    vt = VarType.Requested;
                if (rbInferred.Checked)
                    vt = VarType.Inferred;
                if (rbRequestedInferred.Checked)
                    vt = VarType.InferredRequested;
                Var v = new Var(tbVarName.Text, domain, rbQuestion.Text, vt);
                knowledgeBase.vars.Add(v);
                vt = v.varType;
                varName = tbVarName.Text;
            }
            else
            {
                VarType vt = vt = VarType.Requested;
                Domain domain = knowledgeBase.domains.Find(x => x.domainName == cbDomain.Text);
                if (rbRequested.Checked)
                    vt = VarType.Requested;
                if (rbInferred.Checked)
                    vt = VarType.Inferred;
                if (rbRequestedInferred.Checked)
                    vt = VarType.InferredRequested;
                var.varName = tbVarName.Text;
                var.varType = vt;
                var.question = rbQuestion.Text;
                var.varDomain = domain;
            }
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
