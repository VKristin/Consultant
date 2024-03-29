﻿namespace Consultant
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
            this.chDomainValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteDomainValue = new System.Windows.Forms.Button();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
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
            this.lvDomainsValue.AllowDrop = true;
            this.lvDomainsValue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDomainValue});
            this.lvDomainsValue.FullRowSelect = true;
            this.lvDomainsValue.HideSelection = false;
            this.lvDomainsValue.Location = new System.Drawing.Point(11, 96);
            this.lvDomainsValue.Margin = new System.Windows.Forms.Padding(0);
            this.lvDomainsValue.MultiSelect = false;
            this.lvDomainsValue.Name = "lvDomainsValue";
            this.lvDomainsValue.Size = new System.Drawing.Size(480, 165);
            this.lvDomainsValue.TabIndex = 7;
            this.lvDomainsValue.UseCompatibleStateImageBehavior = false;
            this.lvDomainsValue.View = System.Windows.Forms.View.List;
            this.lvDomainsValue.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvDomainsValue_ItemDrag);
            this.lvDomainsValue.SelectedIndexChanged += new System.EventHandler(this.lvDomainsValue_SelectedIndexChanged);
            this.lvDomainsValue.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvDomainsValue_DragDrop);
            this.lvDomainsValue.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvDomainsValue_DragEnter);
            this.lvDomainsValue.DragOver += new System.Windows.Forms.DragEventHandler(this.lvDomainsValue_DragOver);
            this.lvDomainsValue.DragLeave += new System.EventHandler(this.lvDomainsValue_DragLeave);
            // 
            // chDomainValue
            // 
            this.chDomainValue.Text = "Значение домена";
            this.chDomainValue.Width = 461;
            // 
            // btnDeleteDomainValue
            // 
            this.btnDeleteDomainValue.Location = new System.Drawing.Point(9, 261);
            this.btnDeleteDomainValue.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteDomainValue.Name = "btnDeleteDomainValue";
            this.btnDeleteDomainValue.Size = new System.Drawing.Size(482, 23);
            this.btnDeleteDomainValue.TabIndex = 8;
            this.btnDeleteDomainValue.Text = "Удалить";
            this.btnDeleteDomainValue.UseVisualStyleBackColor = true;
            this.btnDeleteDomainValue.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(11, 323);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(317, 20);
            this.tbValue.TabIndex = 9;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(415, 323);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 18;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(334, 323);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Text = "Добавить";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(415, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 22);
            this.button2.TabIndex = 20;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(334, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 22);
            this.button3.TabIndex = 19;
            this.button3.Text = "ОК";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CreateDomain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 394);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.btnDeleteDomainValue);
            this.Controls.Add(this.lvDomainsValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbRuleName);
            this.Controls.Add(this.tbDomainName);
            this.KeyPreview = true;
            this.Name = "CreateDomain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateDomain";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CreateDomain_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRuleName;
        private System.Windows.Forms.TextBox tbDomainName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvDomainsValue;
        private System.Windows.Forms.Button btnDeleteDomainValue;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader chDomainValue;
    }
}