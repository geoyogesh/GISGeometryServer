using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GISServer.Core.GS
{
    public class LabelPoints
    {
        public LabelPoints()
        {
            labelPoints = new List<Geometry.Point>();
        }

        public List<GISServer.Core.Geometry.Point> labelPoints { get; set; }
    }
}
