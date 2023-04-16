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
    public partial class Explanation : Form
    {
        WorkingMemory memory;
        public Explanation(WorkingMemory memory)
        {
            InitializeComponent();
            this.memory = memory;
            tvExplanation.Nodes.Clear();
            lvVars.Items.Clear();
            FillVars();

            if (memory.vars.Count != 0 && memory.rules.ContainsKey(memory.goal.varName))
            {
                SetTreeView(memory.goal, tvExplanation);
            }
        }
        private void FillVars()
        {
            foreach (Fact var in memory.vars)
            {
                string[] row = { var.var.varName,var.value.value };
                var listViewItem = new ListViewItem(row);
                lvVars.Items.Add(listViewItem);
            }
        }

        private string GetInfoAboutFact(Fact fact)
        {
            return $"{fact.var.varName} = {fact.value.value}";
        }

        private TreeNode SetNodes(Rule usedRule)
        {
            var node = new TreeNode("Цель: " + GetInfoAboutFact(usedRule.conclusion) );
            node.Nodes.Add("ЕСЛИ");
            foreach (var c in usedRule.facts)
            {
                var newNode = new TreeNode(GetInfoAboutFact(c));
                newNode.Name = GetInfoAboutFact(c);
                node.Nodes[0].Nodes.Add(newNode);
            }
            node.Nodes.Add("ТО");
            node.Nodes[1].Nodes.Add(GetInfoAboutFact(usedRule.conclusion));
            node.Nodes.Add("Пояснение: " + usedRule.ruleDescription);
            return node;
        }

        private void SetTreeView(Var goal, TreeView tree)
        {
            var usedRule = memory.rules[goal.varName];

            tree.Nodes.Add(SetNodes(usedRule));

            foreach (var c in usedRule.facts)
            {
                if (memory.rules.ContainsKey(c.var.varName))
                {
                    tree.Nodes[0].Nodes.Add(SetNodes(memory.rules[c.var.varName]));
                    SetTreeViewChild(c.var, tree.Nodes[0].Nodes[tree.Nodes[0].Nodes.Count - 1]);
                }
            }
        }

        private void SetTreeViewChild(Var goal, TreeNode tree)
        {
            var usedRule = memory.rules[goal.varName];

            foreach (var c in usedRule.facts)
            {
                if (memory.rules.ContainsKey(c.var.varName))
                {
                    tree.Nodes.Add(SetNodes(memory.rules[c.var.varName]));
                    SetTreeViewChild(c.var, tree.Nodes[tree.Nodes.Count - 1]);
                }
            }
        }

        private void llbShowAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (llbShowAll.Text == "(раскрыть всё)")
            {
                llbShowAll.Text = "(скрыть всё)";
                tvExplanation.ExpandAll();
            }
            else
            {
                llbShowAll.Text = "(раскрыть всё)";
                tvExplanation.CollapseAll();
            }
        }
    }
}
