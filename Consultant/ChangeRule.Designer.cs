namespace Consultant
{
    partial class ChangeRule
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbRuleName = new System.Windows.Forms.Label();
            this.gbPackage = new System.Windows.Forms.GroupBox();
            this.btnDeletePackage = new System.Windows.Forms.Button();
            this.btnChangePackage = new System.Windows.Forms.Button();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.lvPackage = new System.Windows.Forms.ListView();
            this.gbConclusion = new System.Windows.Forms.GroupBox();
            this.btnDeleteConclusion = new System.Windows.Forms.Button();
            this.btnChangeConclusion = new System.Windows.Forms.Button();
            this.lvConclusion = new System.Windows.Forms.ListView();
            this.btnAddConclusion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.gbPackage.SuspendLayout();
            this.gbConclusion.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(564, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lbRuleName
            // 
            this.lbRuleName.AutoSize = true;
            this.lbRuleName.Location = new System.Drawing.Point(13, 26);
            this.lbRuleName.Name = "lbRuleName";
            this.lbRuleName.Size = new System.Drawing.Size(77, 13);
            this.lbRuleName.TabIndex = 1;
            this.lbRuleName.Text = "Имя правила:";
            // 
            // gbPackage
            // 
            this.gbPackage.Controls.Add(this.btnDeletePackage);
            this.gbPackage.Controls.Add(this.btnChangePackage);
            this.gbPackage.Controls.Add(this.btnAddPackage);
            this.gbPackage.Controls.Add(this.lvPackage);
            this.gbPackage.Location = new System.Drawing.Point(12, 84);
            this.gbPackage.Name = "gbPackage";
            this.gbPackage.Size = new System.Drawing.Size(285, 208);
            this.gbPackage.TabIndex = 2;
            this.gbPackage.TabStop = false;
            this.gbPackage.Text = "Посылка";
            // 
            // btnDeletePackage
            // 
            this.btnDeletePackage.Location = new System.Drawing.Point(190, 179);
            this.btnDeletePackage.Name = "btnDeletePackage";
            this.btnDeletePackage.Size = new System.Drawing.Size(95, 23);
            this.btnDeletePackage.TabIndex = 3;
            this.btnDeletePackage.Text = "Удалить";
            this.btnDeletePackage.UseVisualStyleBackColor = true;
            // 
            // btnChangePackage
            // 
            this.btnChangePackage.Location = new System.Drawing.Point(95, 179);
            this.btnChangePackage.Name = "btnChangePackage";
            this.btnChangePackage.Size = new System.Drawing.Size(95, 23);
            this.btnChangePackage.TabIndex = 2;
            this.btnChangePackage.Text = "Изменить";
            this.btnChangePackage.UseVisualStyleBackColor = true;
            this.btnChangePackage.Click += new System.EventHandler(this.btnChangePackage_Click);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(0, 179);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(95, 23);
            this.btnAddPackage.TabIndex = 1;
            this.btnAddPackage.Text = "Добавить";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // lvPackage
            // 
            this.lvPackage.HideSelection = false;
            this.lvPackage.Location = new System.Drawing.Point(7, 20);
            this.lvPackage.Name = "lvPackage";
            this.lvPackage.Size = new System.Drawing.Size(272, 151);
            this.lvPackage.TabIndex = 0;
            this.lvPackage.UseCompatibleStateImageBehavior = false;
            this.lvPackage.SelectedIndexChanged += new System.EventHandler(this.lvPackage_SelectedIndexChanged);
            // 
            // gbConclusion
            // 
            this.gbConclusion.Controls.Add(this.btnDeleteConclusion);
            this.gbConclusion.Controls.Add(this.btnChangeConclusion);
            this.gbConclusion.Controls.Add(this.lvConclusion);
            this.gbConclusion.Controls.Add(this.btnAddConclusion);
            this.gbConclusion.Location = new System.Drawing.Point(303, 84);
            this.gbConclusion.Name = "gbConclusion";
            this.gbConclusion.Size = new System.Drawing.Size(285, 208);
            this.gbConclusion.TabIndex = 3;
            this.gbConclusion.TabStop = false;
            this.gbConclusion.Text = "Заключение";
            // 
            // btnDeleteConclusion
            // 
            this.btnDeleteConclusion.Location = new System.Drawing.Point(191, 179);
            this.btnDeleteConclusion.Name = "btnDeleteConclusion";
            this.btnDeleteConclusion.Size = new System.Drawing.Size(95, 23);
            this.btnDeleteConclusion.TabIndex = 6;
            this.btnDeleteConclusion.Text = "Удалить";
            this.btnDeleteConclusion.UseVisualStyleBackColor = true;
            // 
            // btnChangeConclusion
            // 
            this.btnChangeConclusion.Location = new System.Drawing.Point(96, 179);
            this.btnChangeConclusion.Name = "btnChangeConclusion";
            this.btnChangeConclusion.Size = new System.Drawing.Size(95, 23);
            this.btnChangeConclusion.TabIndex = 5;
            this.btnChangeConclusion.Text = "Изменить";
            this.btnChangeConclusion.UseVisualStyleBackColor = true;
            // 
            // lvConclusion
            // 
            this.lvConclusion.HideSelection = false;
            this.lvConclusion.Location = new System.Drawing.Point(6, 20);
            this.lvConclusion.Name = "lvConclusion";
            this.lvConclusion.Size = new System.Drawing.Size(272, 151);
            this.lvConclusion.TabIndex = 1;
            this.lvConclusion.UseCompatibleStateImageBehavior = false;
            this.lvConclusion.SelectedIndexChanged += new System.EventHandler(this.lvConclusion_SelectedIndexChanged);
            // 
            // btnAddConclusion
            // 
            this.btnAddConclusion.Location = new System.Drawing.Point(1, 179);
            this.btnAddConclusion.Name = "btnAddConclusion";
            this.btnAddConclusion.Size = new System.Drawing.Size(95, 23);
            this.btnAddConclusion.TabIndex = 4;
            this.btnAddConclusion.Text = "Добавить";
            this.btnAddConclusion.UseVisualStyleBackColor = true;
            this.btnAddConclusion.Click += new System.EventHandler(this.btnAddConclusion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Пояснение:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 325);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(576, 57);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(432, 398);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "ОК";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(513, 398);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "Отмена";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // ChangeRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 433);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbConclusion);
            this.Controls.Add(this.gbPackage);
            this.Controls.Add(this.lbRuleName);
            this.Controls.Add(this.textBox1);
            this.Name = "ChangeRule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeRule";
            this.gbPackage.ResumeLayout(false);
            this.gbConclusion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbRuleName;
        private System.Windows.Forms.GroupBox gbPackage;
        private System.Windows.Forms.Button btnDeletePackage;
        private System.Windows.Forms.Button btnChangePackage;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.ListView lvPackage;
        private System.Windows.Forms.GroupBox gbConclusion;
        private System.Windows.Forms.Button btnDeleteConclusion;
        private System.Windows.Forms.Button btnChangeConclusion;
        private System.Windows.Forms.ListView lvConclusion;
        private System.Windows.Forms.Button btnAddConclusion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}