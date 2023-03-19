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
        public CreateVar(int varIndex, KnowledgeBase knowledgeBase)
        {
            this.knowledgeBase = knowledgeBase;
            InitializeComponent();
            if (varIndex == -1)
            {
                tbVarName.Text = CreateVarName(knowledgeBase.vars);
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateDomain createDomain = new CreateDomain(-1, knowledgeBase);
            createDomain.ShowDialog();
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
    }
}
