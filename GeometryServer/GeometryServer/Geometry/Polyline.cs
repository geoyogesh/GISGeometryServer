using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometryServer.Geometry
{
    public class Polyline : Geometry
    {
        public List<PointCollection> Paths { get; set; }

        public SpatialReference SpatialReference { get; set; }
    }
}
