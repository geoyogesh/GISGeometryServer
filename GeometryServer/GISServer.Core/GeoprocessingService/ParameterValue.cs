using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GISServer.Core.GeoprocessingService
{
    public class ParameterValue
    {
        public string paramName { get; set; }

        public string dataType { get; set; }

        public dynamic value { get; set; }
    }
}
