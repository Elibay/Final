using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp;
        string[] s = new String[30];
        int[] x = new int[30], y = new int[30];
        int k = 12;
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Height, pictureBox1.Width);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            timer1.Start();
            draw();
            draw2();
        }
        void draw()
        {
            for (int i = 1; i <= 12; ++i)
            {
                s[i] = i.ToString();
            }
            x[12] = 20; y[12] = 400;
            x[1] = 60; y[1] = 440;
            x[2] = 100; y[2] = 480;
            x[3] = 140; y[3] = 520;
            x[4] = 180; y[4] = 480;
            x[5] = 220; y[5] = 440;
            x[6] = 260; y[6] = 400;
            x[7] = 220; y[7] = 360;
            x[8] = 180; y[8] = 320;
            x[9] = 140; y[9] = 280;
            x[10] = 100; y[10] = 320;
            x[11] = 60; y[11] = 360;
            for (int i = 1; i <= 12; ++ i)
            {
                Font b = new Font("Calibri", 32, FontStyle.Italic);
                g.DrawString(s[i], b, new SolidBrush (Color.Black), new Point(y[i], x[i]));
            }
        }
        void draw2()
        {
            Font b = new Font("Calibri", 32, FontStyle.Italic);
            g.DrawString(s[k], b, new SolidBrush(Color.Black), new Point(y[k], x[k]));
            ++k;
            if (k > 12)
                k = 1;
            g.DrawString(s[k], b, new SolidBrush(Color.Red), new Point(y[k], x[k]));
            Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
                timer1.Enabled = true;
            else
                timer1.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("G");
            draw2();
        }
    }
}
