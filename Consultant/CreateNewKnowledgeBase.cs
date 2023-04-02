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
    public partial class CreateNewKnowledgeBase : Form
    {
        string name;
        public CreateNewKnowledgeBase(string name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbKBName.Text == "")
            {
                MessageBox.Show("База знаний должна иметь имя.", "Ошибка!");
                return;
            }
            name = tbKBName.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
