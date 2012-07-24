using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GISServer.Core
{
    public class Error
    {
        public int Code { get; set; }

        public string Message { get; set; }

        public string Description { get; set; }

        public List<string> Details { get; set; }
    }
}
