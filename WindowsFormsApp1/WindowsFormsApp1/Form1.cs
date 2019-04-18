using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float x = 150;
        float y = 1;
        float yspeed = 1;

        public void fall()
        {
            y = y + yspeed;
            if (y >= 350)
            {
                y = 0;
            }
        }

        public void Show(float a, float b)
        {
            Graphics g;
            g = this.CreateGraphics();
            Pen myPen = new Pen(Color.MediumPurple);
            myPen.Width = 2;
            Pen myErase = new Pen(Color.Lavender);
            myErase.Width = 2;
            g.DrawLine(myErase, a, b - 1, a, b + 15);
            g.DrawLine(myPen, a, b, a, b + 15);
        }
        void Draw()
        {
            for(int i =0; i < 10; i++)
            {
                Show(x, y);
                fall();
            }
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
