using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeometryServer.Models
{
    public class AreasAndLengths
    {
        public int SpatialReference { get; set; }

        public string Polygon { get; set; }

        public String Format { get; set; }

        public string Result { get; set; }

        public string Exception { get; set; }
    }
}