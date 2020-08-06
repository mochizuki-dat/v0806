using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0806
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        int vl = 110;
        int wi;
        int he;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point mp = MousePosition;
            mp = PointToClient(mp);
            label2.Left = mp.X - label2.Width/2;
            label2.Top = mp.Y - label2.Height/2;

            wi = ClientSize.Width;
            he = ClientSize.Height;
            label1.Left += vx;
            label1.Top += vy;
            

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx) * vl/100;
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy) * vl/100;
            }
            if (label1.Right > wi)
            {
                vx = -Math.Abs(vx) * vl/100;
            }
            if (label1.Bottom > he)
            {
                vy = -Math.Abs(vy) * vl/100;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            vx *= -1;
            vy *= -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("幅" + ClientSize.Width);
            //MessageBox.Show("高さ" + ClientSize.Height);
            //wi = ClientSize.Width;
            //he = ClientSize.Height;
        }
    }
}
