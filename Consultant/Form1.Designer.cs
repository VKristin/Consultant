namespace Consultant
{
    partial class Consultant
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.консультацяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьКонсультациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьОбъяснениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpRools = new System.Windows.Forms.TabPage();
            this.lvRules = new System.Windows.Forms.ListView();
            this.ruleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpVars = new System.Windows.Forms.TabPage();
            this.lvVars = new System.Windows.Forms.ListView();
            this.varName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.varType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.varDomain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpDomens = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.lvConclusion = new System.Windows.Forms.ListView();
            this.gbConclusion = new System.Windows.Forms.GroupBox();
            this.lvPkg = new System.Windows.Forms.ListView();
            this.gbVarOrDomain = new System.Windows.Forms.GroupBox();
            this.lvVarOrDomain = new System.Windows.Forms.ListView();
            this.gbPkg = new System.Windows.Forms.GroupBox();
            this.DomainName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDomain = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpRools.SuspendLayout();
            this.tpVars.SuspendLayout();
            this.tpDomens.SuspendLayout();
            this.gbEdit.SuspendLayout();
            this.gbConclusion.SuspendLayout();
            this.gbVarOrDomain.SuspendLayout();
            this.gbPkg.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.консультацяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1188, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.новыйToolStripMenuItem.Text = "Новый";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // консультацяToolStripMenuItem
            // 
            this.консультацяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьКонсультациюToolStripMenuItem,
            this.показатьОбъяснениеToolStripMenuItem});
            this.консультацяToolStripMenuItem.Name = "консультацяToolStripMenuItem";
            this.консультацяToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.консультацяToolStripMenuItem.Text = "Консультация";
            // 
            // начатьКонсультациюToolStripMenuItem
            // 
            this.начатьКонсультациюToolStripMenuItem.Name = "начатьКонсультациюToolStripMenuItem";
            this.начатьКонсультациюToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.начатьКонсультациюToolStripMenuItem.Text = "Начать консультацию";
            this.начатьКонсультациюToolStripMenuItem.Click += new System.EventHandler(this.начатьКонсультациюToolStripMenuItem_Click);
            // 
            // показатьОбъяснениеToolStripMenuItem
            // 
            this.показатьОбъяснениеToolStripMenuItem.Name = "показатьОбъяснениеToolStripMenuItem";
            this.показатьОбъяснениеToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.показатьОбъяснениеToolStripMenuItem.Text = "Показать объяснение";
            this.показатьОбъяснениеToolStripMenuItem.Click += new System.EventHandler(this.показатьОбъяснениеToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpRools);
            this.tabControl.Controls.Add(this.tpVars);
            this.tabControl.Controls.Add(this.tpDomens);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(753, 680);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tpRools
            // 
            this.tpRools.Controls.Add(this.lvRules);
            this.tpRools.Location = new System.Drawing.Point(4, 22);
            this.tpRools.Name = "tpRools";
            this.tpRools.Padding = new System.Windows.Forms.Padding(3);
            this.tpRools.Size = new System.Drawing.Size(745, 654);
            this.tpRools.TabIndex = 0;
            this.tpRools.Text = "Правила";
            this.tpRools.UseVisualStyleBackColor = true;
            // 
            // lvRules
            // 
            this.lvRules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ruleName,
            this.Description});
            this.lvRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRules.HideSelection = false;
            this.lvRules.Location = new System.Drawing.Point(3, 3);
            this.lvRules.Name = "lvRules";
            this.lvRules.Size = new System.Drawing.Size(739, 648);
            this.lvRules.TabIndex = 0;
            this.lvRules.UseCompatibleStateImageBehavior = false;
            this.lvRules.View = System.Windows.Forms.View.Details;
            // 
            // ruleName
            // 
            this.ruleName.Text = "Имя";
            this.ruleName.Width = 325;
            // 
            // Description
            // 
            this.Description.Text = "Описание";
            this.Description.Width = 311;
            // 
            // tpVars
            // 
            this.tpVars.Controls.Add(this.lvVars);
            this.tpVars.Location = new System.Drawing.Point(4, 22);
            this.tpVars.Name = "tpVars";
            this.tpVars.Padding = new System.Windows.Forms.Padding(3);
            this.tpVars.Size = new System.Drawing.Size(745, 654);
            this.tpVars.TabIndex = 1;
            this.tpVars.Text = "Переменные";
            this.tpVars.UseVisualStyleBackColor = true;
            // 
            // lvVars
            // 
            this.lvVars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.varName,
            this.varType,
            this.varDomain});
            this.lvVars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvVars.HideSelection = false;
            this.lvVars.Location = new System.Drawing.Point(3, 3);
            this.lvVars.Name = "lvVars";
            this.lvVars.Size = new System.Drawing.Size(739, 648);
            this.lvVars.TabIndex = 0;
            this.lvVars.UseCompatibleStateImageBehavior = false;
            this.lvVars.View = System.Windows.Forms.View.Details;
            // 
            // varName
            // 
            this.varName.Text = "Имя";
            this.varName.Width = 236;
            // 
            // varType
            // 
            this.varType.Text = "Тип";
            this.varType.Width = 199;
            // 
            // varDomain
            // 
            this.varDomain.Text = "Домен";
            this.varDomain.Width = 287;
            // 
            // tpDomens
            // 
            this.tpDomens.Controls.Add(this.lvDomain);
            this.tpDomens.Location = new System.Drawing.Point(4, 22);
            this.tpDomens.Name = "tpDomens";
            this.tpDomens.Size = new System.Drawing.Size(745, 654);
            this.tpDomens.TabIndex = 2;
            this.tpDomens.Text = "Домены";
            this.tpDomens.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Location = new System.Drawing.Point(10, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(389, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdit.Location = new System.Drawing.Point(10, 46);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(389, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.Location = new System.Drawing.Point(10, 69);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(389, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.btnDelete);
            this.gbEdit.Controls.Add(this.btnEdit);
            this.gbEdit.Controls.Add(this.btnAdd);
            this.gbEdit.Location = new System.Drawing.Point(766, 46);
            this.gbEdit.Margin = new System.Windows.Forms.Padding(10);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Padding = new System.Windows.Forms.Padding(10);
            this.gbEdit.Size = new System.Drawing.Size(409, 108);
            this.gbEdit.TabIndex = 2;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Редактирование";
            // 
            // lvConclusion
            // 
            this.lvConclusion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvConclusion.HideSelection = false;
            this.lvConclusion.Location = new System.Drawing.Point(3, 16);
            this.lvConclusion.Name = "lvConclusion";
            this.lvConclusion.Size = new System.Drawing.Size(400, 281);
            this.lvConclusion.TabIndex = 0;
            this.lvConclusion.UseCompatibleStateImageBehavior = false;
            // 
            // gbConclusion
            // 
            this.gbConclusion.Controls.Add(this.lvConclusion);
            this.gbConclusion.Location = new System.Drawing.Point(769, 400);
            this.gbConclusion.Name = "gbConclusion";
            this.gbConclusion.Size = new System.Drawing.Size(406, 300);
            this.gbConclusion.TabIndex = 4;
            this.gbConclusion.TabStop = false;
            this.gbConclusion.Text = "Заключение";
            // 
            // lvPkg
            // 
            this.lvPkg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPkg.HideSelection = false;
            this.lvPkg.Location = new System.Drawing.Point(3, 16);
            this.lvPkg.Name = "lvPkg";
            this.lvPkg.Size = new System.Drawing.Size(403, 208);
            this.lvPkg.TabIndex = 0;
            this.lvPkg.UseCompatibleStateImageBehavior = false;
            // 
            // gbVarOrDomain
            // 
            this.gbVarOrDomain.Controls.Add(this.lvVarOrDomain);
            this.gbVarOrDomain.Location = new System.Drawing.Point(767, 167);
            this.gbVarOrDomain.Name = "gbVarOrDomain";
            this.gbVarOrDomain.Size = new System.Drawing.Size(408, 533);
            this.gbVarOrDomain.TabIndex = 5;
            this.gbVarOrDomain.TabStop = false;
            this.gbVarOrDomain.Text = "groupBox1";
            // 
            // lvVarOrDomain
            // 
            this.lvVarOrDomain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvVarOrDomain.HideSelection = false;
            this.lvVarOrDomain.Location = new System.Drawing.Point(3, 16);
            this.lvVarOrDomain.Name = "lvVarOrDomain";
            this.lvVarOrDomain.Size = new System.Drawing.Size(402, 514);
            this.lvVarOrDomain.TabIndex = 0;
            this.lvVarOrDomain.UseCompatibleStateImageBehavior = false;
            // 
            // gbPkg
            // 
            this.gbPkg.Controls.Add(this.lvPkg);
            this.gbPkg.Location = new System.Drawing.Point(766, 167);
            this.gbPkg.Name = "gbPkg";
            this.gbPkg.Size = new System.Drawing.Size(409, 227);
            this.gbPkg.TabIndex = 3;
            this.gbPkg.TabStop = false;
            this.gbPkg.Text = "Посылка";
            // 
            // DomainName
            // 
            this.DomainName.Text = "Имя";
            this.DomainName.Width = 300;
            // 
            // lvDomain
            // 
            this.lvDomain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DomainName});
            this.lvDomain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDomain.HideSelection = false;
            this.lvDomain.Location = new System.Drawing.Point(0, 0);
            this.lvDomain.Name = "lvDomain";
            this.lvDomain.Size = new System.Drawing.Size(745, 654);
            this.lvDomain.TabIndex = 0;
            this.lvDomain.UseCompatibleStateImageBehavior = false;
            this.lvDomain.View = System.Windows.Forms.View.Details;
            // 
            // Consultant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 704);
            this.Controls.Add(this.gbVarOrDomain);
            this.Controls.Add(this.gbConclusion);
            this.Controls.Add(this.gbPkg);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Consultant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultant";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tpRools.ResumeLayout(false);
            this.tpVars.ResumeLayout(false);
            this.tpDomens.ResumeLayout(false);
            this.gbEdit.ResumeLayout(false);
            this.gbConclusion.ResumeLayout(false);
            this.gbVarOrDomain.ResumeLayout(false);
            this.gbPkg.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem консультацяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьКонсультациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьОбъяснениеToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpRools;
        private System.Windows.Forms.TabPage tpVars;
        private System.Windows.Forms.TabPage tpDomens;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.ListView lvConclusion;
        private System.Windows.Forms.GroupBox gbConclusion;
        private System.Windows.Forms.GroupBox gbVarOrDomain;
        private System.Windows.Forms.ListView lvVarOrDomain;
        private System.Windows.Forms.ListView lvPkg;
        private System.Windows.Forms.GroupBox gbPkg;
        private System.Windows.Forms.ListView lvRules;
        private System.Windows.Forms.ColumnHeader ruleName;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ListView lvVars;
        private System.Windows.Forms.ColumnHeader varName;
        private System.Windows.Forms.ColumnHeader varType;
        private System.Windows.Forms.ColumnHeader varDomain;
        private System.Windows.Forms.ListView lvDomain;
        private System.Windows.Forms.ColumnHeader DomainName;
    }
}

