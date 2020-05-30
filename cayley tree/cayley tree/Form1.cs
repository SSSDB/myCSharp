using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cayley_tree
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        public double th1;
        public double th2;
        public double per1;
        public double per2;
        public int n;
        public double length;
        public string pen;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            n = int.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            length = double.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            per1 = double.Parse(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            per2 = double.Parse(textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            th1 = double.Parse(textBox5.Text) * Math.PI / 180;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            th2 = double.Parse(textBox6.Text) * Math.PI / 180;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pen = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null)
                graphics = this.panel1.CreateGraphics();
            else
                graphics.Clear(panel1.BackColor);
            drawCayleyTree(200, 400, -Math.PI / 2);
        }

        void drawCayleyTree(double x0, double y0, double th)
        {
            if (n == 0) return;
            double x1 = x0 + length * Math.Cos(th);
            double y1 = y0 + length * Math.Sin(th);

            drawLine(x0, y0, x1, y1);
            drawCayleyTree1(n - 1, x1, y1, per1 * length, th + th1);
            drawCayleyTree1(n - 1, x1, y1, per2 * length, th - th2);
        }

        void drawCayleyTree1(int n, double x0, double y0, double length, double th)
        {
            if (n == 0) return;
            double x1 = x0 + length * Math.Cos(th);
            double y1 = y0 + length * Math.Sin(th);

            drawLine(x0, y0, x1, y1);
            drawCayleyTree1(n - 1, x1, y1, per1 * length, th + th1);
            drawCayleyTree1(n - 1, x1, y1, per2 * length, th - th2);
        }

        void drawLine(double x0, double y0, double x1, double y1)
        {
            switch (pen)
            {
                case "黑色":
                    graphics.DrawLine(Pens.Black, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "红色":
                    graphics.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "紫色":
                    graphics.DrawLine(Pens.Purple, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "蓝色":
                    graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;                              
            }
        }
    }
}
