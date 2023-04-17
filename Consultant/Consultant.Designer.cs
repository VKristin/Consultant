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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDeleteRule = new System.Windows.Forms.Button();
            this.btnChangeRule = new System.Windows.Forms.Button();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.gbConclusion = new System.Windows.Forms.GroupBox();
            this.lvConclusion = new System.Windows.Forms.ListView();
            this.gbPackage = new System.Windows.Forms.GroupBox();
            this.lvPkg = new System.Windows.Forms.ListView();
            this.lvRules = new System.Windows.Forms.ListView();
            this.ruleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpVars = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeleteVar = new System.Windows.Forms.Button();
            this.btnChangeVar = new System.Windows.Forms.Button();
            this.btnVarAdd = new System.Windows.Forms.Button();
            this.gbVarValue = new System.Windows.Forms.GroupBox();
            this.lvValues = new System.Windows.Forms.ListView();
            this.gbQuestionText = new System.Windows.Forms.GroupBox();
            this.rtbQuestion = new System.Windows.Forms.RichTextBox();
            this.lvVars = new System.Windows.Forms.ListView();
            this.varName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.varType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.varDomain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpDomens = new System.Windows.Forms.TabPage();
            this.gbDomain = new System.Windows.Forms.GroupBox();
            this.lvDomains = new System.Windows.Forms.ListView();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.btnDomainDelete = new System.Windows.Forms.Button();
            this.btnDomainChange = new System.Windows.Forms.Button();
            this.btnDomainAdd = new System.Windows.Forms.Button();
            this.lvDomain = new System.Windows.Forms.ListView();
            this.DomainName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpRools.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbConclusion.SuspendLayout();
            this.gbPackage.SuspendLayout();
            this.tpVars.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbVarValue.SuspendLayout();
            this.gbQuestionText.SuspendLayout();
            this.tpDomens.SuspendLayout();
            this.gbDomain.SuspendLayout();
            this.gbEdit.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1055, 25);
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
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.новыйToolStripMenuItem.Text = "Новый";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // консультацяToolStripMenuItem
            // 
            this.консультацяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьКонсультациюToolStripMenuItem,
            this.показатьОбъяснениеToolStripMenuItem});
            this.консультацяToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.консультацяToolStripMenuItem.Name = "консультацяToolStripMenuItem";
            this.консультацяToolStripMenuItem.Size = new System.Drawing.Size(102, 21);
            this.консультацяToolStripMenuItem.Text = "Консультация";
            // 
            // начатьКонсультациюToolStripMenuItem
            // 
            this.начатьКонсультациюToolStripMenuItem.Name = "начатьКонсультациюToolStripMenuItem";
            this.начатьКонсультациюToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.начатьКонсультациюToolStripMenuItem.Text = "Начать консультацию";
            this.начатьКонсультациюToolStripMenuItem.Click += new System.EventHandler(this.начатьКонсультациюToolStripMenuItem_Click);
            // 
            // показатьОбъяснениеToolStripMenuItem
            // 
            this.показатьОбъяснениеToolStripMenuItem.Name = "показатьОбъяснениеToolStripMenuItem";
            this.показатьОбъяснениеToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.показатьОбъяснениеToolStripMenuItem.Text = "Показать объяснение";
            this.показатьОбъяснениеToolStripMenuItem.Click += new System.EventHandler(this.показатьОбъяснениеToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpRools);
            this.tabControl.Controls.Add(this.tpVars);
            this.tabControl.Controls.Add(this.tpDomens);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControl.Location = new System.Drawing.Point(0, 25);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1055, 642);
            this.tabControl.TabIndex = 1;
            this.tabControl.Visible = false;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tpRools
            // 
            this.tpRools.Controls.Add(this.groupBox4);
            this.tpRools.Controls.Add(this.gbConclusion);
            this.tpRools.Controls.Add(this.gbPackage);
            this.tpRools.Controls.Add(this.lvRules);
            this.tpRools.Location = new System.Drawing.Point(4, 22);
            this.tpRools.Name = "tpRools";
            this.tpRools.Padding = new System.Windows.Forms.Padding(3);
            this.tpRools.Size = new System.Drawing.Size(1047, 616);
            this.tpRools.TabIndex = 0;
            this.tpRools.Text = "Правила";
            this.tpRools.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDeleteRule);
            this.groupBox4.Controls.Add(this.btnChangeRule);
            this.groupBox4.Controls.Add(this.btnAddRule);
            this.groupBox4.Location = new System.Drawing.Point(648, 3);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox4.Size = new System.Drawing.Size(399, 108);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Редактирование";
            // 
            // btnDeleteRule
            // 
            this.btnDeleteRule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteRule.Location = new System.Drawing.Point(10, 80);
            this.btnDeleteRule.Name = "btnDeleteRule";
            this.btnDeleteRule.Size = new System.Drawing.Size(379, 24);
            this.btnDeleteRule.TabIndex = 2;
            this.btnDeleteRule.Text = "Удалить";
            this.btnDeleteRule.UseVisualStyleBackColor = true;
            this.btnDeleteRule.Click += new System.EventHandler(this.btnDeleteRule_Click);
            // 
            // btnChangeRule
            // 
            this.btnChangeRule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangeRule.Location = new System.Drawing.Point(10, 51);
            this.btnChangeRule.Name = "btnChangeRule";
            this.btnChangeRule.Size = new System.Drawing.Size(379, 29);
            this.btnChangeRule.TabIndex = 1;
            this.btnChangeRule.Text = "Изменить";
            this.btnChangeRule.UseVisualStyleBackColor = true;
            this.btnChangeRule.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnAddRule
            // 
            this.btnAddRule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddRule.Location = new System.Drawing.Point(10, 23);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(379, 28);
            this.btnAddRule.TabIndex = 0;
            this.btnAddRule.Text = "Добавить";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.button6_Click);
            // 
            // gbConclusion
            // 
            this.gbConclusion.Controls.Add(this.lvConclusion);
            this.gbConclusion.Location = new System.Drawing.Point(648, 358);
            this.gbConclusion.Name = "gbConclusion";
            this.gbConclusion.Size = new System.Drawing.Size(396, 250);
            this.gbConclusion.TabIndex = 8;
            this.gbConclusion.TabStop = false;
            this.gbConclusion.Text = "Заключение";
            // 
            // lvConclusion
            // 
            this.lvConclusion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvConclusion.FullRowSelect = true;
            this.lvConclusion.HideSelection = false;
            this.lvConclusion.Location = new System.Drawing.Point(3, 16);
            this.lvConclusion.Name = "lvConclusion";
            this.lvConclusion.Size = new System.Drawing.Size(390, 231);
            this.lvConclusion.TabIndex = 0;
            this.lvConclusion.UseCompatibleStateImageBehavior = false;
            this.lvConclusion.View = System.Windows.Forms.View.List;
            // 
            // gbPackage
            // 
            this.gbPackage.Controls.Add(this.lvPkg);
            this.gbPackage.Location = new System.Drawing.Point(648, 116);
            this.gbPackage.Name = "gbPackage";
            this.gbPackage.Size = new System.Drawing.Size(399, 236);
            this.gbPackage.TabIndex = 7;
            this.gbPackage.TabStop = false;
            this.gbPackage.Text = "Посылка";
            // 
            // lvPkg
            // 
            this.lvPkg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPkg.FullRowSelect = true;
            this.lvPkg.HideSelection = false;
            this.lvPkg.Location = new System.Drawing.Point(3, 16);
            this.lvPkg.Name = "lvPkg";
            this.lvPkg.Size = new System.Drawing.Size(393, 217);
            this.lvPkg.TabIndex = 0;
            this.lvPkg.UseCompatibleStateImageBehavior = false;
            this.lvPkg.View = System.Windows.Forms.View.List;
            // 
            // lvRules
            // 
            this.lvRules.AllowDrop = true;
            this.lvRules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ruleName,
            this.Description});
            this.lvRules.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lvRules.FullRowSelect = true;
            this.lvRules.HideSelection = false;
            this.lvRules.Location = new System.Drawing.Point(3, 3);
            this.lvRules.MultiSelect = false;
            this.lvRules.Name = "lvRules";
            this.lvRules.Size = new System.Drawing.Size(632, 610);
            this.lvRules.TabIndex = 0;
            this.lvRules.UseCompatibleStateImageBehavior = false;
            this.lvRules.View = System.Windows.Forms.View.Details;
            this.lvRules.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvDomainsValue_ItemDrag);
            this.lvRules.SelectedIndexChanged += new System.EventHandler(this.lvRules_SelectedIndexChanged);
            this.lvRules.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvDomainsValue_DragDrop);
            this.lvRules.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvDomainsValue_DragEnter);
            this.lvRules.DragOver += new System.Windows.Forms.DragEventHandler(this.lvDomainsValue_DragOver);
            this.lvRules.DragLeave += new System.EventHandler(this.lvDomainsValue_DragLeave);
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
            this.tpVars.Controls.Add(this.groupBox3);
            this.tpVars.Controls.Add(this.gbVarValue);
            this.tpVars.Controls.Add(this.gbQuestionText);
            this.tpVars.Controls.Add(this.lvVars);
            this.tpVars.Location = new System.Drawing.Point(4, 22);
            this.tpVars.Name = "tpVars";
            this.tpVars.Padding = new System.Windows.Forms.Padding(3);
            this.tpVars.Size = new System.Drawing.Size(1047, 616);
            this.tpVars.TabIndex = 1;
            this.tpVars.Text = "Переменные";
            this.tpVars.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeleteVar);
            this.groupBox3.Controls.Add(this.btnChangeVar);
            this.groupBox3.Controls.Add(this.btnVarAdd);
            this.groupBox3.Location = new System.Drawing.Point(649, 3);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox3.Size = new System.Drawing.Size(398, 108);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Редактирование";
            // 
            // btnDeleteVar
            // 
            this.btnDeleteVar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteVar.Location = new System.Drawing.Point(10, 79);
            this.btnDeleteVar.Name = "btnDeleteVar";
            this.btnDeleteVar.Size = new System.Drawing.Size(378, 25);
            this.btnDeleteVar.TabIndex = 2;
            this.btnDeleteVar.Text = "Удалить";
            this.btnDeleteVar.UseVisualStyleBackColor = true;
            this.btnDeleteVar.Click += new System.EventHandler(this.btnDeleteVar_Click);
            // 
            // btnChangeVar
            // 
            this.btnChangeVar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangeVar.Location = new System.Drawing.Point(10, 50);
            this.btnChangeVar.Name = "btnChangeVar";
            this.btnChangeVar.Size = new System.Drawing.Size(378, 29);
            this.btnChangeVar.TabIndex = 1;
            this.btnChangeVar.Text = "Изменить";
            this.btnChangeVar.UseVisualStyleBackColor = true;
            this.btnChangeVar.Click += new System.EventHandler(this.btnChangeVar_Click);
            // 
            // btnVarAdd
            // 
            this.btnVarAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVarAdd.Location = new System.Drawing.Point(10, 23);
            this.btnVarAdd.Name = "btnVarAdd";
            this.btnVarAdd.Size = new System.Drawing.Size(378, 27);
            this.btnVarAdd.TabIndex = 0;
            this.btnVarAdd.Text = "Добавить";
            this.btnVarAdd.UseVisualStyleBackColor = true;
            this.btnVarAdd.Click += new System.EventHandler(this.btnVarAdd_Click);
            // 
            // gbVarValue
            // 
            this.gbVarValue.Controls.Add(this.lvValues);
            this.gbVarValue.Location = new System.Drawing.Point(649, 350);
            this.gbVarValue.Name = "gbVarValue";
            this.gbVarValue.Size = new System.Drawing.Size(395, 256);
            this.gbVarValue.TabIndex = 6;
            this.gbVarValue.TabStop = false;
            this.gbVarValue.Text = "Значение перменной";
            // 
            // lvValues
            // 
            this.lvValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvValues.FullRowSelect = true;
            this.lvValues.HideSelection = false;
            this.lvValues.Location = new System.Drawing.Point(3, 16);
            this.lvValues.Name = "lvValues";
            this.lvValues.Size = new System.Drawing.Size(389, 237);
            this.lvValues.TabIndex = 0;
            this.lvValues.UseCompatibleStateImageBehavior = false;
            this.lvValues.View = System.Windows.Forms.View.List;
            // 
            // gbQuestionText
            // 
            this.gbQuestionText.Controls.Add(this.rtbQuestion);
            this.gbQuestionText.Location = new System.Drawing.Point(649, 117);
            this.gbQuestionText.Name = "gbQuestionText";
            this.gbQuestionText.Size = new System.Drawing.Size(398, 227);
            this.gbQuestionText.TabIndex = 5;
            this.gbQuestionText.TabStop = false;
            this.gbQuestionText.Text = "Текст вопроса";
            // 
            // rtbQuestion
            // 
            this.rtbQuestion.Enabled = false;
            this.rtbQuestion.Location = new System.Drawing.Point(0, 22);
            this.rtbQuestion.Name = "rtbQuestion";
            this.rtbQuestion.Size = new System.Drawing.Size(409, 199);
            this.rtbQuestion.TabIndex = 0;
            this.rtbQuestion.Text = "";
            // 
            // lvVars
            // 
            this.lvVars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.varName,
            this.varType,
            this.varDomain});
            this.lvVars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lvVars.FullRowSelect = true;
            this.lvVars.HideSelection = false;
            this.lvVars.Location = new System.Drawing.Point(3, 3);
            this.lvVars.MultiSelect = false;
            this.lvVars.Name = "lvVars";
            this.lvVars.Size = new System.Drawing.Size(632, 648);
            this.lvVars.TabIndex = 0;
            this.lvVars.UseCompatibleStateImageBehavior = false;
            this.lvVars.View = System.Windows.Forms.View.Details;
            this.lvVars.SelectedIndexChanged += new System.EventHandler(this.lvVars_SelectedIndexChanged);
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
            this.tpDomens.Controls.Add(this.gbDomain);
            this.tpDomens.Controls.Add(this.gbEdit);
            this.tpDomens.Controls.Add(this.lvDomain);
            this.tpDomens.Location = new System.Drawing.Point(4, 22);
            this.tpDomens.Name = "tpDomens";
            this.tpDomens.Size = new System.Drawing.Size(1047, 616);
            this.tpDomens.TabIndex = 2;
            this.tpDomens.Text = "Домены";
            this.tpDomens.UseVisualStyleBackColor = true;
            // 
            // gbDomain
            // 
            this.gbDomain.Controls.Add(this.lvDomains);
            this.gbDomain.Location = new System.Drawing.Point(647, 116);
            this.gbDomain.Name = "gbDomain";
            this.gbDomain.Size = new System.Drawing.Size(401, 533);
            this.gbDomain.TabIndex = 6;
            this.gbDomain.TabStop = false;
            this.gbDomain.Text = "Значение домена";
            // 
            // lvDomains
            // 
            this.lvDomains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDomains.FullRowSelect = true;
            this.lvDomains.HideSelection = false;
            this.lvDomains.Location = new System.Drawing.Point(3, 16);
            this.lvDomains.Name = "lvDomains";
            this.lvDomains.Size = new System.Drawing.Size(395, 514);
            this.lvDomains.TabIndex = 0;
            this.lvDomains.UseCompatibleStateImageBehavior = false;
            this.lvDomains.View = System.Windows.Forms.View.List;
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.btnDomainDelete);
            this.gbEdit.Controls.Add(this.btnDomainChange);
            this.gbEdit.Controls.Add(this.btnDomainAdd);
            this.gbEdit.Location = new System.Drawing.Point(645, 3);
            this.gbEdit.Margin = new System.Windows.Forms.Padding(10);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Padding = new System.Windows.Forms.Padding(10);
            this.gbEdit.Size = new System.Drawing.Size(402, 108);
            this.gbEdit.TabIndex = 2;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Редактирование";
            // 
            // btnDomainDelete
            // 
            this.btnDomainDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDomainDelete.Location = new System.Drawing.Point(10, 75);
            this.btnDomainDelete.Name = "btnDomainDelete";
            this.btnDomainDelete.Size = new System.Drawing.Size(382, 28);
            this.btnDomainDelete.TabIndex = 2;
            this.btnDomainDelete.Text = "Удалить";
            this.btnDomainDelete.UseVisualStyleBackColor = true;
            this.btnDomainDelete.Click += new System.EventHandler(this.btnDomainDelete_Click);
            // 
            // btnDomainChange
            // 
            this.btnDomainChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDomainChange.Location = new System.Drawing.Point(10, 51);
            this.btnDomainChange.Name = "btnDomainChange";
            this.btnDomainChange.Size = new System.Drawing.Size(382, 24);
            this.btnDomainChange.TabIndex = 1;
            this.btnDomainChange.Text = "Изменить";
            this.btnDomainChange.UseVisualStyleBackColor = true;
            this.btnDomainChange.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDomainAdd
            // 
            this.btnDomainAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDomainAdd.Location = new System.Drawing.Point(10, 23);
            this.btnDomainAdd.Name = "btnDomainAdd";
            this.btnDomainAdd.Size = new System.Drawing.Size(382, 28);
            this.btnDomainAdd.TabIndex = 0;
            this.btnDomainAdd.Text = "Добавить";
            this.btnDomainAdd.UseVisualStyleBackColor = true;
            this.btnDomainAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvDomain
            // 
            this.lvDomain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DomainName});
            this.lvDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lvDomain.FullRowSelect = true;
            this.lvDomain.HideSelection = false;
            this.lvDomain.Location = new System.Drawing.Point(0, 3);
            this.lvDomain.MultiSelect = false;
            this.lvDomain.Name = "lvDomain";
            this.lvDomain.Size = new System.Drawing.Size(632, 651);
            this.lvDomain.TabIndex = 0;
            this.lvDomain.UseCompatibleStateImageBehavior = false;
            this.lvDomain.View = System.Windows.Forms.View.Details;
            this.lvDomain.SelectedIndexChanged += new System.EventHandler(this.lvDomain_SelectedIndexChanged);
            // 
            // DomainName
            // 
            this.DomainName.Text = "Имя";
            this.DomainName.Width = 452;
            // 
            // Consultant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 667);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Consultant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultant";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Consultant_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tpRools.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.gbConclusion.ResumeLayout(false);
            this.gbPackage.ResumeLayout(false);
            this.tpVars.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.gbVarValue.ResumeLayout(false);
            this.gbQuestionText.ResumeLayout(false);
            this.tpDomens.ResumeLayout(false);
            this.gbDomain.ResumeLayout(false);
            this.gbEdit.ResumeLayout(false);
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
        private System.Windows.Forms.ListView lvRules;
        private System.Windows.Forms.ColumnHeader ruleName;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ListView lvVars;
        private System.Windows.Forms.ColumnHeader varName;
        private System.Windows.Forms.ColumnHeader varType;
        private System.Windows.Forms.ColumnHeader varDomain;
        private System.Windows.Forms.ListView lvDomain;
        private System.Windows.Forms.ColumnHeader DomainName;
        private System.Windows.Forms.GroupBox gbConclusion;
        private System.Windows.Forms.ListView lvConclusion;
        private System.Windows.Forms.GroupBox gbPackage;
        private System.Windows.Forms.ListView lvPkg;
        private System.Windows.Forms.GroupBox gbVarValue;
        private System.Windows.Forms.ListView lvValues;
        private System.Windows.Forms.GroupBox gbQuestionText;
        private System.Windows.Forms.GroupBox gbDomain;
        private System.Windows.Forms.ListView lvDomains;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDeleteRule;
        private System.Windows.Forms.Button btnChangeRule;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDeleteVar;
        private System.Windows.Forms.Button btnChangeVar;
        private System.Windows.Forms.Button btnVarAdd;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.Button btnDomainDelete;
        private System.Windows.Forms.Button btnDomainChange;
        private System.Windows.Forms.Button btnDomainAdd;
        private System.Windows.Forms.RichTextBox rtbQuestion;
    }
}

