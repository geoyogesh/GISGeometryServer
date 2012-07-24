using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GISServer.Core.GeoprocessingService
{
    public class Job
    {
        public string JobId { get; set; }

        public string JobStatus { get; set; }

        public dynamic Results { get; set; }

        public dynamic Inputs { get; set; }

        public Messages Messages { get; set; }
    }
}
