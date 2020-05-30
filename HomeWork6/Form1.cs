using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork7
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        double th1 ;
        double th2 ;
        double per1;
        double per2;
        int n;
        double length;
        string pen;


        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) {
                graphics = this.panel1.CreateGraphics();
            }
            drawCayleyTree(200,300,-Math.PI/2);
        }

        void drawCayleyTree(double x0,double y0,double th)
        {
            if (n == 0) return;

            double x1 = x0 + length * Math.Cos(th);
            double y1 = y0+ length * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree1(n-1,x1,y1,per1*length,th+th1);
            drawCayleyTree1(n-1,x1,y1,per2*length,th-th2);

        }

        void drawCayleyTree1(int n,double x0,double y0,double length,double th)
        {
            if (n == 0) return;

            double x1 = x0 + length * Math.Cos(th);
            double y1 = y0 + length * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree1(n - 1, x1, y1, per1 * length, th + th1);
            drawCayleyTree1(n - 1, x1, y1, per2 * length, th - th2);
        }

        void drawLine(double x0,double y0,double x1,double y1)
        {
            switch (pen) {
                case "红色":
                    graphics.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "蓝色":
                    graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "黑色":
                    graphics.DrawLine(Pens.Black, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "紫色":
                    graphics.DrawLine(Pens.Purple, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "绿色":
                    graphics.DrawLine(Pens.Green, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try {
                n = int.Parse(text_depth.Text);
            }
            catch (Exception m)
            {
                Console.Write("请输入数字");
                text_depth.Text = "";
            }
                       
        }

        private void textLength_TextChanged(object sender, EventArgs e)
        {          
            try
            {
                length = double.Parse(textLength.Text);
            }
            catch (Exception m)
            {
                Console.Write("请输入数字");
                textLength.Text = "";
            }
        }

        private void textPer1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                per1 = double.Parse(textPer1.Text);
            }
            catch (Exception m)
            {
                Console.Write("请输入数字");
                textPer1.Text = "";
            }
        }

        private void textPer2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                per2 = double.Parse(textPer2.Text);
            }
            catch (Exception m)
            {
                Console.Write("请输入数字");
                textPer2.Text = "";
            }
        }

        private void textTh1_TextChanged(object sender, EventArgs e)
        {            
            try
            {
                th1 = double.Parse(textTh1.Text) * Math.PI / 180;
            }
            catch (Exception m)
            {
                Console.Write("请输入数字");
                textTh1.Text = "";
            }
        }

        private void textTh2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                th2 = double.Parse(textTh2.Text) * Math.PI / 180;
            }
            catch (Exception m)
            {
                Console.Write("请输入数字");
                textTh2.Text = "";
            }
        }

        private void comboBox1Pen_SelectedIndexChanged(object sender, EventArgs e)
        {
            pen = comboBox1Pen.Text;           
        }
    }
}
