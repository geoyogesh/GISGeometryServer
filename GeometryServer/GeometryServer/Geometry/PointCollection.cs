﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometryServer.Geometry
{
    public class PointCollection: System.Collections.ObjectModel.ObservableCollection<Point>
    {
        public PointCollection()
        {
        }

        public PointCollection(System.Collections.Generic.IEnumerable<Point> list)
        {
        }
    }
}
