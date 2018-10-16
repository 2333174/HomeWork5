using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double th1,th2;
        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics != null) graphics.Clear(Color.White);
            if (graphics == null) graphics = this.CreateGraphics();
            int n = int.Parse(this.textBox1.Text);
            int m = int.Parse(this.textBox2.Text);
            int n1 = int.Parse(this.textBox3.Text);
            int m1 = int.Parse(this.textBox4.Text);
            th1 = n1 * Math.PI / 180;
            th2 = m1 * Math.PI / 180;
            drawCayleyTree(10, 200, 310, n, -m * Math.PI / 180);
        }
        private Graphics graphics;
        double per1 = 0.6;
        double per2 = 0.7;
        float width;
        int red;
        int blue;
        int green;
        void drawCayleyTree(int n, double x0, double y0,double leng,double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th) + (leng/15.0) * Math.Cos(th + th1);
            double y1 = y0 + leng * Math.Sin(th) + (leng/ 15.0) * Math.Sin(th + th1);
            double x2 = x0 + leng * Math.Cos(th) + (leng / 15.0) * Math.Cos(th - th2);
            double y2 = y0 + leng * Math.Sin(th) + (leng /15.0) * Math.Sin(th -th2);
          
            double x3 = x0 + leng * Math.Cos(th);
            double y3 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x3, y3);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x2, y2, per2 * leng, th - th2);
        }
        void drawLine(double x0,double y0,double x1,double y1)
        {
            width = float.Parse(this.textBox5.Text);
            red = int.Parse(this.textBox6.Text);
            green = int.Parse(this.textBox7.Text);
            blue= int.Parse(this.textBox8.Text);
            graphics.DrawLine(new Pen(Color.FromArgb(red,green,blue),width), (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
