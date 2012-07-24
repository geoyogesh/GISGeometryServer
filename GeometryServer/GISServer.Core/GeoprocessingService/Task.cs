using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GISServer.Core.GeoprocessingService
{
    public class Task
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string Category { get; set; }

        public string HelpUrl { get; set; }

        public string ExecutionType { get; set; }

        public List<Parameter> Parameters { get; set; }
    }
}
