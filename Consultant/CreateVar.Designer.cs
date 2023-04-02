namespace Consultant
{
    partial class CreateVar
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
            this.tbVarName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDomain = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbRequested = new System.Windows.Forms.RadioButton();
            this.rbInferred = new System.Windows.Forms.RadioButton();
            this.rbRequestedInferred = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbQuestion = new System.Windows.Forms.RichTextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.btnSaveVar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRuleName
            // 
            this.lbRuleName.AutoSize = true;
            this.lbRuleName.Location = new System.Drawing.Point(12, 15);
            this.lbRuleName.Name = "lbRuleName";
            this.lbRuleName.Size = new System.Drawing.Size(97, 13);
            this.lbRuleName.TabIndex = 3;
            this.lbRuleName.Text = "Имя переменной:";
            // 
            // tbVarName
            // 
            this.tbVarName.Location = new System.Drawing.Point(11, 34);
            this.tbVarName.Name = "tbVarName";
            this.tbVarName.Size = new System.Drawing.Size(564, 20);
            this.tbVarName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Домен:";
            // 
            // cbDomain
            // 
            this.cbDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDomain.FormattingEnabled = true;
            this.cbDomain.Location = new System.Drawing.Point(11, 100);
            this.cbDomain.Name = "cbDomain";
            this.cbDomain.Size = new System.Drawing.Size(534, 21);
            this.cbDomain.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тип переменной:";
            // 
            // rbRequested
            // 
            this.rbRequested.AutoSize = true;
            this.rbRequested.Checked = true;
            this.rbRequested.Location = new System.Drawing.Point(15, 177);
            this.rbRequested.Name = "rbRequested";
            this.rbRequested.Size = new System.Drawing.Size(108, 17);
            this.rbRequested.TabIndex = 8;
            this.rbRequested.TabStop = true;
            this.rbRequested.Text = "Запрашиваемая";
            this.rbRequested.UseVisualStyleBackColor = true;
            // 
            // rbInferred
            // 
            this.rbInferred.AutoSize = true;
            this.rbInferred.Location = new System.Drawing.Point(15, 200);
            this.rbInferred.Name = "rbInferred";
            this.rbInferred.Size = new System.Drawing.Size(84, 17);
            this.rbInferred.TabIndex = 9;
            this.rbInferred.Text = "Выводимая";
            this.rbInferred.UseVisualStyleBackColor = true;
            this.rbInferred.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // rbRequestedInferred
            // 
            this.rbRequestedInferred.AutoSize = true;
            this.rbRequestedInferred.Location = new System.Drawing.Point(15, 223);
            this.rbRequestedInferred.Name = "rbRequestedInferred";
            this.rbRequestedInferred.Size = new System.Drawing.Size(163, 17);
            this.rbRequestedInferred.TabIndex = 10;
            this.rbRequestedInferred.Text = "Выводимо-запрашиваемая";
            this.rbRequestedInferred.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Текст запроса:";
            // 
            // rbQuestion
            // 
            this.rbQuestion.Location = new System.Drawing.Point(15, 279);
            this.rbQuestion.Name = "rbQuestion";
            this.rbQuestion.Size = new System.Drawing.Size(560, 96);
            this.rbQuestion.TabIndex = 12;
            this.rbQuestion.Text = "";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(500, 396);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 14;
            this.button8.Text = "Отмена";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnSaveVar
            // 
            this.btnSaveVar.Location = new System.Drawing.Point(419, 396);
            this.btnSaveVar.Name = "btnSaveVar";
            this.btnSaveVar.Size = new System.Drawing.Size(75, 23);
            this.btnSaveVar.TabIndex = 13;
            this.btnSaveVar.Text = "ОК";
            this.btnSaveVar.UseVisualStyleBackColor = true;
            this.btnSaveVar.Click += new System.EventHandler(this.btnSaveVar_Click);
            // 
            // CreateVar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 431);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnSaveVar);
            this.Controls.Add(this.rbQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbRequestedInferred);
            this.Controls.Add(this.rbInferred);
            this.Controls.Add(this.rbRequested);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbDomain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbRuleName);
            this.Controls.Add(this.tbVarName);
            this.Name = "CreateVar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateVar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRuleName;
        private System.Windows.Forms.TextBox tbVarName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDomain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbRequested;
        private System.Windows.Forms.RadioButton rbInferred;
        private System.Windows.Forms.RadioButton rbRequestedInferred;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rbQuestion;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnSaveVar;
    }
}