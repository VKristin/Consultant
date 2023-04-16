namespace Consultant
{
    partial class Consultation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbDialog = new System.Windows.Forms.RichTextBox();
            this.cbAnswer = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.llExpl = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbDialog);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rtbDialog
            // 
            this.rtbDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtbDialog.Location = new System.Drawing.Point(3, 16);
            this.rtbDialog.Name = "rtbDialog";
            this.rtbDialog.ReadOnly = true;
            this.rtbDialog.Size = new System.Drawing.Size(420, 388);
            this.rtbDialog.TabIndex = 0;
            this.rtbDialog.Text = "";
            // 
            // cbAnswer
            // 
            this.cbAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnswer.FormattingEnabled = true;
            this.cbAnswer.Location = new System.Drawing.Point(3, 410);
            this.cbAnswer.Name = "cbAnswer";
            this.cbAnswer.Size = new System.Drawing.Size(275, 21);
            this.cbAnswer.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(285, 411);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(138, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Ответить";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // llExpl
            // 
            this.llExpl.AutoSize = true;
            this.llExpl.Location = new System.Drawing.Point(294, 416);
            this.llExpl.Name = "llExpl";
            this.llExpl.Size = new System.Drawing.Size(120, 13);
            this.llExpl.TabIndex = 1;
            this.llExpl.TabStop = true;
            this.llExpl.Text = "Показать объяснение";
            this.llExpl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llExpl_LinkClicked);
            // 
            // Consultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 442);
            this.Controls.Add(this.llExpl);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.cbAnswer);
            this.Controls.Add(this.groupBox1);
            this.Name = "Consultation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Консультация";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbAnswer;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbDialog;
        private System.Windows.Forms.LinkLabel llExpl;
    }
}