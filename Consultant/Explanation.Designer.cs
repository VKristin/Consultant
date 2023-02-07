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
            this.tvExplanation = new System.Windows.Forms.TreeView();
            this.dgvExplanation = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExplanation)).BeginInit();
            this.SuspendLayout();
            // 
            // tvExplanation
            // 
            this.tvExplanation.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvExplanation.Location = new System.Drawing.Point(0, 0);
            this.tvExplanation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tvExplanation.Name = "tvExplanation";
            this.tvExplanation.Size = new System.Drawing.Size(517, 332);
            this.tvExplanation.TabIndex = 0;
            // 
            // dgvExplanation
            // 
            this.dgvExplanation.AllowUserToAddRows = false;
            this.dgvExplanation.AllowUserToDeleteRows = false;
            this.dgvExplanation.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvExplanation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExplanation.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvExplanation.Location = new System.Drawing.Point(517, 0);
            this.dgvExplanation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvExplanation.Name = "dgvExplanation";
            this.dgvExplanation.ReadOnly = true;
            this.dgvExplanation.RowHeadersWidth = 51;
            this.dgvExplanation.Size = new System.Drawing.Size(532, 332);
            this.dgvExplanation.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(1049, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 332);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // Explanation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 332);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dgvExplanation);
            this.Controls.Add(this.tvExplanation);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Explanation";
            this.Text = "Объяснение";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExplanation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvExplanation;
        private System.Windows.Forms.DataGridView dgvExplanation;
        private System.Windows.Forms.Splitter splitter1;
    }
}