using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GISServer.Core.GS
{
    public class Root
    {
        public Root()
        {
            Operations = new List<string>();
        }
        public string ServiceDescription { get; set; }

        public List<string> Operations { get; set; }
    }
}
