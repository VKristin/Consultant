namespace Consultant
{
    partial class CreateDomen
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
            this.lbDomainName = new System.Windows.Forms.Label();
            this.tbDomainName = new System.Windows.Forms.TextBox();
            this.lbDomainValue = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDomainName
            // 
            this.lbDomainName.AutoSize = true;
            this.lbDomainName.Location = new System.Drawing.Point(9, 15);
            this.lbDomainName.Name = "lbDomainName";
            this.lbDomainName.Size = new System.Drawing.Size(73, 13);
            this.lbDomainName.TabIndex = 0;
            this.lbDomainName.Text = "Имя домена:";
            // 
            // tbDomainName
            // 
            this.tbDomainName.Location = new System.Drawing.Point(12, 40);
            this.tbDomainName.Name = "tbDomainName";
            this.tbDomainName.Size = new System.Drawing.Size(428, 20);
            this.tbDomainName.TabIndex = 1;
            // 
            // lbDomainValue
            // 
            this.lbDomainValue.AutoSize = true;
            this.lbDomainValue.Location = new System.Drawing.Point(12, 84);
            this.lbDomainValue.Name = "lbDomainValue";
            this.lbDomainValue.Size = new System.Drawing.Size(166, 13);
            this.lbDomainValue.TabIndex = 2;
            this.lbDomainValue.Text = "Допустимые значения домена:";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 110);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(425, 115);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 224);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(425, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(12, 275);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(225, 20);
            this.tbValue.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(243, 273);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(341, 273);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // CreateDomen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 317);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbDomainValue);
            this.Controls.Add(this.tbDomainName);
            this.Controls.Add(this.lbDomainName);
            this.Name = "CreateDomen";
            this.Text = "Создание домена";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDomainName;
        private System.Windows.Forms.TextBox tbDomainName;
        private System.Windows.Forms.Label lbDomainValue;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
    }
}