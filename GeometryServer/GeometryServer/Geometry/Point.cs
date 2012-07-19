using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometryServer.Geometry
{
    public class Point : Geometry
    {
        public Point()
        {
        }

        public Point(Double X,Double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public Double X { get; set; }

        public double Y { get; set; }

        public SpatialReference SpatialReference { get; set; }
    }
}
