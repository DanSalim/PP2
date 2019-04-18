using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rain
{
    public partial class Form1 : Form
    {
        List<Drop> rain = new List<Drop>();
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 100; i++)
                rain.Add(CreateRandomDrop());
        }
        private Drop CreateRandomDrop()
        {
            return new Drop
            { 
                Position = new PointF(rnd.Next(this.Width), rnd.Next(this.Height)),
                YSpeed = (float)rnd.NextDouble() * 3 + 2
            };
        }
        private void UpdateRain()
        {
            foreach (var drop in rain)
            {
                drop.Fall();
                if (drop.Position.Y > this.Height)
                    drop.Position.Y = 0;
            }
        }
        private void RenderRain()
        {
            using (var grp = this.CreateGraphics())
            {
                grp.Clear(Color.DarkBlue);
                foreach (var drop in rain)
                    grp.DrawLine(Pens.Red, drop.Position, new PointF(drop.Position.X, drop.Position.Y + 30));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateRain();
            RenderRain();
        }
        class Drop
        {
            public PointF Position;
            public float YSpeed;
            public void Fall() => Position.Y += YSpeed;
        }
    }
}
