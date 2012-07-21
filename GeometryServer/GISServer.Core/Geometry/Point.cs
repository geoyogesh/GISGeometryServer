using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GISServer.Core.Geometry
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
        public Point(Double X, Double Y,SpatialReference SpatialReference)
        {
            this.X = X;
            this.Y = Y;
            this.SpatialReference = SpatialReference;
        }

        public Point(Double X, Double Y, int WKID)
        {
            this.X = X;
            this.Y = Y;
            this.SpatialReference = new SpatialReference(WKID);
        }

        public Point(Double X, Double Y, string WKT)
        {
            this.X = X;
            this.Y = Y;
            this.SpatialReference = new SpatialReference(WKT);
        }


        public Double X { get; set; }

        public double Y { get; set; }

        public SpatialReference SpatialReference { get; set; }
    }
}
