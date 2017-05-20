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
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                {
                    Button b = new Button();
                    b.Text = "0";
                    b.Location = new Point(i * 30, j * 30);
                    b.Size = new Size(30, 30);
                    b.Click += new EventHandler(button_Click);
                    this.Controls.Add(b);
                }
        }

        private void button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
