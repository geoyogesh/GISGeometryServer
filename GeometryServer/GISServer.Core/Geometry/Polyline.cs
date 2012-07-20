using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GISServer.Core.Geometry
{
    public class Polyline : Geometry
    {
        public List<PointCollection> Paths { get; set; }

        public SpatialReference SpatialReference { get; set; }
    }
}
