using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovik
{
    public partial class CreateTaskForm : Form
    {
        private MainForm mainForm;
        private List<int> paintPoints = new List<int>();
        public CreateTaskForm(MainForm e)
        {
            InitializeComponent();
            mainForm = e;
            //Установка пределов числовых полей
            numericUpDownStartPosition.Maximum = int.MaxValue;
            numericUpDownStartPosition.Minimum = int.MinValue;
            numericUpDownSizeJumpLeft.Maximum = int.MaxValue;
            numericUpDownSizeJumpLeft.Minimum = 1;
            numericUpDownSizeJumpRight.Maximum = int.MaxValue;
            numericUpDownSizeJumpRight.Minimum = 1;
            numericUpDownFinish.Maximum = int.MaxValue;
            numericUpDownFinish.Minimum = int.MinValue;
            numericUpDownBorderLeft.Maximum = int.MaxValue;
            numericUpDownBorderLeft.Minimum = int.MinValue;
            numericUpDownBorderRight.Maximum = int.MaxValue;
            numericUpDownBorderRight.Minimum = int.MinValue;
            numericUpDownPositionPaintPoint.Maximum = int.MaxValue;
            numericUpDownPositionPaintPoint.Minimum = int.MinValue;
            //Установка значений формы
            numericUpDownStartPosition.Value = e.task.StartPosition;
            numericUpDownSizeJumpLeft.Value = e.task.SizeLeftJump;
            numericUpDownSizeJumpRight.Value = e.task.SizeRightJump;
            if (e.task.FinishPosition != null)
            {
                numericUpDownFinish.Value = (int)e.task.FinishPosition;
            }
            if (e.task.MinBorder != null)
            {
                numericUpDownBorderLeft.Value = (int)e.task.MinBorder;
                checkBoxBorder.Checked = true;
            }
            if (e.task.MaxBorder != null)
            {
                numericUpDownBorderRight.Value = (int)e.task.MaxBorder;
                checkBoxBorder.Checked = true;
            }
            if (e.task.PointsPaints != null)
            {
                paintPoints = e.task.PointsPaints;
                foreach (int val in paintPoints)
                {
                    listBoxPaintPoints.Items.Add(val);
                }
                checkBoxPaintPoints.Checked = true;
            }

        }

        private void ButtonAddTask_Click(object sender, EventArgs e)
        {
            int startPosition = (int)numericUpDownStartPosition.Value;
            int sizeLeftJump = (int)numericUpDownSizeJumpLeft.Value;
            int sizeRightJump = (int)numericUpDownSizeJumpRight.Value;
            int? finishPosition = (int)numericUpDownFinish.Value;
            int? rightBorder = null;
            int? leftBorder = null;
            List<int> paintPoints = null;

            bool errorFlag = false;
            if (numericUpDownFinish.Value == numericUpDownStartPosition.Value)
            {
                numericUpDownFinish.BackColor = Color.Red;
                MessageBox.Show("Начальная позиция не может совпадать с финишем!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorFlag = true;
            }
            if (checkBoxBorder.Checked)
            {
                rightBorder = (int)numericUpDownBorderRight.Value;
                leftBorder = (int)numericUpDownBorderLeft.Value;
                if (leftBorder >= startPosition)
                {
                    MessageBox.Show("Начальная позиция не может быть левее границы или совпадать с ней", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numericUpDownBorderLeft.BackColor = Color.Red;
                    errorFlag = true;
                }
                if (rightBorder <= startPosition)
                {
                    MessageBox.Show("Начальная позиция не может быть правее границы или совпадать с ней", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numericUpDownBorderRight.BackColor = Color.Red;
                    errorFlag = true;
                }

                if (leftBorder >= finishPosition)
                {
                    MessageBox.Show("Финиш не может быть левее границы или совпадать с ней", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numericUpDownBorderLeft.BackColor = Color.Red;
                    errorFlag = true;
                }
                if (rightBorder <= finishPosition)
                {
                    MessageBox.Show("Финиш не может быть правее границы или совпадать с ней", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numericUpDownBorderRight.BackColor = Color.Red;
                    errorFlag = true;
                }
            }
            if (checkBoxPaintPoints.Checked)
            {
                bool errorMessageBorderflag = false;
                foreach(int val in this.paintPoints)
                {
                    if((checkBoxBorder.Checked && ((val <= numericUpDownBorderLeft.Value) || (val >= numericUpDownBorderRight.Value))) || (val == numericUpDownFinish.Value))
                    {
                        errorMessageBorderflag = true;
                        errorFlag = true;
                    }
                }
                if (errorMessageBorderflag)
                {
                    MessageBox.Show("Проверьте список точек для покраски. Они не должны совпадать с финишем или выходить за границы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (this.paintPoints.Count != 0)
                {
                    paintPoints = this.paintPoints;
                }
            }
            if (!errorFlag)
            {
                Task task = new Task(startPosition, sizeLeftJump, sizeRightJump, finishPosition, rightBorder, leftBorder, paintPoints);
                mainForm.UpdateForm(task);
                buttonSaveTaskToFile.Enabled = true;
            }
        }

        private void CheckBoxBorder_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxBorders.Enabled = checkBoxBorder.Checked;
            if (checkBoxBorder.Checked)
            {
                if (numericUpDownBorderLeft.Value >= numericUpDownStartPosition.Value)
                {

                    numericUpDownBorderLeft.Value = numericUpDownStartPosition.Value - 1;

                }
                if (numericUpDownBorderRight.Value <= numericUpDownStartPosition.Value)
                {

                    numericUpDownBorderRight.Value = numericUpDownStartPosition.Value + 1;
                }
            }
        }

        private void CheckBoxPaintPoints_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxPointPoints.Enabled = checkBoxPaintPoints.Checked;
        }

        private void NumericUpDownFinish_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownFinish.BackColor = SystemColors.Window;
        }

        private void NumericUpDownBorderLeft_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownBorderLeft.BackColor = SystemColors.Window;
        }

        private void NumericUpDownBorderRight_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownBorderRight.BackColor = SystemColors.Window;
        }

        private void ButtonAddPaintPoint_Click(object sender, EventArgs e)
        {
            int value = (int)numericUpDownPositionPaintPoint.Value;
            if (checkBoxBorder.Checked && ((value <= numericUpDownBorderLeft.Value) || (value >= numericUpDownBorderRight.Value)))
            {
                MessageBox.Show("Точка не входит в заданные границы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(value == numericUpDownFinish.Value)
            {
                MessageBox.Show("Точка не может совпадать с финишем!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (paintPoints.IndexOf(value) == -1)
                {
                    paintPoints.Add(value);
                    listBoxPaintPoints.Items.Add(value);
                }
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            int indexDel = listBoxPaintPoints.SelectedIndex;
            if (indexDel != -1)
            {
                listBoxPaintPoints.Items.RemoveAt(indexDel);
                paintPoints.RemoveAt(indexDel);
            }
        }

        private void ButtonSaveTaskToFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string fileName = saveFileDialog1.FileName;
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            {
                formatter.Serialize(fileStream, mainForm.task);
            }
            buttonSaveTaskToFile.Enabled = false;
        }
    }
}
