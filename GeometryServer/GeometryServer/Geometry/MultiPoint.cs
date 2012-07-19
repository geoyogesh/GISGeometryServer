using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometryServer.Geometry
{
    public class MultiPoint:Geometry
    {
        public List<Point> Points { get; set; }

        public SpatialReference SpatialReference { get; set; }
    }
}
