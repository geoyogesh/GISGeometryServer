using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GISServer.Core.GeometryService
{
    public class AreasAndLengths
    {
        public AreasAndLengths()
        {
            Areas = new List<double>();
            Lengths = new List<double>();
        }
        public List<double> Areas { get; set; }

        public List<double> Lengths { get; set; }
    }
}
