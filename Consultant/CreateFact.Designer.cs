namespace Consultant
{
    partial class CreateFact
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
            this.cbVar = new System.Windows.Forms.ComboBox();
            this.lbRuleName = new System.Windows.Forms.Label();
            this.cbDomainValue = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnAddVar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbVar
            // 
            this.cbVar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVar.FormattingEnabled = true;
            this.cbVar.Location = new System.Drawing.Point(13, 13);
            this.cbVar.Margin = new System.Windows.Forms.Padding(0);
            this.cbVar.Name = "cbVar";
            this.cbVar.Size = new System.Drawing.Size(446, 21);
            this.cbVar.TabIndex = 0;
            this.cbVar.SelectedIndexChanged += new System.EventHandler(this.cbVar_SelectedIndexChanged);
            // 
            // lbRuleName
            // 
            this.lbRuleName.AutoSize = true;
            this.lbRuleName.Location = new System.Drawing.Point(241, 47);
            this.lbRuleName.Name = "lbRuleName";
            this.lbRuleName.Size = new System.Drawing.Size(13, 13);
            this.lbRuleName.TabIndex = 4;
            this.lbRuleName.Text = "=";
            // 
            // cbDomainValue
            // 
            this.cbDomainValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDomainValue.FormattingEnabled = true;
            this.cbDomainValue.Location = new System.Drawing.Point(13, 73);
            this.cbDomainValue.Name = "cbDomainValue";
            this.cbDomainValue.Size = new System.Drawing.Size(467, 21);
            this.cbDomainValue.TabIndex = 5;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(405, 131);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "Отмена";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(324, 131);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "ОК";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnAddVar
            // 
            this.btnAddVar.Location = new System.Drawing.Point(459, 11);
            this.btnAddVar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddVar.Name = "btnAddVar";
            this.btnAddVar.Size = new System.Drawing.Size(21, 24);
            this.btnAddVar.TabIndex = 17;
            this.btnAddVar.Text = "+";
            this.btnAddVar.UseVisualStyleBackColor = true;
            this.btnAddVar.Click += new System.EventHandler(this.btnAddVar_Click);
            // 
            // CreateFact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 166);
            this.Controls.Add(this.btnAddVar);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.cbDomainValue);
            this.Controls.Add(this.lbRuleName);
            this.Controls.Add(this.cbVar);
            this.Name = "CreateFact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateFact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVar;
        private System.Windows.Forms.Label lbRuleName;
        private System.Windows.Forms.ComboBox cbDomainValue;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnAddVar;
    }
}