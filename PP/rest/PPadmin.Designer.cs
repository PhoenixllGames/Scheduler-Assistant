namespace PP
{
    partial class PPadmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PPadmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lessonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрПредметовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьПредметыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeTeachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTeachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBusinessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherBusinessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.парыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свободныеКабинетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedulingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSchedulingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoScheduleAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoScheduleOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualSchedulingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.revisionToolStripMenuItem,
            this.schedulingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupsToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.lessonsToolStripMenuItem,
            this.teachersToolStripMenuItem,
            this.settingsToolStripMenuItem1,
            this.usersToolStripMenuItem1,
            this.accountToolStripMenuItem,
            this.aboutProgramToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menuToolStripMenuItem.Text = "Меню";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seeGroupsToolStripMenuItem,
            this.changeGroupsToolStripMenuItem});
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.groupsToolStripMenuItem.Text = "Группы";
            this.groupsToolStripMenuItem.Click += new System.EventHandler(this.группыToolStripMenuItem_Click);
            // 
            // seeGroupsToolStripMenuItem
            // 
            this.seeGroupsToolStripMenuItem.Name = "seeGroupsToolStripMenuItem";
            this.seeGroupsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.seeGroupsToolStripMenuItem.Text = "Просмотр групп";
            this.seeGroupsToolStripMenuItem.Click += new System.EventHandler(this.seeGroupsToolStripMenuItem_Click);
            // 
            // changeGroupsToolStripMenuItem
            // 
            this.changeGroupsToolStripMenuItem.Name = "changeGroupsToolStripMenuItem";
            this.changeGroupsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.changeGroupsToolStripMenuItem.Text = "Управление группами";
            this.changeGroupsToolStripMenuItem.Click += new System.EventHandler(this.changeGroupsToolStripMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seeRoomsToolStripMenuItem,
            this.changeRoomsToolStripMenuItem});
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.roomsToolStripMenuItem.Text = "Классы";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.классыToolStripMenuItem_Click);
            // 
            // seeRoomsToolStripMenuItem
            // 
            this.seeRoomsToolStripMenuItem.Name = "seeRoomsToolStripMenuItem";
            this.seeRoomsToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.seeRoomsToolStripMenuItem.Text = "Просмотр аудиторий";
            this.seeRoomsToolStripMenuItem.Click += new System.EventHandler(this.seeRoomsToolStripMenuItem_Click);
            // 
            // changeRoomsToolStripMenuItem
            // 
            this.changeRoomsToolStripMenuItem.Name = "changeRoomsToolStripMenuItem";
            this.changeRoomsToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.changeRoomsToolStripMenuItem.Text = "Управление аудиториями";
            this.changeRoomsToolStripMenuItem.Click += new System.EventHandler(this.changeRoomsToolStripMenuItem_Click);
            // 
            // lessonsToolStripMenuItem
            // 
            this.lessonsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрПредметовToolStripMenuItem,
            this.изменитьПредметыToolStripMenuItem});
            this.lessonsToolStripMenuItem.Name = "lessonsToolStripMenuItem";
            this.lessonsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.lessonsToolStripMenuItem.Text = "Предметы";
            this.lessonsToolStripMenuItem.Click += new System.EventHandler(this.предметыToolStripMenuItem_Click);
            // 
            // просмотрПредметовToolStripMenuItem
            // 
            this.просмотрПредметовToolStripMenuItem.Name = "просмотрПредметовToolStripMenuItem";
            this.просмотрПредметовToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.просмотрПредметовToolStripMenuItem.Text = "Просмотр предметов";
            this.просмотрПредметовToolStripMenuItem.Click += new System.EventHandler(this.просмотрПредметовToolStripMenuItem_Click);
            // 
            // изменитьПредметыToolStripMenuItem
            // 
            this.изменитьПредметыToolStripMenuItem.Name = "изменитьПредметыToolStripMenuItem";
            this.изменитьПредметыToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.изменитьПредметыToolStripMenuItem.Text = "Управление предметами";
            this.изменитьПредметыToolStripMenuItem.Click += new System.EventHandler(this.изменитьПредметыToolStripMenuItem_Click);
            // 
            // teachersToolStripMenuItem
            // 
            this.teachersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seeTeachersToolStripMenuItem,
            this.changeTeachersToolStripMenuItem});
            this.teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            this.teachersToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.teachersToolStripMenuItem.Text = "Преподаватели";
            // 
            // seeTeachersToolStripMenuItem
            // 
            this.seeTeachersToolStripMenuItem.Name = "seeTeachersToolStripMenuItem";
            this.seeTeachersToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.seeTeachersToolStripMenuItem.Text = "Просмотр преподавателей";
            this.seeTeachersToolStripMenuItem.Click += new System.EventHandler(this.seeTeachersToolStripMenuItem_Click);
            // 
            // changeTeachersToolStripMenuItem
            // 
            this.changeTeachersToolStripMenuItem.Name = "changeTeachersToolStripMenuItem";
            this.changeTeachersToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.changeTeachersToolStripMenuItem.Text = "Управление преподавателями";
            this.changeTeachersToolStripMenuItem.Click += new System.EventHandler(this.changeTeachersToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.settingsToolStripMenuItem1.Text = "Настройки";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.настройкиToolStripMenuItem1_Click);
            // 
            // usersToolStripMenuItem1
            // 
            this.usersToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUserstoolStripMenuItem});
            this.usersToolStripMenuItem1.Name = "usersToolStripMenuItem1";
            this.usersToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.usersToolStripMenuItem1.Text = "Пользователи";
            this.usersToolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // changeUserstoolStripMenuItem
            // 
            this.changeUserstoolStripMenuItem.Name = "changeUserstoolStripMenuItem";
            this.changeUserstoolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.changeUserstoolStripMenuItem.Text = "Управление пользавателями";
            this.changeUserstoolStripMenuItem.Click += new System.EventHandler(this.changeUsersToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeAccountToolStripMenuItem,
            this.exitAccountToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.accountToolStripMenuItem.Text = "Аккаунт";
            // 
            // changeAccountToolStripMenuItem
            // 
            this.changeAccountToolStripMenuItem.Name = "changeAccountToolStripMenuItem";
            this.changeAccountToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.changeAccountToolStripMenuItem.Text = "Управление аккаунтом";
            this.changeAccountToolStripMenuItem.Click += new System.EventHandler(this.changAccountToolStripMenuItem2_Click);
            // 
            // exitAccountToolStripMenuItem
            // 
            this.exitAccountToolStripMenuItem.Name = "exitAccountToolStripMenuItem";
            this.exitAccountToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.exitAccountToolStripMenuItem.Text = "Выйти из аккаунта";
            this.exitAccountToolStripMenuItem.Click += new System.EventHandler(this.exitAccountToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aboutProgramToolStripMenuItem.Text = "О программе";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // revisionToolStripMenuItem
            // 
            this.revisionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisticsToolStripMenuItem,
            this.currentToolStripMenuItem,
            this.scheduleToolStripMenuItem});
            this.revisionToolStripMenuItem.Name = "revisionToolStripMenuItem";
            this.revisionToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.revisionToolStripMenuItem.Text = "Просмотр";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupStatisticsToolStripMenuItem,
            this.teachersStatisticsToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statisticsToolStripMenuItem.Text = "Статистика";
            // 
            // groupStatisticsToolStripMenuItem
            // 
            this.groupStatisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupBusinessToolStripMenuItem});
            this.groupStatisticsToolStripMenuItem.Name = "groupStatisticsToolStripMenuItem";
            this.groupStatisticsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.groupStatisticsToolStripMenuItem.Text = "Учеников";
            // 
            // groupBusinessToolStripMenuItem
            // 
            this.groupBusinessToolStripMenuItem.Name = "groupBusinessToolStripMenuItem";
            this.groupBusinessToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.groupBusinessToolStripMenuItem.Text = "Зайнятость";
            this.groupBusinessToolStripMenuItem.Click += new System.EventHandler(this.groupBusinessToolStripMenuItem_Click);
            // 
            // teachersStatisticsToolStripMenuItem
            // 
            this.teachersStatisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teacherBusinessToolStripMenuItem});
            this.teachersStatisticsToolStripMenuItem.Name = "teachersStatisticsToolStripMenuItem";
            this.teachersStatisticsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.teachersStatisticsToolStripMenuItem.Text = "Преподавателей";
            // 
            // teacherBusinessToolStripMenuItem
            // 
            this.teacherBusinessToolStripMenuItem.Name = "teacherBusinessToolStripMenuItem";
            this.teacherBusinessToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.teacherBusinessToolStripMenuItem.Text = "Зайнятость";
            this.teacherBusinessToolStripMenuItem.Click += new System.EventHandler(this.teacherBusinessToolStripMenuItem_Click);
            // 
            // currentToolStripMenuItem
            // 
            this.currentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.парыToolStripMenuItem,
            this.свободныеКабинетыToolStripMenuItem});
            this.currentToolStripMenuItem.Name = "currentToolStripMenuItem";
            this.currentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.currentToolStripMenuItem.Text = "На данный момент";
            // 
            // парыToolStripMenuItem
            // 
            this.парыToolStripMenuItem.Name = "парыToolStripMenuItem";
            this.парыToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.парыToolStripMenuItem.Text = "Пары";
            // 
            // свободныеКабинетыToolStripMenuItem
            // 
            this.свободныеКабинетыToolStripMenuItem.Name = "свободныеКабинетыToolStripMenuItem";
            this.свободныеКабинетыToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.свободныеКабинетыToolStripMenuItem.Text = "Свободные кабинеты";
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scheduleToolStripMenuItem.Text = "Расписание";
            // 
            // schedulingToolStripMenuItem
            // 
            this.schedulingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoSchedulingToolStripMenuItem,
            this.manualSchedulingToolStripMenuItem});
            this.schedulingToolStripMenuItem.Name = "schedulingToolStripMenuItem";
            this.schedulingToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.schedulingToolStripMenuItem.Text = "Построение графика";
            // 
            // autoSchedulingToolStripMenuItem
            // 
            this.autoSchedulingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoScheduleAllToolStripMenuItem,
            this.autoScheduleOneToolStripMenuItem});
            this.autoSchedulingToolStripMenuItem.Name = "autoSchedulingToolStripMenuItem";
            this.autoSchedulingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autoSchedulingToolStripMenuItem.Text = "Автоматически";
            // 
            // autoScheduleAllToolStripMenuItem
            // 
            this.autoScheduleAllToolStripMenuItem.Name = "autoScheduleAllToolStripMenuItem";
            this.autoScheduleAllToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.autoScheduleAllToolStripMenuItem.Text = "Построение графика";
            // 
            // autoScheduleOneToolStripMenuItem
            // 
            this.autoScheduleOneToolStripMenuItem.Name = "autoScheduleOneToolStripMenuItem";
            this.autoScheduleOneToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.autoScheduleOneToolStripMenuItem.Text = "Построениее отдельно";
            // 
            // manualSchedulingToolStripMenuItem
            // 
            this.manualSchedulingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeScheduleToolStripMenuItem,
            this.recoverToolStripMenuItem});
            this.manualSchedulingToolStripMenuItem.Name = "manualSchedulingToolStripMenuItem";
            this.manualSchedulingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manualSchedulingToolStripMenuItem.Text = "Вручную";
            // 
            // changeScheduleToolStripMenuItem
            // 
            this.changeScheduleToolStripMenuItem.Name = "changeScheduleToolStripMenuItem";
            this.changeScheduleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeScheduleToolStripMenuItem.Text = "Изменить график";
            this.changeScheduleToolStripMenuItem.Click += new System.EventHandler(this.changeScheduleToolStripMenuItem_Click);
            // 
            // recoverToolStripMenuItem
            // 
            this.recoverToolStripMenuItem.Name = "recoverToolStripMenuItem";
            this.recoverToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recoverToolStripMenuItem.Text = "Восстановление";
            this.recoverToolStripMenuItem.Click += new System.EventHandler(this.recoverToolStripMenuItem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(672, 7);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(120, 11);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(581, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Прогресс пары";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(384, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "00:00";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 411);
            this.dataGridView1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PPadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PPadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Помощник планирования (Admin)";
            this.Load += new System.EventHandler(this.PPadmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem schedulingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoSchedulingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoScheduleAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoScheduleOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualSchedulingToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeRoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeRoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lessonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрПредметовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьПредметыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeTeachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTeachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changeUserstoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupBusinessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherBusinessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem парыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свободныеКабинетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recoverToolStripMenuItem;
    }
}

