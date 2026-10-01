using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace LabCSharp0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 300;
            timer1.Tick += new EventHandler(BgTimer_Tick);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Want to go up?", "Warning", MessageBoxButtons.YesNo);
            if (MessageBox.Show("Are you sure you want to go down?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                option.Text = "UP";
                textBox1.Text = "UP";
                this.Location = new Point(this.Location.X, this.Location.Y - 10);
            }
            else
            {
                option.Text = "CANCELLED";
            }
        }

        private void left_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Want to go left?", "Warning", MessageBoxButtons.YesNo);
            if (MessageBox.Show("Are you sure you want to go down?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                option.Text = "LEFT";
                textBox1.Text = "LEFT";
                this.Location = new Point(this.Location.X - 10, this.Location.Y);
            }
            else
            {
                option.Text = "CANCELLED";
            }
        }

        private void down_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Want to go down?", "Information", MessageBoxButtons.YesNo);
            if(MessageBox.Show("Are you sure you want to go down?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                option.Text = "DOWN";
                textBox1.Text = "DOWN";
                this.Location = new Point(this.Location.X, this.Location.Y + 10);
            }
            else
            {
                option.Text = "CANCELLED";
            }
        }

        private void right_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Want to go right?", "Warning", MessageBoxButtons.OKCancel);
            if (MessageBox.Show("Are you sure you want to go down?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                option.Text = "RIGHT";
                textBox1.Text = "RIGHT";
                this.Location = new Point(this.Location.X + 10, this.Location.Y);
            }
            else
            {
                option.Text = "CANCELLED";
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void BgTimer_Tick(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(
            random.Next(256),
            random.Next(256),
            random.Next(256)
            );

            this.BackColor = randomColor;
        }
    }
}
