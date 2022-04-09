using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1_Korotkov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }
        private void MoveToStart()
        {
            Point startPoint = panel1.Location;
            startPoint.Offset(30, 30);
            Cursor.Position = PointToScreen(startPoint);
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void lbFinish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Вы прошли лабиринт!");
        }
    }
}
