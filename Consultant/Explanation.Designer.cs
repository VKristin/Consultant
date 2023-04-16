namespace Consultant
{
    partial class Explanation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvVars = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvExplanation = new System.Windows.Forms.TreeView();
            this.lvRules = new System.Windows.Forms.Label();
            this.lbVars = new System.Windows.Forms.Label();
            this.llbShowAll = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lvVars
            // 
            this.lvVars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chValue});
            this.lvVars.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvVars.HideSelection = false;
            this.lvVars.Location = new System.Drawing.Point(500, 13);
            this.lvVars.Name = "lvVars";
            this.lvVars.Size = new System.Drawing.Size(493, 257);
            this.lvVars.TabIndex = 4;
            this.lvVars.UseCompatibleStateImageBehavior = false;
            this.lvVars.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Имя";
            this.chName.Width = 218;
            // 
            // chValue
            // 
            this.chValue.Text = "Значение";
            this.chValue.Width = 259;
            // 
            // tvExplanation
            // 
            this.tvExplanation.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvExplanation.Location = new System.Drawing.Point(0, 13);
            this.tvExplanation.Name = "tvExplanation";
            this.tvExplanation.Size = new System.Drawing.Size(500, 257);
            this.tvExplanation.TabIndex = 0;
            // 
            // lvRules
            // 
            this.lvRules.AutoSize = true;
            this.lvRules.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvRules.Location = new System.Drawing.Point(0, 0);
            this.lvRules.Name = "lvRules";
            this.lvRules.Size = new System.Drawing.Size(51, 13);
            this.lvRules.TabIndex = 5;
            this.lvRules.Text = "Правила";
            // 
            // lbVars
            // 
            this.lbVars.AutoSize = true;
            this.lbVars.Location = new System.Drawing.Point(500, -1);
            this.lbVars.Name = "lbVars";
            this.lbVars.Size = new System.Drawing.Size(73, 13);
            this.lbVars.TabIndex = 6;
            this.lbVars.Text = "Переменные";
            // 
            // llbShowAll
            // 
            this.llbShowAll.AutoSize = true;
            this.llbShowAll.Location = new System.Drawing.Point(57, -1);
            this.llbShowAll.Name = "llbShowAll";
            this.llbShowAll.Size = new System.Drawing.Size(83, 13);
            this.llbShowAll.TabIndex = 7;
            this.llbShowAll.TabStop = true;
            this.llbShowAll.Text = "(раскрыть всё)";
            this.llbShowAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbShowAll_LinkClicked);
            // 
            // Explanation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(995, 270);
            this.Controls.Add(this.llbShowAll);
            this.Controls.Add(this.lbVars);
            this.Controls.Add(this.lvVars);
            this.Controls.Add(this.tvExplanation);
            this.Controls.Add(this.lvRules);
            this.Name = "Explanation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Объяснение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvVars;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chValue;
        private System.Windows.Forms.TreeView tvExplanation;
        private System.Windows.Forms.Label lvRules;
        private System.Windows.Forms.Label lbVars;
        private System.Windows.Forms.LinkLabel llbShowAll;
    }
}