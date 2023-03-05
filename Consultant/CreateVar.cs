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
        public CreateVar(int varIndex)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateDomain createDomain = new CreateDomain(-1);
            createDomain.ShowDialog();
        }
    }
}
