using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GISServer.Core.Geometry
{
    public class SpatialReference
    {
        public SpatialReference()
        {
        }

        public SpatialReference(int WKID)
        {
            this.WKID = WKID;
        }

        public SpatialReference(string WKT)
        {
            this.WKT = WKT;
        }

        public int WKID { get; set; }

        public string WKT { get; set; }

        public string uri { get; set; }
    }
}
