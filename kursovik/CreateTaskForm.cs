using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovik
{
    public partial class CreateTaskForm : Form
    {
        public CreateTaskForm()
        {
            InitializeComponent();
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
        }
    }
}
