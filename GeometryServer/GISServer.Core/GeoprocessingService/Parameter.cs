using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GISServer.Core.GeoprocessingService
{
    public class Parameter
    {
        public string Name { get; set; }

        public string DataType { get; set; }

        public string DisplayName { get; set; }

        public string Direction { get; set; }

        public dynamic DefaultValue { get; set; }

        public string Category { get; set; }

        public string ParameterType { get; set; }

        public List<dynamic> ChoiceList { get; set; }
    }
}
