using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GISServer.Core.Geometry;

namespace GeometryServer.Models
{
    public class ConvexHull
    {
        public int SpatialReference { get; set; }

        public string InputGeometries { get; set; }

        public String Format { get; set; }

        public string OutputGeometries { get; set; }

        public string Result { get; set; }

        public string Exception { get; set; }

    }
}