using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GISServer.Core.Geometry
{
    public class Geometry
    {
        public Envelope Extent { get; set; }

        public SpatialReference SpatialReference { get; set; }
    }
}
