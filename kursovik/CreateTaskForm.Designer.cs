namespace kursovik
{
    partial class CreateTaskForm
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
            this.numericUpDownSizeJumpLeft = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSizeJumpRight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStartPosition = new System.Windows.Forms.NumericUpDown();
            this.checkBoxBorder = new System.Windows.Forms.CheckBox();
            this.groupBoxBorders = new System.Windows.Forms.GroupBox();
            this.labelBorderRight = new System.Windows.Forms.Label();
            this.labelBorderLeft = new System.Windows.Forms.Label();
            this.numericUpDownBorderRight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBorderLeft = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFinish = new System.Windows.Forms.NumericUpDown();
            this.labelSizeJumpLeft = new System.Windows.Forms.Label();
            this.labelSizeJumpRight = new System.Windows.Forms.Label();
            this.labelStartPosition = new System.Windows.Forms.Label();
            this.labelFinishPosition = new System.Windows.Forms.Label();
            this.buttonSaveTaskToFile = new System.Windows.Forms.Button();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.checkBoxPaintPoints = new System.Windows.Forms.CheckBox();
            this.groupBoxPointPoints = new System.Windows.Forms.GroupBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.labelPaintPoint = new System.Windows.Forms.Label();
            this.listBoxPaintPoints = new System.Windows.Forms.ListBox();
            this.buttonAddPaintPoint = new System.Windows.Forms.Button();
            this.numericUpDownPositionPaintPoint = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeJumpLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeJumpRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPosition)).BeginInit();
            this.groupBoxBorders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBorderRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBorderLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFinish)).BeginInit();
            this.groupBoxPointPoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionPaintPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownSizeJumpLeft
            // 
            this.numericUpDownSizeJumpLeft.Location = new System.Drawing.Point(195, 10);
            this.numericUpDownSizeJumpLeft.Name = "numericUpDownSizeJumpLeft";
            this.numericUpDownSizeJumpLeft.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSizeJumpLeft.TabIndex = 0;
            // 
            // numericUpDownSizeJumpRight
            // 
            this.numericUpDownSizeJumpRight.Location = new System.Drawing.Point(195, 39);
            this.numericUpDownSizeJumpRight.Name = "numericUpDownSizeJumpRight";
            this.numericUpDownSizeJumpRight.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSizeJumpRight.TabIndex = 1;
            // 
            // numericUpDownStartPosition
            // 
            this.numericUpDownStartPosition.Location = new System.Drawing.Point(195, 68);
            this.numericUpDownStartPosition.Name = "numericUpDownStartPosition";
            this.numericUpDownStartPosition.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownStartPosition.TabIndex = 2;
            this.numericUpDownStartPosition.ValueChanged += new System.EventHandler(this.NumericUpDownFinish_ValueChanged);
            // 
            // checkBoxBorder
            // 
            this.checkBoxBorder.AutoSize = true;
            this.checkBoxBorder.Location = new System.Drawing.Point(31, 189);
            this.checkBoxBorder.Name = "checkBoxBorder";
            this.checkBoxBorder.Size = new System.Drawing.Size(136, 21);
            this.checkBoxBorder.TabIndex = 4;
            this.checkBoxBorder.Text = "Задать границы";
            this.checkBoxBorder.UseVisualStyleBackColor = true;
            this.checkBoxBorder.CheckedChanged += new System.EventHandler(this.CheckBoxBorder_CheckedChanged);
            // 
            // groupBoxBorders
            // 
            this.groupBoxBorders.Controls.Add(this.labelBorderRight);
            this.groupBoxBorders.Controls.Add(this.labelBorderLeft);
            this.groupBoxBorders.Controls.Add(this.numericUpDownBorderRight);
            this.groupBoxBorders.Controls.Add(this.numericUpDownBorderLeft);
            this.groupBoxBorders.Enabled = false;
            this.groupBoxBorders.Location = new System.Drawing.Point(31, 216);
            this.groupBoxBorders.Name = "groupBoxBorders";
            this.groupBoxBorders.Size = new System.Drawing.Size(432, 146);
            this.groupBoxBorders.TabIndex = 4;
            this.groupBoxBorders.TabStop = false;
            this.groupBoxBorders.Text = "Границы";
            // 
            // labelBorderRight
            // 
            this.labelBorderRight.AutoSize = true;
            this.labelBorderRight.Location = new System.Drawing.Point(7, 76);
            this.labelBorderRight.Name = "labelBorderRight";
            this.labelBorderRight.Size = new System.Drawing.Size(167, 17);
            this.labelBorderRight.TabIndex = 3;
            this.labelBorderRight.Text = "Правая граница прямой";
            // 
            // labelBorderLeft
            // 
            this.labelBorderLeft.AutoSize = true;
            this.labelBorderLeft.Location = new System.Drawing.Point(7, 34);
            this.labelBorderLeft.Name = "labelBorderLeft";
            this.labelBorderLeft.Size = new System.Drawing.Size(159, 17);
            this.labelBorderLeft.TabIndex = 2;
            this.labelBorderLeft.Text = "Левая граница прямой";
            // 
            // numericUpDownBorderRight
            // 
            this.numericUpDownBorderRight.Location = new System.Drawing.Point(234, 74);
            this.numericUpDownBorderRight.Name = "numericUpDownBorderRight";
            this.numericUpDownBorderRight.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownBorderRight.TabIndex = 6;
            this.numericUpDownBorderRight.ValueChanged += new System.EventHandler(this.NumericUpDownBorderRight_ValueChanged);
            // 
            // numericUpDownBorderLeft
            // 
            this.numericUpDownBorderLeft.Location = new System.Drawing.Point(234, 32);
            this.numericUpDownBorderLeft.Name = "numericUpDownBorderLeft";
            this.numericUpDownBorderLeft.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownBorderLeft.TabIndex = 5;
            this.numericUpDownBorderLeft.ValueChanged += new System.EventHandler(this.NumericUpDownBorderLeft_ValueChanged);
            // 
            // numericUpDownFinish
            // 
            this.numericUpDownFinish.Location = new System.Drawing.Point(195, 96);
            this.numericUpDownFinish.Name = "numericUpDownFinish";
            this.numericUpDownFinish.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownFinish.TabIndex = 3;
            this.numericUpDownFinish.ValueChanged += new System.EventHandler(this.NumericUpDownFinish_ValueChanged);
            // 
            // labelSizeJumpLeft
            // 
            this.labelSizeJumpLeft.AutoSize = true;
            this.labelSizeJumpLeft.Location = new System.Drawing.Point(17, 12);
            this.labelSizeJumpLeft.Name = "labelSizeJumpLeft";
            this.labelSizeJumpLeft.Size = new System.Drawing.Size(153, 17);
            this.labelSizeJumpLeft.TabIndex = 6;
            this.labelSizeJumpLeft.Text = "Размер прыжка влево";
            // 
            // labelSizeJumpRight
            // 
            this.labelSizeJumpRight.AutoSize = true;
            this.labelSizeJumpRight.Location = new System.Drawing.Point(17, 39);
            this.labelSizeJumpRight.Name = "labelSizeJumpRight";
            this.labelSizeJumpRight.Size = new System.Drawing.Size(161, 17);
            this.labelSizeJumpRight.TabIndex = 7;
            this.labelSizeJumpRight.Text = "Размер прыжка вправо";
            // 
            // labelStartPosition
            // 
            this.labelStartPosition.AutoSize = true;
            this.labelStartPosition.Location = new System.Drawing.Point(17, 68);
            this.labelStartPosition.Name = "labelStartPosition";
            this.labelStartPosition.Size = new System.Drawing.Size(140, 17);
            this.labelStartPosition.TabIndex = 8;
            this.labelStartPosition.Text = "Начальная позиция";
            // 
            // labelFinishPosition
            // 
            this.labelFinishPosition.AutoSize = true;
            this.labelFinishPosition.Location = new System.Drawing.Point(17, 96);
            this.labelFinishPosition.Name = "labelFinishPosition";
            this.labelFinishPosition.Size = new System.Drawing.Size(56, 17);
            this.labelFinishPosition.TabIndex = 9;
            this.labelFinishPosition.Text = "Финиш";
            // 
            // buttonSaveTaskToFile
            // 
            this.buttonSaveTaskToFile.Enabled = false;
            this.buttonSaveTaskToFile.Location = new System.Drawing.Point(128, 627);
            this.buttonSaveTaskToFile.Name = "buttonSaveTaskToFile";
            this.buttonSaveTaskToFile.Size = new System.Drawing.Size(178, 52);
            this.buttonSaveTaskToFile.TabIndex = 10;
            this.buttonSaveTaskToFile.Text = "Сохранить задание в файл";
            this.buttonSaveTaskToFile.UseVisualStyleBackColor = true;
            this.buttonSaveTaskToFile.Click += new System.EventHandler(this.ButtonSaveTaskToFile_Click);
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(312, 627);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(178, 50);
            this.buttonAddTask.TabIndex = 11;
            this.buttonAddTask.Text = "Подтвердить задание";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.ButtonAddTask_Click);
            // 
            // checkBoxPaintPoints
            // 
            this.checkBoxPaintPoints.AutoSize = true;
            this.checkBoxPaintPoints.Location = new System.Drawing.Point(31, 369);
            this.checkBoxPaintPoints.Name = "checkBoxPaintPoints";
            this.checkBoxPaintPoints.Size = new System.Drawing.Size(346, 21);
            this.checkBoxPaintPoints.TabIndex = 7;
            this.checkBoxPaintPoints.Text = "Задать обязательные точки для закрашивания";
            this.checkBoxPaintPoints.UseVisualStyleBackColor = true;
            this.checkBoxPaintPoints.CheckedChanged += new System.EventHandler(this.CheckBoxPaintPoints_CheckedChanged);
            // 
            // groupBoxPointPoints
            // 
            this.groupBoxPointPoints.Controls.Add(this.buttonDel);
            this.groupBoxPointPoints.Controls.Add(this.labelPaintPoint);
            this.groupBoxPointPoints.Controls.Add(this.listBoxPaintPoints);
            this.groupBoxPointPoints.Controls.Add(this.buttonAddPaintPoint);
            this.groupBoxPointPoints.Controls.Add(this.numericUpDownPositionPaintPoint);
            this.groupBoxPointPoints.Enabled = false;
            this.groupBoxPointPoints.Location = new System.Drawing.Point(20, 397);
            this.groupBoxPointPoints.Name = "groupBoxPointPoints";
            this.groupBoxPointPoints.Size = new System.Drawing.Size(443, 204);
            this.groupBoxPointPoints.TabIndex = 13;
            this.groupBoxPointPoints.TabStop = false;
            this.groupBoxPointPoints.Text = "Точки для закрашивания";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(267, 170);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 10;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // labelPaintPoint
            // 
            this.labelPaintPoint.AutoSize = true;
            this.labelPaintPoint.Location = new System.Drawing.Point(20, 32);
            this.labelPaintPoint.Name = "labelPaintPoint";
            this.labelPaintPoint.Size = new System.Drawing.Size(130, 17);
            this.labelPaintPoint.TabIndex = 3;
            this.labelPaintPoint.Text = "Координата точки";
            // 
            // listBoxPaintPoints
            // 
            this.listBoxPaintPoints.FormattingEnabled = true;
            this.listBoxPaintPoints.ItemHeight = 16;
            this.listBoxPaintPoints.Location = new System.Drawing.Point(21, 80);
            this.listBoxPaintPoints.Name = "listBoxPaintPoints";
            this.listBoxPaintPoints.Size = new System.Drawing.Size(321, 84);
            this.listBoxPaintPoints.TabIndex = 2;
            // 
            // buttonAddPaintPoint
            // 
            this.buttonAddPaintPoint.Location = new System.Drawing.Point(340, 31);
            this.buttonAddPaintPoint.Name = "buttonAddPaintPoint";
            this.buttonAddPaintPoint.Size = new System.Drawing.Size(97, 24);
            this.buttonAddPaintPoint.TabIndex = 9;
            this.buttonAddPaintPoint.Text = "Добавить";
            this.buttonAddPaintPoint.UseVisualStyleBackColor = true;
            this.buttonAddPaintPoint.Click += new System.EventHandler(this.ButtonAddPaintPoint_Click);
            // 
            // numericUpDownPositionPaintPoint
            // 
            this.numericUpDownPositionPaintPoint.Location = new System.Drawing.Point(196, 30);
            this.numericUpDownPositionPaintPoint.Name = "numericUpDownPositionPaintPoint";
            this.numericUpDownPositionPaintPoint.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPositionPaintPoint.TabIndex = 8;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "tsk";
            this.saveFileDialog1.FileName = "Task";
            this.saveFileDialog1.Filter = "Файл задания (*.tsk)|*.tsk";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1_FileOk);
            // 
            // CreateTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 689);
            this.Controls.Add(this.groupBoxPointPoints);
            this.Controls.Add(this.checkBoxPaintPoints);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.buttonSaveTaskToFile);
            this.Controls.Add(this.labelFinishPosition);
            this.Controls.Add(this.labelStartPosition);
            this.Controls.Add(this.labelSizeJumpRight);
            this.Controls.Add(this.labelSizeJumpLeft);
            this.Controls.Add(this.numericUpDownFinish);
            this.Controls.Add(this.groupBoxBorders);
            this.Controls.Add(this.checkBoxBorder);
            this.Controls.Add(this.numericUpDownStartPosition);
            this.Controls.Add(this.numericUpDownSizeJumpRight);
            this.Controls.Add(this.numericUpDownSizeJumpLeft);
            this.Name = "CreateTaskForm";
            this.Text = "Задание";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeJumpLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeJumpRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPosition)).EndInit();
            this.groupBoxBorders.ResumeLayout(false);
            this.groupBoxBorders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBorderRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBorderLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFinish)).EndInit();
            this.groupBoxPointPoints.ResumeLayout(false);
            this.groupBoxPointPoints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionPaintPoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownSizeJumpLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownSizeJumpRight;
        private System.Windows.Forms.NumericUpDown numericUpDownStartPosition;
        private System.Windows.Forms.CheckBox checkBoxBorder;
        private System.Windows.Forms.GroupBox groupBoxBorders;
        private System.Windows.Forms.Label labelBorderRight;
        private System.Windows.Forms.Label labelBorderLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownBorderRight;
        private System.Windows.Forms.NumericUpDown numericUpDownBorderLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownFinish;
        private System.Windows.Forms.Label labelSizeJumpLeft;
        private System.Windows.Forms.Label labelSizeJumpRight;
        private System.Windows.Forms.Label labelStartPosition;
        private System.Windows.Forms.Label labelFinishPosition;
        private System.Windows.Forms.Button buttonSaveTaskToFile;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.CheckBox checkBoxPaintPoints;
        private System.Windows.Forms.GroupBox groupBoxPointPoints;
        private System.Windows.Forms.Label labelPaintPoint;
        private System.Windows.Forms.ListBox listBoxPaintPoints;
        private System.Windows.Forms.Button buttonAddPaintPoint;
        private System.Windows.Forms.NumericUpDown numericUpDownPositionPaintPoint;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}