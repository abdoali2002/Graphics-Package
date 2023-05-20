using System.Collections.Generic;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Gr.Graphics_package
{
    internal class Circle
    {
        private point Center;
        private int Radius;
        private int decisionParameter;
        List<String> XPoint = new List<String>();
        List<String> YPoint = new List<String>();

        public Circle(point center, int radius)
        {
            this.Center = center;
            this.Radius = radius;
        }

        public Bitmap drawCircle(Bitmap p)
        {
            int x = 0;
            int y = Radius;
            int xCenter = Center.GetXPoint();
            int yCenter = Center.GetYPoint();
            decisionParameter = 1 - Radius;
            int Width = p.Width;
            int width = p.Width / 2;
            int Height = p.Height;
            int height = p.Height / 2;
            



            for (int i = 0; i < Width; i++)
            {
                p.SetPixel(i, height, Color.Gray);


            }

            for (int i = 0; i < Height; i++)
            {
                p.SetPixel(Width / 2, i, Color.Gray);


            }
            CirclePoints(x, y, xCenter, yCenter, p);
            while(x < y)
            {
                x++;
                if (decisionParameter < 0)
                {
                    decisionParameter += 2 * x + 1;
                }
                else
                {
                    y--;
                    decisionParameter += 2 * (x - y) + 1;
                }
                CirclePoints(x, y, xCenter, yCenter, p);
            }
            ShowPoint(XPoint, YPoint);
            return p;
           
        }

        private void CirclePoints(int x, int y, int xCenter, int yCenter, Bitmap p)
        {
            p.SetPixel(xCenter + x, yCenter + y, Color.Lime);string FOx = Convert.ToString(x);string FOy = Convert.ToString(y);XPoint.Add(FOx);YPoint.Add(FOy);
            p.SetPixel(xCenter - x, yCenter + y, Color.Lime);//string SOx = Convert.ToString(xCenter - x); string SOy = Convert.ToString(yCenter + y); XPoint.Add(SOx); YPoint.Add(SOy);
            p.SetPixel(xCenter + x, yCenter - y, Color.Lime);//string TOx = Convert.ToString(xCenter + x); string TOy = Convert.ToString(yCenter - y); XPoint.Add(TOx); YPoint.Add(TOy);
            p.SetPixel(xCenter - x, yCenter - y, Color.Lime);//string FoOx = Convert.ToString(xCenter - x); string FoOy = Convert.ToString(yCenter - y); XPoint.Add(FoOx); YPoint.Add(FoOy);
            p.SetPixel(xCenter + y, yCenter + x, Color.Lime);//string FiOx = Convert.ToString(xCenter + y); string FiOy = Convert.ToString(yCenter + x); XPoint.Add(FiOx); YPoint.Add(FiOy);
            p.SetPixel(xCenter + y, yCenter - x, Color.Lime);//string SiOx = Convert.ToString(xCenter + y); string SiOy = Convert.ToString(yCenter - x); XPoint.Add(SiOx); YPoint.Add(SiOy);
            p.SetPixel(xCenter - y, yCenter + x, Color.Lime);//string SeOx = Convert.ToString(xCenter + y); string SeOy = Convert.ToString(yCenter - x); XPoint.Add(SeOx); YPoint.Add(SeOy);
            p.SetPixel(xCenter - y, yCenter - x, Color.Lime);//string EOx = Convert.ToString(xCenter + y); string EOy = Convert.ToString(yCenter - x); XPoint.Add(EOx); YPoint.Add(EOy);
           
        }
        private void ShowPoint(List<string> xPoint, List<string> yPoint)
        {
            string AllPoint = "\t Circle Point\n";
            string CirclePoint = "CirclePoint";
            for (int i = 0; i < XPoint.Count; i++)
            {
                AllPoint += "\t" + "X:" + XPoint[i] + "\t" + "Y:" + YPoint[i] + "\tPoint(" + XPoint[i] + "," + YPoint[i] + ")\n";


            }
            MessageBox.Show(AllPoint, CirclePoint);
        }


    }
}
