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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.splitter3 = new System.Windows.Forms.Splitter();
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
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(389, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 270);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(391, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 270);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(394, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(382, 270);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(776, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 270);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // Explanation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(783, 270);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tvExplanation);
            this.Name = "Explanation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Объяснение";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvExplanation;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Splitter splitter3;
    }
}