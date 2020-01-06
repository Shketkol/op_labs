using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics myGraphics = e.Graphics;
            Pen myPen = new Pen(Color.Blue, 2);
            
            //Surnasname
            myGraphics.DrawLine(myPen, 10, 10, 10, 60);
            myGraphics.DrawLine(myPen, 30, 10, 30, 60);
            myGraphics.DrawLine(myPen, 50, 10, 50, 60);
            myGraphics.DrawLine(myPen, 10, 60, 50, 60);

            myGraphics.DrawLine(myPen, 70, 10, 70, 60);
            myGraphics.DrawLine(myPen, 70, 30, 100, 10);
            myGraphics.DrawLine(myPen, 70, 30, 100, 60);

            myGraphics.DrawLine(myPen, 110, 10, 110, 60);

            myGraphics.DrawLine(myPen, 120, 10, 150, 10);
            myGraphics.DrawLine(myPen, 135, 10, 135, 60);

            //Name
            myGraphics.DrawLine(myPen, 180, 10, 180, 60);
            myGraphics.DrawLine(myPen, 180, 10, 200, 30);
            myGraphics.DrawLine(myPen, 200, 30, 220, 10);
            myGraphics.DrawLine(myPen, 220, 10, 220, 60);

            myGraphics.DrawLine(myPen, 230, 10, 230, 60);
            myGraphics.DrawLine(myPen, 230, 60, 250, 10);
            myGraphics.DrawLine(myPen, 250, 10, 250, 60);

            myGraphics.DrawLine(myPen, 260, 10, 260, 60);
            myGraphics.DrawLine(myPen, 260, 30, 280, 10);
            myGraphics.DrawLine(myPen, 260, 30, 280, 60);

            myGraphics.DrawLine(myPen, 290, 10, 320, 10);
            myGraphics.DrawLine(myPen, 290, 60, 320, 60);
            myGraphics.DrawLine(myPen, 290, 10, 290, 60);
            myGraphics.DrawLine(myPen, 320, 10, 320, 60);

            myGraphics.DrawLine(myPen, 330, 60, 340, 10);
            myGraphics.DrawLine(myPen, 340, 10, 350, 60);

            myGraphics.DrawLine(myPen, 360, 60, 370, 10);
            myGraphics.DrawLine(myPen, 370, 10, 380, 60);
            myGraphics.DrawLine(myPen, 365, 30, 375, 30);

            //Patromic
            myGraphics.DrawLine(myPen, 400, 60, 410, 10);
            myGraphics.DrawLine(myPen, 410, 10, 420, 60);
            myGraphics.DrawLine(myPen, 405, 30, 415, 30);

            myGraphics.DrawLine(myPen, 430, 10, 430, 10);
            myGraphics.DrawLine(myPen, 430, 30, 450, 30);
            myGraphics.DrawLine(myPen, 450, 10, 450, 60);


            myGraphics.Dispose();



        }
    }
}
