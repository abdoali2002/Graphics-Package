using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gr.Graphics_package
{
    internal class Elipse
    {
        private point center;
        private int radiusX;
        private int radiusY;
        private int decisionParameter;
        List<String> XPoint = new List<String>();
        List<String> YPoint = new List<String>();


        public Elipse(point center, int radiusX, int radiusY)
        {
            this.center = center;
            this.radiusX = radiusX;
            this.radiusY = radiusY;
        }

        public Bitmap drawElipse(Bitmap p)
        {
            int x = 0;
            int y = radiusY;
            int xCenter = center.GetXPoint();
            int yCenter = center.GetYPoint();
            int rx2 = (int)Math.Pow(radiusX, 2);
            int ry2 = (int)Math.Pow(radiusY, 2);
            decisionParameter = ry2 - rx2 * radiusY + (rx2 / 4);
            int parameterIncrementX = 2 * ry2 * x;
            int parameterIncrementY = 2 * rx2 * y;
            ElipsePoints(x, y, xCenter, yCenter, p);
            int Height = p.Height;
            int height = p.Height / 2;
            int Width = p.Width;
            int width = p.Width / 2;
            for (int i = 0; i < Width; i++)
            {
                p.SetPixel(i, height, Color.Gray);


            }

            for (int i = 0; i < Height; i++)
            {
                p.SetPixel(Width / 2, i, Color.Gray);


            }
            while (parameterIncrementX <= parameterIncrementY)
            {
                    x++;
                    parameterIncrementX += 2 * ry2;
                    if(decisionParameter < 0)
                    {
                        decisionParameter += (parameterIncrementX + ry2);
                    }
                    else
                    {
                        y--;
                        parameterIncrementY -= 2 * rx2;
                        decisionParameter += (parameterIncrementX - parameterIncrementY + ry2);
                    }
                ElipsePoints(x, y, xCenter, yCenter, p);
            }
            decisionParameter = (int)(ry2 * Math.Pow((x + 0.5), 2) + rx2 * Math.Pow((y - 1), 2) - rx2 * ry2);
            while(y >= 0)
            {
                y--;
                parameterIncrementY -= 2 * rx2;
                if(decisionParameter > 0)
                {
                    decisionParameter += rx2 - parameterIncrementY;
                }
                else
                {
                    x++;
                    parameterIncrementX += 2 * ry2;
                    decisionParameter += parameterIncrementX - parameterIncrementY + rx2;
                }
                ElipsePoints(x, y, xCenter, yCenter, p);
            }
            ShowPoint(XPoint, YPoint);
            return p;
        }


        private void ElipsePoints(int x, int y, int xCenter, int yCenter, Bitmap p)
        {
            p.SetPixel(xCenter + x, yCenter + y, Color.Olive); string FOx = Convert.ToString(x); string FOy = Convert.ToString(y); XPoint.Add(FOx); YPoint.Add(FOy);
            p.SetPixel(xCenter + x, yCenter - y, Color.Olive);
            p.SetPixel(xCenter - x, yCenter + y, Color.Olive);
            p.SetPixel(xCenter - x, yCenter - y, Color.Olive);
        }
        private void ShowPoint(List<string> xPoint, List<string> yPoint)
        {
            string AllPoint = "\t Elipse Point\n";
            string ElipsePoint = "ElipseePoint";
            for (int i = 0; i < XPoint.Count; i++)
            {
                AllPoint += "\t" + "X:" + XPoint[i] + "\t" + "Y:" + YPoint[i] + "\tPoint(" + XPoint[i] + "," + YPoint[i] + ")\n";


            }
            MessageBox.Show(AllPoint, ElipsePoint);
        }

    }
}
