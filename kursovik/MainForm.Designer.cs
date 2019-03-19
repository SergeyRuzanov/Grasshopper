namespace kursovik
{
    partial class MainForm
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
            this.buttonLeftJump = new System.Windows.Forms.Button();
            this.buttonRightJump = new System.Windows.Forms.Button();
            this.buttonPain = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MakeTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DownloadTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMakeTask = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDownloadTask = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSupport = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonReset = new System.Windows.Forms.Button();
            this.listBoxActions = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLeftJump
            // 
            this.buttonLeftJump.Location = new System.Drawing.Point(28, 265);
            this.buttonLeftJump.Name = "buttonLeftJump";
            this.buttonLeftJump.Size = new System.Drawing.Size(108, 55);
            this.buttonLeftJump.TabIndex = 1;
            this.buttonLeftJump.Text = "Прыжок влево";
            this.buttonLeftJump.UseVisualStyleBackColor = true;
            this.buttonLeftJump.Click += new System.EventHandler(this.ButtonLeftJump_Click);
            // 
            // buttonRightJump
            // 
            this.buttonRightJump.Location = new System.Drawing.Point(166, 265);
            this.buttonRightJump.Name = "buttonRightJump";
            this.buttonRightJump.Size = new System.Drawing.Size(114, 55);
            this.buttonRightJump.TabIndex = 2;
            this.buttonRightJump.Text = "Прыжок вправо ";
            this.buttonRightJump.UseVisualStyleBackColor = true;
            this.buttonRightJump.Click += new System.EventHandler(this.ButtonRightJump_Click);
            // 
            // buttonPain
            // 
            this.buttonPain.Location = new System.Drawing.Point(28, 326);
            this.buttonPain.Name = "buttonPain";
            this.buttonPain.Size = new System.Drawing.Size(252, 43);
            this.buttonPain.TabIndex = 3;
            this.buttonPain.Text = "Перекрасить точку";
            this.buttonPain.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(28, 375);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(252, 46);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отменить последнее действие";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.White;
            this.pictureBoxMain.Location = new System.Drawing.Point(305, 47);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(1018, 420);
            this.pictureBoxMain.TabIndex = 5;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxMain_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1335, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuToolStripMenuItem
            // 
            this.MenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MakeTaskToolStripMenuItem,
            this.DownloadTaskToolStripMenuItem});
            this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            this.MenuToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.MenuToolStripMenuItem.Text = "Меню";
            // 
            // MakeTaskToolStripMenuItem
            // 
            this.MakeTaskToolStripMenuItem.Name = "MakeTaskToolStripMenuItem";
            this.MakeTaskToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.MakeTaskToolStripMenuItem.Text = "Создать задание";
            this.MakeTaskToolStripMenuItem.Click += new System.EventHandler(this.MakeTaskToolStripMenuItem_Click);
            // 
            // DownloadTaskToolStripMenuItem
            // 
            this.DownloadTaskToolStripMenuItem.Name = "DownloadTaskToolStripMenuItem";
            this.DownloadTaskToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.DownloadTaskToolStripMenuItem.Text = "Загрузить задание";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // ToolStripMenuItemMenu
            // 
            this.ToolStripMenuItemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemMakeTask,
            this.ToolStripMenuItemDownloadTask});
            this.ToolStripMenuItemMenu.Name = "ToolStripMenuItemMenu";
            this.ToolStripMenuItemMenu.Size = new System.Drawing.Size(63, 24);
            this.ToolStripMenuItemMenu.Text = "Меню";
            // 
            // ToolStripMenuItemMakeTask
            // 
            this.ToolStripMenuItemMakeTask.Name = "ToolStripMenuItemMakeTask";
            this.ToolStripMenuItemMakeTask.Size = new System.Drawing.Size(213, 26);
            this.ToolStripMenuItemMakeTask.Text = "Создать задание";
            // 
            // ToolStripMenuItemDownloadTask
            // 
            this.ToolStripMenuItemDownloadTask.Name = "ToolStripMenuItemDownloadTask";
            this.ToolStripMenuItemDownloadTask.Size = new System.Drawing.Size(213, 26);
            this.ToolStripMenuItemDownloadTask.Text = "Загрузить задание";
            // 
            // ToolStripMenuItemSupport
            // 
            this.ToolStripMenuItemSupport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem});
            this.ToolStripMenuItemSupport.Name = "ToolStripMenuItemSupport";
            this.ToolStripMenuItemSupport.Size = new System.Drawing.Size(79, 24);
            this.ToolStripMenuItemSupport.Text = "Справка";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(28, 427);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(252, 40);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Начать сначала";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // listBoxActions
            // 
            this.listBoxActions.FormattingEnabled = true;
            this.listBoxActions.ItemHeight = 16;
            this.listBoxActions.Location = new System.Drawing.Point(28, 47);
            this.listBoxActions.Name = "listBoxActions";
            this.listBoxActions.Size = new System.Drawing.Size(252, 212);
            this.listBoxActions.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 487);
            this.Controls.Add(this.listBoxActions);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonPain);
            this.Controls.Add(this.buttonRightJump);
            this.Controls.Add(this.buttonLeftJump);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Исполнитель \"Кузнечик\"";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLeftJump;
        private System.Windows.Forms.Button buttonRightJump;
        private System.Windows.Forms.Button buttonPain;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMakeTask;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDownloadTask;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSupport;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ListBox listBoxActions;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MakeTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DownloadTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}

