using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GISServer.Core.GeometryService
{
    public class Relation
    {
        public Relation()
        {
            Relations = new List<RelationObj>();
        }
        public List<RelationObj> Relations { get; set; }
    }
}
