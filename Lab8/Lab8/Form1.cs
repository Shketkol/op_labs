using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics myGrapfics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));

            //Point 1
            float x1 = 0;
            float y1 = 0;

            //Point 2
            float x2 = 800;
            float y2 = 0;

            //Point 3
            float x3 = 0;
            float y3 = 800;

            //Point 4
            float x4 = 800;
            float y4 = 800;

            double p = 0.08;

            for (int i = 1; i <= 50; i++) {
                myGrapfics.DrawLine(pen, x1, y1, x2, y2);
                myGrapfics.DrawLine(pen, x2, y2, x4, y4);
                myGrapfics.DrawLine(pen, x4, y4, x3, y3);
                myGrapfics.DrawLine(pen, x3, y3, x1, y1);

                float x1New = (float)(x1 + (x2 - x1) * p);
                float y1New = (float)(y1 + (y2 - y1) * p);

                float x2New = (float)(x2 + (x4 - x2) * p);
                float y2New = (float)(y2 + (y4 - y2) * p);

                float x3New = (float)(x3 + (x1 - x3) * p);
                float y3New = (float)(y3 + (y1 - y3) * p);

                float x4New = (float)(x4 + (x3 - x4) * p);
                float y4New = (float)(y4 + (y3 - y4) * p);

                x1 = x1New;
                y1 = y1New;
                x2 = x2New;
                y2 = y2New;
                x3 = x3New;
                y3 = y3New;
                x4 = x4New;
                y4 = y4New;
            }





            
        }
    }

}
