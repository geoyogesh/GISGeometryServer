﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GISServer.Core.Geometry
{
    public class Polygon : Geometry
    {
        public List<PointCollection> Rings { get; set; }

        public SpatialReference SpatialReference { get; set; }
    }
}
