using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GISServer.Core.Geometry
{
    public class Geometries
    {
        public String GeometryType { get; set; }

        public List<Geometry> geometries { get; set; }

        public SpatialReference SpatialReference { get; set; }
    }
}
