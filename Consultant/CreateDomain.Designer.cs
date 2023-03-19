namespace Consultant
{
    partial class CreateDomain
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
            this.lbRuleName = new System.Windows.Forms.Label();
            this.tbDomainName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvDomainsValue = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRuleName
            // 
            this.lbRuleName.AutoSize = true;
            this.lbRuleName.Location = new System.Drawing.Point(12, 9);
            this.lbRuleName.Name = "lbRuleName";
            this.lbRuleName.Size = new System.Drawing.Size(73, 13);
            this.lbRuleName.TabIndex = 5;
            this.lbRuleName.Text = "Имя домена:";
            // 
            // tbDomainName
            // 
            this.tbDomainName.Location = new System.Drawing.Point(11, 28);
            this.tbDomainName.Name = "tbDomainName";
            this.tbDomainName.Size = new System.Drawing.Size(479, 20);
            this.tbDomainName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Допустимые значения домена:";
            // 
            // lvDomainsValue
            // 
            this.lvDomainsValue.HideSelection = false;
            this.lvDomainsValue.Location = new System.Drawing.Point(11, 96);
            this.lvDomainsValue.Margin = new System.Windows.Forms.Padding(0);
            this.lvDomainsValue.Name = "lvDomainsValue";
            this.lvDomainsValue.Size = new System.Drawing.Size(480, 97);
            this.lvDomainsValue.TabIndex = 7;
            this.lvDomainsValue.UseCompatibleStateImageBehavior = false;
            this.lvDomainsValue.View = System.Windows.Forms.View.List;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 193);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(482, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(11, 255);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(317, 20);
            this.tbValue.TabIndex = 9;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(415, 255);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "Изменить";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(334, 255);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "Добавить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(415, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 22);
            this.button2.TabIndex = 20;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(334, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 22);
            this.button3.TabIndex = 19;
            this.button3.Text = "ОК";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CreateDomain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 324);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvDomainsValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbRuleName);
            this.Controls.Add(this.tbDomainName);
            this.Name = "CreateDomain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateDomain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRuleName;
        private System.Windows.Forms.TextBox tbDomainName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvDomainsValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}