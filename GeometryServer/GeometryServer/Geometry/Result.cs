using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometryServer.Geometry
{
    public class Result
    {
        public String geometryType { get; set; }

        public List<Geometry> geometries { get; set; }
    }
}
