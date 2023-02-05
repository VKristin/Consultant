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
            gbVarOrDomain.Visible = false;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    gbVarOrDomain.Visible = false;
                    gbPkg.Visible = true;
                    gbConclusion.Visible = true;
                    break;
                case 1:
                    gbVarOrDomain.Visible = true;
                    gbVarOrDomain.Text = "Текст вопроса";
                    gbPkg.Visible = false;
                    gbConclusion.Visible = false;
                    break;
                case 2:
                    gbVarOrDomain.Visible = true;
                    gbVarOrDomain.Text = "Значение домена";
                    gbPkg.Visible = false;
                    gbConclusion.Visible = false;
                    break;
            }
        }
    }
}
