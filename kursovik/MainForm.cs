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
    public partial class MainForm : Form
    {
        public Grasshopper grasshopper { get; set; } = new Grasshopper();
        public Task task { get; set; }
        public MainForm()
        {
            InitializeComponent();
            UpdateForm(new Task());
        }
        public void UpdateForm(Task _task)
        {
            task = _task;
            grasshopper = new Grasshopper(task.StartPosition);
            buttonLeftJump.Text = $"Прыжок влево на {task.SizeLeftJump}";
            buttonRightJump.Text = $"Прыжок вправо на {task.SizeRightJump}";
            listBoxActions.Items.Clear();
            buttonCancel.Enabled = false;
            pictureBoxMain.Refresh();
        }

        //Пикселей в одном делении оси
        const int PIX_IN_ONE = 30;
        private void PictureBoxMain_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBoxMain.ClientSize.Width / 2;
            int h = pictureBoxMain.ClientSize.Height / 2;
            //Смещение начала координат в центр PictureBox
            e.Graphics.TranslateTransform(w, h);
            DrawXAxis(new Point(-w, 0), new Point(w, 0), e.Graphics);
            //Центр координат
            //e.Graphics.FillRectangle(Brushes.Black, -2, -2, 5, 5);
            if (grasshopper.CoordinateX == task.MinBorder || grasshopper.CoordinateX == task.MaxBorder)
            {
                e.Graphics.FillRectangle(Brushes.Red,  - 3, -7, 4, 14);
            }
            else if (grasshopper.CoordinateX == task.FinishPosition)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Green),  - 3, -3, 7, 7);
            }
            else if (task.PointsPaints != null && task.PointsPaints?.IndexOf(grasshopper.CoordinateX) != -1)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black), - 3, -3, 7, 7);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.Black,  - 3, -2, 5, 5);
            }
            DrawText(new Point(0, 5), (grasshopper.CoordinateX).ToString(), e.Graphics);//TODO единицу заменить на позицию
            e.Graphics.DrawImage(Properties.Resources.arrow, new Point(-11, -38));
        }
        //Рисование оси X
        private void DrawXAxis(Point start, Point end, Graphics g)
        {
            //Ось
            g.DrawLine(Pens.Black, start, end);
            //Деления в положительном направлении оси
            for (int i = PIX_IN_ONE; i < end.X; i += PIX_IN_ONE)
            {
                
                if ((i / PIX_IN_ONE + grasshopper.CoordinateX) == task.MinBorder || (i / PIX_IN_ONE + grasshopper.CoordinateX) == task.MaxBorder)
                {
                    g.FillRectangle(Brushes.Red, i - 3, -7, 4, 14);
                }
                else if ((i / PIX_IN_ONE + grasshopper.CoordinateX) == task.FinishPosition)
                {
                    g.DrawRectangle(new Pen(Color.Green), i - 3, -3, 7, 7);
                }
                else if (task.PointsPaints != null && task.PointsPaints?.IndexOf(i / PIX_IN_ONE + grasshopper.CoordinateX) != -1)
                {
                    g.DrawRectangle(new Pen(Color.Black), i - 3, -3, 7, 7);
                }
                else
                {
                    g.FillRectangle(Brushes.Black, i - 3, -2, 5, 5);
                }
                DrawText(new Point(i, 5), ((i / PIX_IN_ONE) + grasshopper.CoordinateX).ToString(), g);//TODO единицу заменить на позицию
            }
            //Деления в отрицательном направлении оси
            for (int i = -PIX_IN_ONE; i > start.X; i -= PIX_IN_ONE)
            {
                if ((i / PIX_IN_ONE + grasshopper.CoordinateX) == task.MinBorder || (i / PIX_IN_ONE + grasshopper.CoordinateX) == task.MaxBorder)
                {
                    g.FillRectangle(Brushes.Red, i - 3, -7, 4, 14);
                }
                else if ((i / PIX_IN_ONE + grasshopper.CoordinateX) == task.FinishPosition)
                {
                    g.DrawRectangle(new Pen(Color.Green), i - 3, -4, 7, 7);
                }
                else if (task.PointsPaints != null && task.PointsPaints?.IndexOf(i / PIX_IN_ONE + grasshopper.CoordinateX) != -1)
                {
                    g.DrawRectangle(new Pen(Color.Black), i - 3, -3, 7, 7);
                }
                else
                {
                    g.FillRectangle(Brushes.Black, i - 3, -2, 5, 5);
                }
                DrawText(new Point(i - 2, 5), ((i / PIX_IN_ONE) + grasshopper.CoordinateX).ToString(), g);//TODO единицу заменить на позицию
            }
            
        }
        private void DrawText(Point point, string text, Graphics g)
        {
            var f = new Font(Font.FontFamily, 8);
            var size = g.MeasureString(text, f);
            var pt = new PointF(point.X - size.Width / 2, point.Y + 2);
            var rect = new RectangleF(pt, size);
            g.DrawString(text, f, Brushes.Black, rect);
        }

        private void ButtonLeftJump_Click(object sender, EventArgs e)
        {
            int sizeJump = task.SizeLeftJump;
            grasshopper.JumpLeft(sizeJump);
            listBoxActions.Items.Add($"Прыжок влево на {sizeJump}");
            buttonCancel.Enabled = true;
            pictureBoxMain.Refresh();
        }

        private void ButtonRightJump_Click(object sender, EventArgs e)
        {
            int sizeJump = task.SizeRightJump;
            grasshopper.JumpRight(sizeJump);
            listBoxActions.Items.Add($"Прыжок вправо на {sizeJump}");
            buttonCancel.Enabled = true;
            pictureBoxMain.Refresh();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            grasshopper.CoordinateX = grasshopper.PrevCoordinateX;
            pictureBoxMain.Refresh();
            listBoxActions.Items.RemoveAt(listBoxActions.Items.Count - 1);
            buttonCancel.Enabled = false;
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            grasshopper = new Grasshopper(task.StartPosition);
            listBoxActions.Items.Clear();
            buttonCancel.Enabled = false;
            pictureBoxMain.Refresh();
        }

        private void MakeTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTaskForm form = new CreateTaskForm(this);
            form.ShowDialog(this);
        }

        private void DownloadTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Task serTask;
            BinaryFormatter formatter = new BinaryFormatter();
            string fileName = openFileDialog1.FileName;
            try
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
                {
                    serTask = (Task)formatter.Deserialize(fileStream);
                }
                UpdateForm(serTask);
            }
            catch (System.Runtime.Serialization.SerializationException)
            {
                MessageBox.Show("Ошибка считывания файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
