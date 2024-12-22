﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_Laba_5
{
    class Square : Figure
    {
        private int sizeLength;
        public Square(int centerX, int centerY, int size)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.sizeLength = size;
            status = true;
        }
        public override void DrawBlack(Graphics graphics)
        {
            graphics.DrawPolygon(Pens.Black, GetCurrPoints());
        }

        public override void HideDrawingBackGround(Graphics graphics)
        {
            graphics.DrawPolygon(new Pen(Form1.ActiveForm.BackColor), GetCurrPoints());
        }

        private Point[] GetCurrPoints()
        {
            return new Point[] {
                new Point(centerX - sizeLength,  centerY - sizeLength),
                new Point(centerX - sizeLength,  centerY + sizeLength),
                new Point(centerX + sizeLength,  centerY + sizeLength),
                new Point(centerX + sizeLength,  centerY - sizeLength),
            };
        }

    }
}
