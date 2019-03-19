﻿namespace kursovik
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
            this.buttonLeftJump.Size = new System.Drawing.Size(219, 38);
            this.buttonLeftJump.TabIndex = 1;
            this.buttonLeftJump.Text = "Прыжок влево";
            this.buttonLeftJump.UseVisualStyleBackColor = true;
            // 
            // buttonRightJump
            // 
            this.buttonRightJump.Location = new System.Drawing.Point(28, 309);
            this.buttonRightJump.Name = "buttonRightJump";
            this.buttonRightJump.Size = new System.Drawing.Size(219, 37);
            this.buttonRightJump.TabIndex = 2;
            this.buttonRightJump.Text = "Прыжок вправо ";
            this.buttonRightJump.UseVisualStyleBackColor = true;
            // 
            // buttonPain
            // 
            this.buttonPain.Location = new System.Drawing.Point(28, 352);
            this.buttonPain.Name = "buttonPain";
            this.buttonPain.Size = new System.Drawing.Size(219, 43);
            this.buttonPain.TabIndex = 3;
            this.buttonPain.Text = "Перекрасить точку";
            this.buttonPain.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(28, 401);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(219, 46);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отменить последнее действие";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Location = new System.Drawing.Point(281, 47);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(524, 446);
            this.pictureBoxMain.TabIndex = 5;
            this.pictureBoxMain.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemMenu,
            this.ToolStripMenuItemSupport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
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
            this.ToolStripMenuItemMakeTask.Size = new System.Drawing.Size(216, 26);
            this.ToolStripMenuItemMakeTask.Text = "Создать задание";
            // 
            // ToolStripMenuItemDownloadTask
            // 
            this.ToolStripMenuItemDownloadTask.Name = "ToolStripMenuItemDownloadTask";
            this.ToolStripMenuItemDownloadTask.Size = new System.Drawing.Size(216, 26);
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
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(28, 453);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(219, 40);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "начать сначала";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // listBoxActions
            // 
            this.listBoxActions.FormattingEnabled = true;
            this.listBoxActions.ItemHeight = 16;
            this.listBoxActions.Location = new System.Drawing.Point(28, 47);
            this.listBoxActions.Name = "listBoxActions";
            this.listBoxActions.Size = new System.Drawing.Size(219, 196);
            this.listBoxActions.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 520);
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
    }
}

