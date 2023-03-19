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
    public partial class CreateDomain : Form
    {
        Domain domain = new Domain();
        KnowledgeBase knowledgeBase = new KnowledgeBase();
        public CreateDomain(int domainIndex, KnowledgeBase knowledgeBase)
        {
            this.knowledgeBase= knowledgeBase;
            InitializeComponent();
            if (domainIndex == -1)
            {
                tbDomainName.Text = CreateDomainName(knowledgeBase.domains);
            }
            else
            {
                
            }
        }
        private string CreateDomainName(List<Domain> domains)
        {
            string name = "";
            int i = 1;
            while (name == "")
            {
                string n = "Domain" + i;
                if (domains.FindIndex(x => x.domainName == n) == -1)
                    return n;
                i++;
            }
            return name;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DomainValue domainValue = new DomainValue();
            if (domain.value.FindIndex(x => x.value == tbValue.Text) == -1)
            {
                domainValue.value = tbValue.Text;
                domain.value.Add(domainValue);
                lvDomainsValue.Items.Add(domainValue.value);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            knowledgeBase.domains.Add(domain);
            
        }
    }
}
