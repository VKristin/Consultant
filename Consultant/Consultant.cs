using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Consultant
{
    public partial class Consultant : Form
    {
        string path = "";
        public ExpertSystemShell expertSystemShell = new ExpertSystemShell();
        public KnowledgeBase knowledgeBase = new KnowledgeBase();

        public Consultant()
        {
            expertSystemShell.knowledgeBase = knowledgeBase;
            InitializeComponent();
            btnChangeRule.Enabled = false;
            btnDeleteRule.Enabled = false;
            btnChangeVar.Enabled = false;
            btnDeleteVar.Enabled = false;
            btnDomainChange.Enabled = false;
            btnDomainDelete.Enabled = false;
            lvDomains.Items.Clear();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillVars();
            FillDomains();
        }

        private void начатьКонсультациюToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Consultation consultation = new Consultation(expertSystemShell, this);
            consultation.ShowDialog();
        }

        private void показатьОбъяснениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Explanation explanation = new Explanation(expertSystemShell.workingMemory);
            explanation.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CreateDomain createDomain = new CreateDomain(lvDomain.SelectedIndices[0], lvDomain.SelectedItems[0].Text, expertSystemShell.knowledgeBase);
            createDomain.ShowDialog();
            lvDomain.Items.Clear();
            for (int i = 0; i < knowledgeBase.domains.Count(); i++)
            {
                lvDomain.Items.Add(knowledgeBase.domains[i].domainName);
            }
            lvDomains.Items.Clear();
        }

        private void lvRules_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRules.SelectedItems.Count != 0)
            {
                btnChangeRule.Enabled = true;
                btnDeleteRule.Enabled = true;
                FillRulesInformation();
            }
            else
            {
                btnChangeRule.Enabled = false;
                btnDeleteRule.Enabled = false;
                lvConclusion.Items.Clear();
                lvPkg.Items.Clear();
            }
        }
        private void FillRulesInformation()
        {
            lvConclusion.Items.Clear();
            Rule selectedRule = knowledgeBase.rules[lvRules.SelectedIndices[0]];
            if (selectedRule.conclusion != null && selectedRule.conclusion.var != null)
                lvConclusion.Items.Add(selectedRule.conclusion.var.varName + " = " + selectedRule.conclusion.value.value);
            lvPkg.Items.Clear();
            foreach (Fact pkg in selectedRule.facts)
            {
                lvPkg.Items.Add(pkg.var.varName + " = " + pkg.value.value);
            }
        }
        private void lvVars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvVars.SelectedItems.Count != 0)
            {
                btnChangeVar.Enabled = true;
                btnDeleteVar.Enabled = true;
                FillVarValue(lvVars.SelectedItems[0].SubItems[0].Text);
                FillVarQuestion(lvVars.SelectedItems[0].SubItems[0].Text);
            }
            else
            {
                btnChangeVar.Enabled = false;
                btnDeleteVar.Enabled = false;
                lvValues.Items.Clear();
                rtbQuestion.Text = "";
            }
        }

        private void FillVarValue(string varN)
        {
            lvValues.Items.Clear();
            Var var = knowledgeBase.vars.Find(x => x.varName == varN);
            for (int i = 0; i < var.varDomain.value.Count; i++)
            {
                lvValues.Items.Add(var.varDomain.value[i].value);
            }
        }
        private void FillVarQuestion(string varN)
        {
            rtbQuestion.Text = "";
            Var var = knowledgeBase.vars.Find(x => x.varName == varN);
            rtbQuestion.Text = var.question;
        }
        private void lvDomain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDomain.SelectedItems.Count != 0)
            {
                btnDomainChange.Enabled = true;
                btnDomainDelete.Enabled = true;
                PrintDomainValues(lvDomain.SelectedItems[0].Text);
            }
            else
            {
                btnDomainChange.Enabled = false;
                btnDomainDelete.Enabled = false;
                lvDomains.Items.Clear();
            }
        }
        private void PrintDomainValues(string domainName)
        {
            Domain domain = knowledgeBase.domains.Find(x => x.domainName == domainName);
            foreach (DomainValue dv in domain.value)
            {
                lvDomains.Items.Add(dv.value);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateDomain createDomain = new CreateDomain(-1, "", knowledgeBase);
            createDomain.ShowDialog();
            FillDomains();
        }
        private void FillDomains()
        {
            lvDomain.Items.Clear();
            for (int i = 0; i < knowledgeBase.domains.Count(); i++)
            {
                lvDomain.Items.Add(knowledgeBase.domains[i].domainName);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int idx = lvRules.SelectedIndices.Count != 0 ? lvRules.SelectedIndices[0] : -1;
            ChangeRule changeRule = new ChangeRule(-1, idx, "", knowledgeBase); //происходит добавление, а не редактирование
            changeRule.ShowDialog();
            FillRules();
            ListViewResizeColumns(lvRules);
        }

        private void FillRules()
        {
            lvRules.Items.Clear();
            foreach (Rule rule in knowledgeBase.rules)
            {
                string description = "ЕСЛИ ";

                foreach (Fact fact in rule.facts)
                {
                    if (fact != rule.facts[0])
                    {
                        description += " И ";
                    }
                    description += fact.var.varName + " = " + fact.value.value;
                }
                description += ", ТО " + rule.conclusion.var.varName + " = " + rule.conclusion.value.value;
                string[] row = { rule.ruleName, description };
                var listViewItem = new ListViewItem(row);
                lvRules.Items.Add(listViewItem);
            };
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeRule changeRule = new ChangeRule(lvRules.SelectedIndices[0], -1, lvRules.SelectedItems[0].Text, knowledgeBase);
            changeRule.ShowDialog();
            FillRules();
            lvRules.SelectedIndices.Clear();
            lvConclusion.Items.Clear();
            lvPkg.Items.Clear();
        }

        private void btnVarAdd_Click(object sender, EventArgs e)
        {
            CreateVar createVar = new CreateVar(-1, "", knowledgeBase);
            createVar.ShowDialog();
            FillVars();
            lvVars.SelectedIndices.Clear();
            lvValues.Items.Clear();
            rtbQuestion.Text = "";
        }

        private void FillVars()
        {
            lvVars.Items.Clear();
            for (int i = 0; i < knowledgeBase.vars.Count; i++)
            {
                string[] row = { knowledgeBase.vars[i].varName, ReturnVarType(knowledgeBase.vars[i]), knowledgeBase.vars[i].varDomain.domainName };
                var listViewItem = new ListViewItem(row);
                lvVars.Items.Add(listViewItem);
            }
        }

        private string ReturnVarType(Var var)
        {
            if (var.varType == VarType.Inferred)
                return ("Выводимая");
            if (var.varType == VarType.Requested)
                return ("Запрашиваемая");
            if (var.varType == VarType.InferredRequested)
                return ("Выводимо-запрашиваемая");
            return "";
        }

        private void btnChangeVar_Click(object sender, EventArgs e)
        {
            CreateVar createVar = new CreateVar(lvVars.SelectedIndices[0], lvVars.SelectedItems[0].Text, knowledgeBase);
            createVar.ShowDialog();
            FillVars();
            lvVars.SelectedIndices.Clear();
            lvValues.Items.Clear();
            rtbQuestion.Text = "";
        }

        private void btnDomainDelete_Click(object sender, EventArgs e)
        {
            knowledgeBase.domains.RemoveAll(x => x.domainName == lvDomain.SelectedItems[0].Text); lvDomain.Items.Clear();
            for (int i = 0; i < knowledgeBase.domains.Count(); i++)
            {
                lvDomain.Items.Add(knowledgeBase.domains[i].domainName);
            }
        }

        private void btnDeleteVar_Click(object sender, EventArgs e)
        {
            Var v = knowledgeBase.vars.Find(x => x.varName == lvVars.SelectedItems[0].SubItems[0].Text);
            knowledgeBase.vars.Remove(v);
            FillVars();
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = "";
            CreateNewKnowledgeBase newKnowledgeBase = new CreateNewKnowledgeBase(name);
            newKnowledgeBase.ShowDialog();
            if (newKnowledgeBase.DialogResult == DialogResult.OK)
            {
                tabControl.Visible = true;
                expertSystemShell.knowledgeBase = new KnowledgeBase();
                expertSystemShell.knowledgeBase.baseName = name;
                knowledgeBase = expertSystemShell.knowledgeBase;
                FillDomains();
                FillRules();
                FillVars();
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void SaveAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "expert system files (*.expertsystem)|*.expertsystem|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                using (FileStream fs = new FileStream(filename, FileMode.Create))
                    new BinaryFormatter().Serialize(fs, knowledgeBase);
            }

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "expert system files (*.expertsystem)|*.expertsystem|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                path = filename;
                tabControl.Visible = true;
                expertSystemShell = new ExpertSystemShell();
                expertSystemShell.knowledgeBase = knowledgeBase = LoadFile(filename);
                FillDomains();
                FillRules();
                FillVars();
                ListViewResizeColumns(lvRules);
            }
        }
        private KnowledgeBase LoadFile(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open))
                return (KnowledgeBase)new BinaryFormatter().Deserialize(fs);
        }

        private void btnDeleteRule_Click(object sender, EventArgs e)
        {
            Rule v = knowledgeBase.rules.Find(x => x.ruleName == lvRules.SelectedItems[0].SubItems[0].Text);
            knowledgeBase.rules.Remove(v);
            FillRules();
        }
        private void lvDomainsValue_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lvRules.DoDragDrop(e.Item, DragDropEffects.Move);
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
                lvRules.PointToClient(new Point(e.X, e.Y));

            // Retrieve the index of the item closest to the mouse pointer.
            int targetIndex = lvRules.InsertionMark.NearestIndex(targetPoint);

            // Confirm that the mouse pointer is not over the dragged item.
            if (targetIndex > -1)
            {
                // Determine whether the mouse pointer is to the left or
                // the right of the midpoint of the closest item and set
                // the InsertionMark.AppearsAfterItem property accordingly.
                Rectangle itemBounds = lvRules.GetItemRect(targetIndex);
                if (targetPoint.X > itemBounds.Left + (itemBounds.Width / 2))
                {
                    lvRules.InsertionMark.AppearsAfterItem = true;
                }
                else
                {
                    lvRules.InsertionMark.AppearsAfterItem = false;
                }
            }

            // Set the location of the insertion mark. If the mouse is
            // over the dragged item, the targetIndex value is -1 and
            // the insertion mark disappears.
            lvRules.InsertionMark.Index = targetIndex;
        }
        private void lvDomainsValue_DragLeave(object sender, EventArgs e)
        {
            lvRules.InsertionMark.Index = -1;
        }

        // Moves the item to the location of the insertion mark.
        private void lvDomainsValue_DragDrop(object sender, DragEventArgs e)
        {
            int targetIndex = lvRules.InsertionMark.Index;

            if (targetIndex == -1)
            {
                return;
            }
            if (lvRules.InsertionMark.AppearsAfterItem)
            {
                targetIndex++;
            }
            ListViewItem draggedItem =
                (ListViewItem)e.Data.GetData(typeof(ListViewItem));
            var value = knowledgeBase.rules.Find(x => x.ruleName == draggedItem.Text);
            lvRules.Items.Remove(draggedItem);
            knowledgeBase.rules.Remove(value);
            lvRules.Items.Insert(
                targetIndex, (ListViewItem)draggedItem.Clone());

            knowledgeBase.rules.Insert(targetIndex, value);

            lvRules.SelectedItems.Clear();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            if (path != "")
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите сохранить изменения в открытом ранее файле?", "Осторожно!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (FileStream fs = new FileStream(path, FileMode.Create))
                        new BinaryFormatter().Serialize(fs, knowledgeBase);
                }
            }
            else
            {
                SaveAs();
            }
        }

        private void ListViewResizeColumns(ListView lv)
        {
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Consultant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)       // Ctrl-S Save
            {
                Save();
            }
        }
    }
}
