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
            ((System.ComponentModel.ISupportInitialize)(this.dgvExplanation)).BeginInit();
            this.SuspendLayout();
            // 
            // tvExplanation
            // 
            this.tvExplanation.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvExplanation.Location = new System.Drawing.Point(0, 0);
            this.tvExplanation.Name = "tvExplanation";
            this.tvExplanation.Size = new System.Drawing.Size(389, 270);
            this.tvExplanation.TabIndex = 0;
            // 
            // dgvExplanation
            // 
            this.dgvExplanation.AllowUserToAddRows = false;
            this.dgvExplanation.AllowUserToDeleteRows = false;
            this.dgvExplanation.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvExplanation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExplanation.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvExplanation.Location = new System.Drawing.Point(389, 0);
            this.dgvExplanation.Name = "dgvExplanation";
            this.dgvExplanation.ReadOnly = true;
            this.dgvExplanation.Size = new System.Drawing.Size(399, 270);
            this.dgvExplanation.TabIndex = 1;
            // 
            // Explanation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 270);
            this.Controls.Add(this.dgvExplanation);
            this.Controls.Add(this.tvExplanation);
            this.Name = "Explanation";
            this.Text = "Объяснение";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExplanation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvExplanation;
        private System.Windows.Forms.DataGridView dgvExplanation;
    }
}