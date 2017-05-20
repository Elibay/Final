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
            g = pictureBox1.CreateGraphics();
            pictureBox1.Image = bmp;
            timer1.Start();
        }
        void draw()
        {
            Refresh();
            for (int i = 1; i <= k; ++ i)
            {
                g.FillEllipse(new SolidBrush(Color.Red), x[i], y[i], 30, 30);
            }
            for (int i = 1; i <= k; ++i)
                if (y[i] + 15 <= 800)
                    y[i] += 15;
            
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ++k;
            x[k] = e.Location.X - 15;
            y[k] = e.Location.Y - 15;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            draw();
        }
    }
}
