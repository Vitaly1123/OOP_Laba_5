using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_Laba_5
{
    class Rhomb : Figure
    {
        private int horDiagLen;
        private int vertDiagLen;
        public Rhomb(int centerX, int centerY, int horDiagLen, int vertDiagLen)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.horDiagLen = horDiagLen;
            this.vertDiagLen = vertDiagLen;
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
                new Point(centerX - horDiagLen / 2,  centerY),
                new Point(centerX,  centerY + vertDiagLen / 2),
                new Point(centerX + horDiagLen / 2,  centerY),
                new Point(centerX,  centerY - vertDiagLen / 2),
            };
        }

    }
}
