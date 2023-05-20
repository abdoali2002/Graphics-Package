using System.Collections.Generic;

namespace Gr.Graphics_package
{
    internal class polygon
    {
        private List<point> points;
        public polygon(List<point> points)
        {
            this.points = points;
        }

        public List<point> GetPoints()
        {
            return points;
        }
    }
}
