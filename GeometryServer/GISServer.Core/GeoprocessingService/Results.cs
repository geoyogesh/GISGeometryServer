using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GISServer.Core.GeoprocessingService
{
    public class Results
    {
        public List<ParameterValue> Results { get; set; }

        public Messages Messages { get; set; }
    }
}
