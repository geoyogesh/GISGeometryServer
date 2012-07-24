using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GISServer.Core.Geometry
{
    public class SingleGeometry
    {
        public String GeometryType { get; set; }

        public Geometry geometry { get; set; }

        public SpatialReference SpatialReference { get; set; }
    }
}
