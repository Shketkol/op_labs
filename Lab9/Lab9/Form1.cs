using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Lab9
{
    public partial class Form1 : Form
    {
        private GraphicsPath path = new GraphicsPath();

        public Form1()
        {
            InitializeComponent();

            path = new GraphicsPath();
            BuildSerpinsky(path, new PointF(-200, 60), new PointF(0, -150), new PointF(200, 60), 7);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.TranslateTransform(Width / 2, Height / 2);
            e.Graphics.DrawPath(Pens.Black, path);
        }

        void BuildSerpinsky(GraphicsPath path, PointF p1, PointF p2, PointF p3, int iterations)
        {
            path.AddLine(p1, p2);
            path.AddLine(p2, p3);
            path.CloseFigure();

            iterations--;
            if (iterations > 0)
            {
                var p12 = new PointF(p1.X + (p2.X - p1.X) / 2, p1.Y + (p2.Y - p1.Y) / 2);
                var p23 = new PointF(p2.X + (p3.X - p2.X) / 2, p2.Y + (p3.Y - p2.Y) / 2);
                var p13 = new PointF(p1.X + (p3.X - p1.X) / 2, p1.Y + (p3.Y - p1.Y) / 2);

                BuildSerpinsky(path, p1, p12, p13, iterations);
                BuildSerpinsky(path, p12, p2, p23, iterations);
                BuildSerpinsky(path, p13, p23, p3, iterations);
            }
        }
    }
}
