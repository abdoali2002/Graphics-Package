using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gr.Graphics_package
{
    internal class Bersenham_Drawing
    {
        private int X, Y, xEnd, P, yEnd;
        private point Start, End;
        private float slope;
        private int DeltaX, DeltaY;
        private int twoDeltaY, twoDeltaYMinusTwoDeltaX;
        int height, width;
        List<String> XPoint = new List<String>();
        List<String> YPoint = new List<String>();

        public Bersenham_Drawing(point Start, point End, int height, int width)
        {
            this.Start = Start;
            this.End = End;
            slope = Slope();
            this.width = width;
            this.height = height;
        }

        private void intiateConstants()
        {


            P = (2 * DeltaY) - DeltaX;
            twoDeltaY = 2 * DeltaY;
            twoDeltaYMinusTwoDeltaX = twoDeltaY - (2 * DeltaX);
        }
        public float Slope()
        {
            return ((float)End.GetYPoint() - (float)Start.GetYPoint()) / ((float)End.GetXPoint() - (float)Start.GetXPoint());
        }
        private int deltaX()
        {
            return xEnd - X;
        }
        private int deltaY()
        {
            return yEnd - Y;
        }

        private void nextPIfpos()
        {
            if (P < 0)
            {
                P = P + twoDeltaY;
            }
            else
            {
                Y++;
                P = P + twoDeltaYMinusTwoDeltaX;

            }
        }
        private void nextPIfneg()
        {
            if (P < 0)
            {
                P += twoDeltaY;

            }
            else
            {
                Y--;
                P += twoDeltaYMinusTwoDeltaX;

            }
        }
        private void swap(int x, int y)
        {
            int z;
            z = x;
            x = y;
            y = z;
        }
        public Bitmap drawLine(Bitmap p)
        {
            int Width = p.Width;
            int Height = p.Height;
           

            for (int i = 0; i < Width; i++)
            {
                p.SetPixel(i, height, Color.Gray);


            }

            for (int i = 0; i < Height; i++)
            {
                p.SetPixel(Width / 2, i, Color.Gray);


            }

            if (slope <= 1 && slope > 0)
            {
                if (Start.GetXPoint() < End.GetXPoint())
                {
                    fristOctant(p);
                }
                else
                {
                    fifthoctant(p);
                }
            }
            else if (slope > 1)
            {
                if (Start.GetYPoint() < End.GetYPoint())
                {
                    secondOctant(p);
                }
                else
                {
                    sixoctant(p);
                }
            }
            else if (slope < -1)
            {
                if (Start.GetYPoint() < End.GetYPoint())
                {
                    thirdOctant(p);
                }
                else
                {
                    seventhOctant(p);
                }
            }
            else if (slope >= -1 && slope < 0)
            {
                if (Start.GetXPoint() > End.GetXPoint())
                {
                    fourthOctant(p);
                }
                else
                {
                    lastOctant(p);
                }
            }

            return p;
        }
        private void originalInitiatePoint()
        {
            X = Start.GetXPoint();
            Y = Start.GetYPoint();
            xEnd = End.GetXPoint();
            yEnd = End.GetYPoint();
        }

        private void swappingpoint()
        {
            X = Start.GetYPoint();
            Y = Start.GetXPoint();
            xEnd = End.GetYPoint();
            yEnd = End.GetXPoint();
        }
        private void fristOctant(Bitmap p)
        {
            originalInitiatePoint();
            DeltaX = deltaX();
            DeltaY = deltaY();
            intiateConstants();

            p.SetPixel(X + width, height - Y, Color.Black);
            while (X < xEnd)
            {
                X += 1;
                nextPIfpos();
                p.SetPixel(X + width, height - Y, Color.Black);
                string px = Convert.ToString(X);
                string py = Convert.ToString(Y);
                XPoint.Add(px);
                YPoint.Add(py);
            }
            string AllPoint = "\tThe Line will be in first octant\n";
            string LinePoint = "LinePoint";
            for (int i = 0; i < XPoint.Count; i++)
            {
                AllPoint += "\t" + "X:" + XPoint[i] + "\t" + "Y:" + YPoint[i] + "\tPoint(" + XPoint[i] + "," + YPoint[i] + ")\n";


            }
            MessageBox.Show(AllPoint, LinePoint);
        }
        private void secondOctant(Bitmap p)
        {

            swappingpoint();
            DeltaX = deltaX();
            DeltaY = deltaY();
            intiateConstants();
            p.SetPixel(Y + width, height - X, Color.Orange);
            while (X < xEnd)
            {
                X += 1;
                nextPIfpos();
                p.SetPixel(Y + width, height - X, Color.Orange);
                string px = Convert.ToString(Y);
                string py = Convert.ToString(X);
                XPoint.Add(px);
                YPoint.Add(py);
            }
            string AllPoint = "\tThe Line will be in second octant\n";
            string LinePoint = "LinePoint";
            for (int i = 0; i < XPoint.Count; i++)
            {
                AllPoint += "\t" + "X:" + XPoint[i] + "\t" + "Y:" + YPoint[i] + "\tPoint(" + XPoint[i] + "," + YPoint[i] + ")\n";


            }
            MessageBox.Show(AllPoint, LinePoint);
        }
        private void thirdOctant(Bitmap p)
        {

            swappingpoint();
            DeltaX = deltaX();
            DeltaY = Math.Abs(deltaY());
            intiateConstants();
            p.SetPixel(X + width, height - Y, Color.DeepSkyBlue);
            while(X < xEnd)
            {
                X += 1;
                nextPIfneg();
                p.SetPixel(Y + width, height - X, Color.DeepSkyBlue);
                string px = Convert.ToString(Y);
                string py = Convert.ToString(X);
                XPoint.Add(px);
                YPoint.Add(py);
            }
            string AllPoint = "\tThe Line will be in third octant\n";
            string LinePoint = "LinePoint";
            for (int i = 0; i < XPoint.Count; i++)
            {
                AllPoint += "\t" + "X:" + XPoint[i] + "\t" + "Y:" + YPoint[i] + "\tPoint(" + XPoint[i] + "," + YPoint[i] + ")\n";


            }
            MessageBox.Show(AllPoint, LinePoint);

        }
        private void fourthOctant(Bitmap p)
        {
            originalInitiatePoint();
            DeltaX = Math.Abs(deltaX());
            DeltaY = Math.Abs(deltaY());
            intiateConstants();
            p.SetPixel(X + width, height - Y, Color.BurlyWood);
            while(X > xEnd)
            {
                X -= 1;
                nextPIfpos();
                p.SetPixel(X + width, height - Y, Color.BurlyWood);
                string px = Convert.ToString(X);
                string py = Convert.ToString(Y);
                XPoint.Add(px);
                YPoint.Add(py);
            }
            string AllPoint ="\tThe Line will be in forth octant\n";
            string LinePoint = "LinePoint";
            for (int i = 0; i < XPoint.Count; i++)
            {
                AllPoint += "\t" + "X:" + XPoint[i] + "\t" + "Y:" + YPoint[i] + "\tPoint(" + XPoint[i] + "," + YPoint[i] + ")\n";


            }
            MessageBox.Show(AllPoint, LinePoint);
        }
        private void fifthoctant(Bitmap p)
        {
            originalInitiatePoint();
            DeltaX = Math.Abs(deltaX());
            DeltaY = Math.Abs(deltaY());
            intiateConstants();
            p.SetPixel(X + width, height - Y, Color.DarkKhaki);
            while (X > xEnd)
            {
                X -= 1;
                nextPIfneg();
                p.SetPixel(X + width, height - Y, Color.DarkKhaki);
                string px = Convert.ToString(X);
                string py = Convert.ToString(Y);
                XPoint.Add(px);
                YPoint.Add(py);
            }
            string AllPoint = "\tThe Line will be in fifth octant\n";
            string LinePoint = "LinePoint";
            for (int i = 0; i < XPoint.Count; i++)
            {
                AllPoint += "\t" + "X:" + XPoint[i] + "\t" + "Y:" + YPoint[i] + "\tPoint(" + XPoint[i] + "," + YPoint[i] + ")\n";


            }
            MessageBox.Show(AllPoint, LinePoint);
        }
        public void sixoctant(Bitmap p)
        {
            swappingpoint();
            DeltaX = Math.Abs(deltaX());
            DeltaY = Math.Abs(deltaY());
            intiateConstants();
            p.SetPixel(Y + width, height - X, Color.Azure);
            while (X > xEnd)
            {
                X -= 1;
                nextPIfneg();
                p.SetPixel(Y + width, height - X, Color.Azure);
                string px = Convert.ToString(Y);
                string py = Convert.ToString(X);
                XPoint.Add(px);
                YPoint.Add(py);
            }
            string AllPoint = "\tThe Line will be in sixth octant\n";
            string LinePoint = "LinePoint";
            for (int i = 0; i < XPoint.Count; i++)
            {
                AllPoint += "\t" + "X:" + XPoint[i] + "\t" + "Y:" + YPoint[i] + "\tPoint(" + XPoint[i] + "," + YPoint[i] + ")\n";


            }
            MessageBox.Show(AllPoint, LinePoint);
        }
        private void seventhOctant(Bitmap p)
        {
            swappingpoint();
            DeltaX = Math.Abs(deltaX());
            DeltaY = Math.Abs(deltaY());
            intiateConstants();
            p.SetPixel(Y + width, height - X, Color.DarkSlateGray);
            while (X > xEnd)
            {
                X -= 1;
                nextPIfpos();
                p.SetPixel(Y + width, height - X, Color.DarkSlateGray);
                string px = Convert.ToString(Y);
                string py = Convert.ToString(X);
                XPoint.Add(px);
                YPoint.Add(py);
            }
            string AllPoint = "\tThe Line will be in seventh octant\n";
            string LinePoint = "LinePoint";
            for (int i = 0; i < XPoint.Count; i++)
            {
                AllPoint += "\t" + "X:" + XPoint[i] + "\t" + "Y:" + YPoint[i] + "\tPoint(" + XPoint[i] + "," + YPoint[i] + ")\n";


            }
            MessageBox.Show(AllPoint, LinePoint);
        }
        private void lastOctant(Bitmap p)
        {
            originalInitiatePoint();
            DeltaX = Math.Abs(deltaX());
            DeltaY = Math.Abs(deltaY());
            intiateConstants();
            p.SetPixel(X + width, Y, Color.CornflowerBlue);
            while(X < xEnd)
            {
                X += 1;
                nextPIfneg();
                p.SetPixel(X+width, height - Y, Color.CornflowerBlue);
                string px = Convert.ToString(X);
                string py = Convert.ToString(Y);
                XPoint.Add(px);
                YPoint.Add(py);
            }
            string AllPoint = null;
            string LinePoint = "\tThe Line will be in eighth octant\n";
            for (int i = 0; i < XPoint.Count; i++)
            {
                AllPoint += "\t" + "X:" + XPoint[i] + "\t" + "Y:" + YPoint[i] + "\tPoint(" + XPoint[i] + "," + YPoint[i] + ")\n";


            }
            MessageBox.Show(AllPoint, LinePoint);
        }
        public float returnP()
        {
            return slope;
        }
    }
}
