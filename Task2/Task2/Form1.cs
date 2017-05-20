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
                  //  this.Controls.Add(b[i, j]);
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
            int q = a.X / 50 + 1, w = a.Y / 50 + 1;
            MessageBox.Show(q.ToString() + " " +  w.ToString());
            int x = int.Parse(b[q, w].Text);
            ++x;
            b[q, w].Text = x.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(button1.Text);
            ++x;
            button1.Text = x.ToString();
            if (isPrime(x))
            {
                int y = int.Parse(textBox1.Text);
                ++y;
                textBox1.Text = y.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(button2.Text);
            ++x;
            button2.Text = x.ToString();
            if (isPrime(x))
            {
                int y = int.Parse(textBox1.Text);
                ++y;
                textBox1.Text = y.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(button3.Text);
            ++x;
            button3.Text = x.ToString();
            if (isPrime(x))
            {
                int y = int.Parse(textBox1.Text);
                ++y;
                textBox1.Text = y.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int x = int.Parse(button6.Text);
            ++x;
            button6.Text = x.ToString();
            if (isPrime(x))
            {
                int y = int.Parse(textBox1.Text);
                ++y;
                textBox1.Text = y.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = int.Parse(button5.Text);
            ++x;
            button5.Text = x.ToString();
            if (isPrime(x))
            {
                int y = int.Parse(textBox1.Text);
                ++y;
                textBox1.Text = y.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = int.Parse(button4.Text);
            ++x;
            button4.Text = x.ToString();
            if (isPrime(x))
            {
                int y = int.Parse(textBox1.Text);
                ++y;
                textBox1.Text = y.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int x = int.Parse(button9.Text);
            ++x;
            button9.Text = x.ToString();
            if (isPrime(x))
            {
                int y = int.Parse(textBox1.Text);
                ++y;
                textBox1.Text = y.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int x = int.Parse(button8.Text);
            ++x;
            button8.Text = x.ToString();
            if (isPrime(x))
            {
                int y = int.Parse(textBox1.Text);
                ++y;
                textBox1.Text = y.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int x = int.Parse(button7.Text);
            ++x;
            button7.Text = x.ToString();
            if (isPrime(x))
            {
                int y = int.Parse(textBox1.Text);
                ++y;
                textBox1.Text = y.ToString();
            }
        }
    }
}
