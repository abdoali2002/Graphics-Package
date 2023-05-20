namespace Gr.Graphics_package
{
    internal class point
    {
        private int xPoint;
        private int yPoint;
        private int zPoint;

        public point(int xPoint, int yPoint)
        {
            this.xPoint = xPoint;
            this.yPoint = yPoint;
        }
        public point(int xPoint, int yPoint, int zPoint)
        {
            this.xPoint = xPoint;
            this.yPoint = yPoint;
            this.zPoint = zPoint;
        }

        public int GetXPoint()
        {
            return this.xPoint;
        }

        public int GetYPoint()
        {
            return this.yPoint;
        }

        public int GetZPoint()
        {
            return this.zPoint;
        }


    }
}
