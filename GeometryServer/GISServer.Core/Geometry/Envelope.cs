using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GISServer.Core.Geometry
{
    public class Envelope:Geometry
    {
        public Envelope()
        {
        }
        public Envelope(double XMin, double YMin, double XMax, double YMax)
        {
            this.XMin = XMin;
            this.YMin = YMin;
            this.XMax = XMax;
            this.YMax = YMax;
        }
        public Envelope(double XMin, double YMin, double XMax, double YMax, SpatialReference SpatialReference)
        {
            this.XMin = XMin;
            this.YMin = YMin;
            this.XMax = XMax;
            this.YMax = YMax;
            this.SpatialReference = SpatialReference;
        }
        public double XMin { get; set; }

        public double YMin { get; set; }

        public double XMax { get; set; }

        public double YMax { get; set; }

        public SpatialReference SpatialReference { get; set; }
    }
}
