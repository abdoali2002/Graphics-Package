using Gr.Graphics_package;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gr
{
    public partial class Form1 : Form
    {
        Bitmap pic;
        int width;
        int height;
        Transformations2D transformations = new Transformations2D();
        polygon shape;
        Graphics draw;
        List<point> points = new List<point>();
        private object p;

        public Form1()
        {
            InitializeComponent();
            Bitmap bitmap = clearDrawingWindow();
            pic = bitmap;
            draw = picture.CreateGraphics();

            picture.Image = pic;
            width = picture.Width / 2;
            height = picture.Height / 2;
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            point start = new point(Convert.ToInt32(xStartPoint.Text)+width, height - Convert.ToInt32(yStartPoint.Text));
            point end = new point(Convert.ToInt32(xEndPoint.Text)+width, height - Convert.ToInt32(yEndPoint.Text));
            pic = new DDA_drawing(start,end).drawLine(pic);
            picture.Image = pic;
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            point start = new point(Convert.ToInt32(xStartPoint.Text), Convert.ToInt32(yStartPoint.Text));
            point end = new point(Convert.ToInt32(xEndPoint.Text), Convert.ToInt32(yEndPoint.Text));
            Bersenham_Drawing Ber = new Bersenham_Drawing(start, end, height, width);
            pic = Ber.drawLine(pic);
            picture.Image = pic;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            point Center = new point(Convert.ToInt32(xCenter.Text) + width, height - Convert.ToInt32(yCenter.Text));
            int Radius = Convert.ToInt32(RadiusTextBox.Text);
            pic = new Circle(Center, Radius).drawCircle(pic);
            picture.Image = pic;
            
        }

       private void button4_Click(object sender, EventArgs e)
        {
            point Center = new point(Convert.ToInt32(xCenterElipse.Text) + width,
               height - Convert.ToInt32(yCenterElipse.Text));
            int RadiusX = Convert.ToInt32(radiusX.Text);
            int RadiusY = Convert.ToInt32(radiusY.Text);
            pic = new Elipse(Center, RadiusX, RadiusY).drawElipse(pic);
            picture.Image = pic;

        }

        
        private Bitmap clearDrawingWindow()
        {
            Bitmap p = new Bitmap(picture.Width, picture.Height);
            return p;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pic = clearDrawingWindow();
            picture.Image = pic;
           
        }

        private void addPolygon_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(xPoint1.Text);
            int x2 = Convert.ToInt32(xPoint2.Text);
            int x3 = Convert.ToInt32(xPoint3.Text);
            int x4 = Convert.ToInt32(xPoint4.Text);
            int y1 = Convert.ToInt32(yPoint1.Text);
            int y2 = Convert.ToInt32(yPoint2.Text);
            int y3 = Convert.ToInt32(yPoint3.Text);
            int y4 = Convert.ToInt32(yPoint4.Text);
            List<point> points = new List<point>();
            points.Add(new point(x1, y1));
            points.Add(new point(x2, y2));
            points.Add(new point(x3, y3));
            points.Add(new point(x4, y4));
            shape = new polygon(points);

            Point p1 = new Point(x1 + width, height - y1);
            Point p2 = new Point(x2 + width, height - y2);
            Point p3 = new Point(x3 + width, height - y3);
            Point p4 = new Point(x4 + width, height - y4);
             Brush brush = new SolidBrush(Color.Red);
             Pen redBrush = new Pen(brush, 1);
             draw.DrawLine(redBrush, p1, p2);
             draw.DrawLine(redBrush, p2, p3);
             draw.DrawLine(redBrush, p3, p4);
             draw.DrawLine(redBrush, p1, p4);
        }

        static void multiply(int[,] mat1,
                       int[,] mat2, int[,] res)
        {
            int N = 3;
            int i, j, k;
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    res[i, j] = 0;
                    for (k = 0; k < N; k++)
                        res[i, j] += mat1[i, k]
                                     * mat2[k, j];
                }
            }
        }
        static void multiply(double[,] mat1,
                       double[,] mat2, double[,] res)
        {
            int N = 3;
            int i, j, k;
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    res[i, j] = 0;
                    for (k = 0; k < N; k++)
                        res[i, j] += mat1[i, k]
                                     * mat2[k, j];
                }
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int translationX = 0;
            int translationY = 0;
            if (xMatrix.Text != "")
            {
                translationX = Convert.ToInt32(xMatrix.Text);
            }
            if (yMatrix.Text != "")
            {
                translationY = Convert.ToInt32(yMatrix.Text);
            }
            polygon translated = transformations.Translation(shape, translationX, translationY);
            drawPolygon(translated);

        }

       

        private void Scalling2D_Click(object sender, EventArgs e)
        {
            int ScaleX = 1;
            int ScaleY = 1;
            if (xMatrix.Text != "")
            {
                ScaleX = Convert.ToInt32(xMatrix.Text);
            }
            if (yMatrix.Text != "")
            {
                ScaleY = Convert.ToInt32(yMatrix.Text);
            }
            polygon ScalledPolygon = transformations.Scalling(shape, ScaleX, ScaleY);
            drawPolygon(ScalledPolygon);
        }

        private void xReflect_Click(object sender, EventArgs e)
        {
            drawPolygon(transformations.reflectX(shape));
        }

        private void yReflect_Click(object sender, EventArgs e)
        {
            drawPolygon(transformations.reflectY(shape));
        }

        private void originReflect_Click(object sender, EventArgs e)
        {
            drawPolygon(transformations.reflectOrigin(shape));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (ShearX.Text != null)
            {
                polygon ShearedPolygon = transformations.polygonShearX(shape, Convert.ToInt32(ShearX.Text));
                drawPolygon(ShearedPolygon);

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (ShearY.Text != null)
            {
                polygon ShearedPolygon = transformations.polygonShearY(shape, Convert.ToInt32(ShearY.Text));
                drawPolygon(ShearedPolygon);

            }
        }
        private void drawPolygon(polygon shape)
        {
            List<point> polygonPoints = shape.GetPoints();
            Brush brush = new SolidBrush(Color.Blue);
            Pen blueBrush = new Pen(brush, 1);
            draw.DrawLine(blueBrush,
                width + polygonPoints[0].GetXPoint(),
                height - polygonPoints[0].GetYPoint(),
                width + polygonPoints[1].GetXPoint(),
                height - polygonPoints[1].GetYPoint());
            draw.DrawLine(blueBrush,
                width + polygonPoints[1].GetXPoint(),
                height - polygonPoints[1].GetYPoint(),
                width + polygonPoints[2].GetXPoint(),
                height - polygonPoints[2].GetYPoint());
            draw.DrawLine(blueBrush,
                width + polygonPoints[2].GetXPoint(),
                height - polygonPoints[2].GetYPoint(),
                width + polygonPoints[3].GetXPoint(),
                height - polygonPoints[3].GetYPoint());
            draw.DrawLine(blueBrush,
                width + polygonPoints[3].GetXPoint(),
                height - polygonPoints[3].GetYPoint(),
                width + polygonPoints[0].GetXPoint(),
                height - polygonPoints[0].GetYPoint());
        }

        private void Rotation_Click(object sender, EventArgs e)
        {
            if (angle.Text != null)
            {
                polygon result = transformations.Rotation(shape, Convert.ToInt32(angle.Text));
                drawPolygon(result);
            }
        }

        private void xStartPoint_TextChanged(object sender, EventArgs e)
        {

        }
        private void Drawline(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click_1(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void xCenterElipse_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void xEndPoint_TextChanged(object sender, EventArgs e)
        {

        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void yEndPoint_TextChanged(object sender, EventArgs e)
        {

        }
        private void yPoint3_TextChanged(object sender, EventArgs e)
        {

        }




    }
}
















































       