using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometryServer.Geometry
{
    public class Envelope
    {
        public double XMin { get; set; }

        public double YMin { get; set; }

        public double XMax { get; set; }

        public double YMax { get; set; }

        public SpatialReference SpatialReference { get; set; }
    }
}
