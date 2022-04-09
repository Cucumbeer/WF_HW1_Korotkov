using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_1st_Lesson_03._04_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void lbFinish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Вы прошли лабиринт");
            Form Form2 = new Form();
            Form2.Show();
            //Hide();
        }

        private void MoveToStart()
        {
            Point startPoint = panel1.Location;
            startPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startPoint);
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }
    }
}
