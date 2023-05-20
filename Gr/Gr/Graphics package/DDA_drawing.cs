using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gr.Graphics_package
{
    internal class DDA_drawing
    {
        private point Start;
        private point End;
        private int steps;
        private float xIncrement;
        private float yIncrement;
        List<String> XPoint = new List<String>();
        List<String> YPoint = new List<String>();


        public DDA_drawing(point start, point end)
        {
            this.Start = start;
            this.End = end;
        }

        

        private int DeltaX()
        {
            return End.GetXPoint() - Start.GetXPoint();
        }

        private int DeltaY()
        {
            return End.GetYPoint() - Start.GetYPoint();
        }

        private void setSteps()
        {
            if (DeltaY() < DeltaX())
            {
                steps = Math.Abs(DeltaX());
            }
            else
            {
                steps = Math.Abs(DeltaY());


            }
                
        }

        private void setIncrements()
        {
            xIncrement = DeltaX() / (float)steps;
            yIncrement = DeltaY() / (float)steps;
        }

        public Bitmap drawLine(Bitmap p)
        {

            setSteps();
            setIncrements();
            float x = Start.GetXPoint();
            float y = Start.GetYPoint();
            int Width = p.Width;
            int width = p.Width / 2;
            int Height = p.Height;
            int height = p.Height / 2;
            p.SetPixel((int)x, (int)y, Color.Red);
           
            


            for (int i = 0; i < Width; i++)
            {
                p.SetPixel(i, height, Color.Gray);


            }

            for (int i = 0; i < Height; i++)
            {
                p.SetPixel(Width / 2, i, Color.Gray);


            }

            for (int i = 0; i < steps; i++)
            {
                x += xIncrement;
                y += yIncrement;
                p.SetPixel((int)Math.Round(x), (int)Math.Round(y), Color.Red);
                string px = Convert.ToString (Math.Round(x) - width );
                string py = Convert.ToString( height- Math.Round(y));
                XPoint.Add(px);
                YPoint.Add(py);
            }
            string AllPoint = null;
            string LinePoint = "LinePoint";
            for (int i = 0; i < XPoint.Count; i++)
            {
                  AllPoint += "\t" + "X:"+ XPoint[i] +"\t"+ "Y:" + YPoint[i]+"\tPoint("+XPoint[i]+"," + YPoint[i]+")\n";
                

            }
            MessageBox.Show(AllPoint,LinePoint);
            


            return p;
            


        }
       

        
             
        
    }
}
