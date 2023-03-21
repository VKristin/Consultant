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
        int mode;
        Domain domain = new Domain();
        KnowledgeBase knowledgeBase = new KnowledgeBase();
        public CreateDomain(int domainIndex, string domainName, KnowledgeBase knowledgeBase)
        {
            mode = domainIndex;
            this.knowledgeBase= knowledgeBase;
            InitializeComponent();
            btnCreate.Enabled = true;
            btnChange.Enabled = false;
            if (domainIndex == -1)
            {
                tbDomainName.Text = CreateDomainName(knowledgeBase.domains);
            }
            else
            {
                tbDomainName.Text = domainName;
                domain = knowledgeBase.domains.Find(x => x.domainName == domainName);
                FillValues();
            }
        }
        private void FillValues()
        {
            for (int i = 0; i < domain.value.Count(); i++)
            {
                lvDomainsValue.Items.Add(domain.value[i].value);
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
            if (tbValue.Text == "")
            {
                MessageBox.Show("Значение домена не может быть пустым.", "Ошибка!");
                return;
            }
            DomainValue domainValue = new DomainValue();
            if (domain.value.FindIndex(x => x.value == tbValue.Text) == -1)
            {
                domainValue.value = tbValue.Text;
                domain.value.Add(domainValue);
                lvDomainsValue.Items.Add(domainValue.value);
                tbValue.Text = "";
            }
            else
            {
                MessageBox.Show("Такое значение домена уже существует.", "Ошибка!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbDomainName.Text == null)
            {
                MessageBox.Show("Имя домена не может быть пустым.", "Ошибка!");
                return;
            }
            if (mode == -1)
            {
                if (knowledgeBase.domains.Find(x => x.domainName == tbDomainName.Text) == null)
                {
                    domain.domainName = tbDomainName.Text;
                    knowledgeBase.domains.Add(domain);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Домен с таким именем уже существует.", "Ошибка!");
                }
            }
            else
            {
                knowledgeBase.domains[mode].domainName=tbDomainName.Text;
                this.Close();
            }
        }

        private void lvDomainsValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDomainsValue.SelectedItems.Count != 0)
            {
                btnCreate.Enabled = false;
                btnChange.Enabled = true;
            }
            else
            {
                btnCreate.Enabled = true;
                btnChange.Enabled = false;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            DomainValue domVal = domain.value.Find(x => x.value == lvDomainsValue.SelectedItems[0].Text);
            domVal.value = tbValue.Text;
            lvDomainsValue.SelectedItems[0].Text = tbValue.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
