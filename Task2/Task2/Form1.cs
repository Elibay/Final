using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        Button[,] b = new Button[5, 5];
        Point a;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            for (int i = 1; i < 4; ++i)
                for (int j = 1; j < 4; ++j)
                {
                    b[i, j] = new Button();
                    b[i, j].Text = "0";
                    b[i, j].Location = new Point(i * 50, j * 50);
                    b[i, j].Size = new Size(50, 50);
                    b[i, j].Click += new EventHandler(button_Click);
                    b[i, j].Name = i.ToString() + " " + j.ToString();
                    this.Controls.Add(b[i, j]);
                }
        }
        bool isPrime (int x)
        {
            if (x == 1)
                return false;
            for (int i = 2; i * i <= x; ++i)
                if (x % i == 0)
                    return false;
            return true;
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int q = a.X / 50 + 1, w = a.Y / 50 + 1;
            //MessageBox.Show(q.ToString() + " " +  w.ToString());
            int x = int.Parse(b.Text);
            ++x;
            b.Text = x.ToString();
            if (isPrime (x))
            {
                int y = int.Parse (textBox1.Text);
                ++y;
                textBox1.Text = y.ToString();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            a = e.Location;
        }
        
    }
}
