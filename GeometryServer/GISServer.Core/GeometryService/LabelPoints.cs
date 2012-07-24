using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GISServer.Core.GeometryService
{
    public class LabelPoints
    {
        public LabelPoints()
        {
            LabelPoints = new List<Geometry.Point>();
        }

        public List<GISServer.Core.Geometry.Point> LabelPoints { get; set; }
    }
}
