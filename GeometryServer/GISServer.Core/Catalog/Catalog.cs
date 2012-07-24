using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GISServer.Core.Catalog
{
    public class Catalog
    {
        public double SpecVersion { get; set; }

        public string ProductName { get; set; }

        public double CurrentVersion { get; set; }

        public List<string> Folders { get; set; }

        public List<Service> Services { get; set; }
    }
}
