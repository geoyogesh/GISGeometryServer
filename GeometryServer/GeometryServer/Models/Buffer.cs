using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeometryServer.Models
{
    public class Buffer
    {
        public int InputSpatialReference { get; set; }

        public int OutputSpatialReference { get; set; }

        public int BufferSpatialReference { get; set; }

        public double BufferDistance { get; set; }

        public bool UnionResults { get; set; }

        public int DistanceUnit { get; set; }

        public string InputGeometries { get; set; }

        public String Format { get; set; }

        public string Result { get; set; }

        public string Exception { get; set; }
    }
}