using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            btnDeleteDomainValue.Enabled = false;
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
                btnDeleteDomainValue.Enabled = true;
            }
            else
            {
                btnCreate.Enabled = true;
                btnDeleteDomainValue.Enabled = false;
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

        private void lvDomainsValue_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lvDomainsValue.DoDragDrop(e.Item, DragDropEffects.Move);
        }
        private void lvDomainsValue_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        // Moves the insertion mark as the item is dragged.
        private void lvDomainsValue_DragOver(object sender, DragEventArgs e)
        {
            // Retrieve the client coordinates of the mouse pointer.
            Point targetPoint =
                lvDomainsValue.PointToClient(new Point(e.X, e.Y));

            // Retrieve the index of the item closest to the mouse pointer.
            int targetIndex = lvDomainsValue.InsertionMark.NearestIndex(targetPoint);

            // Confirm that the mouse pointer is not over the dragged item.
            if (targetIndex > -1)
            {
                // Determine whether the mouse pointer is to the left or
                // the right of the midpoint of the closest item and set
                // the InsertionMark.AppearsAfterItem property accordingly.
                Rectangle itemBounds = lvDomainsValue.GetItemRect(targetIndex);
                if (targetPoint.X > itemBounds.Left + (itemBounds.Width / 2))
                {
                    lvDomainsValue.InsertionMark.AppearsAfterItem = true;
                }
                else
                {
                    lvDomainsValue.InsertionMark.AppearsAfterItem = false;
                }
            }

            // Set the location of the insertion mark. If the mouse is
            // over the dragged item, the targetIndex value is -1 and
            // the insertion mark disappears.
            lvDomainsValue.InsertionMark.Index = targetIndex;
        }
        private void lvDomainsValue_DragLeave(object sender, EventArgs e)
        {
            lvDomainsValue.InsertionMark.Index = -1;
        }

        // Moves the item to the location of the insertion mark.
        private void lvDomainsValue_DragDrop(object sender, DragEventArgs e)
        {
            // Retrieve the index of the insertion mark;
            int targetIndex = lvDomainsValue.InsertionMark.Index;

            // If the insertion mark is not visible, exit the method.
            if (targetIndex == -1)
            {
                return;
            }

            // If the insertion mark is to the right of the item with
            // the corresponding index, increment the target index.
            if (lvDomainsValue.InsertionMark.AppearsAfterItem)
            {
                targetIndex++;
            }

            // Retrieve the dragged item.
            ListViewItem draggedItem =
                (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            // Insert a copy of the dragged item at the target index.
            // A copy must be inserted before the original item is removed
            // to preserve item index values. 
            lvDomainsValue.Items.Insert(
                targetIndex, (ListViewItem)draggedItem.Clone());

            // Remove the original copy of the dragged item.
            lvDomainsValue.Items.Remove(draggedItem);
        }

        // Sorts ListViewItem objects by index.
        private class ListViewIndexComparer : System.Collections.IComparer
        {
            public int Compare(object x, object y)
            {
                return ((ListViewItem)x).Index - ((ListViewItem)y).Index;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            domain.value.RemoveAll(x => x.value == lvDomainsValue.SelectedItems[0].Text);
            lvDomainsValue.Clear();
            for (int i = 0; i < domain.value.Count(); i++)
            {
                lvDomainsValue.Items.Add(domain.value[i].value);
            }
        }
    }
}
