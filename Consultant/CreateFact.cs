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
    public partial class CreateFact : Form
    {
        KnowledgeBase knowledgeBase;
        public CreateFact(int factIndex, KnowledgeBase knowledgeBase)
        {
            InitializeComponent();
            this.knowledgeBase = knowledgeBase;
        }

        private void btnAddVar_Click(object sender, EventArgs e)
        {
            CreateVar createVar = new CreateVar(-1, knowledgeBase);
            createVar.ShowDialog();
        }
    }
}
