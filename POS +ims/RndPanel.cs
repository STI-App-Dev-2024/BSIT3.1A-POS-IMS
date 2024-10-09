﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace POS__ims
{
    public class RndPanel : Panel
    {
        //Fields
        private int borderRadius = 30;
        private float gradientAngle = 90F;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.DodgerBlue;

        //Constructor
        public RndPanel(){
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(450, 300);
        }

        //Properties
        public int BorderRadius { 
            get => borderRadius; 
            set { borderRadius = value; this.Invalidate(); } 
        }
        public float GradientAngle { 
            get => gradientAngle; 
            set { gradientAngle = value; this.Invalidate(); } 
        }
        public Color GradientTopColor { 
            get => gradientTopColor; 
            set { gradientTopColor = value; this.Invalidate(); } 
        }
        public Color GradientBottomColor { 
            get => gradientBottomColor; 
            set { gradientBottomColor = value; this.Invalidate(); } 
        }

        //Methods
        private GraphicsPath GetRndPath(RectangleF rectangle, float radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            graphicsPath.CloseFigure();
            return graphicsPath;
        }

        //Override Methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brushRnd = new LinearGradientBrush(this.ClientRectangle, this.GradientTopColor, this.gradientBottomColor, this.gradientAngle);
            Graphics graphicsRnd = e.Graphics;
            graphicsRnd.FillRectangle(brushRnd, ClientRectangle);


            //BorderRadius
            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);

            if (borderRadius > 2) {
                using (GraphicsPath graphicsPath = GetRndPath(rectangleF, borderRadius))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(graphicsPath);
                    e.Graphics.DrawPath(pen, graphicsPath);
                }
            }
            else this.Region = new Region(rectangleF);
        }
    }
}