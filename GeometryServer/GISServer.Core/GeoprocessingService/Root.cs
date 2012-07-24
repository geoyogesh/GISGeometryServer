using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GISServer.Core.GeoprocessingService
{
    public class Root
    {
        public string ServiceDescription { get; set; }

        public List<string> Tasks { get; set; }

        public string ExecutionType { get; set; }

        public string ResultMapServerName { get; set; }
    }
}
