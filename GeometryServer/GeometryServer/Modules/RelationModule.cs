using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class RelationModule : NancyModule
    {
        public RelationModule()
            : base("/rest/services/Geometry/GeometryServer/")
        {
            Get["/relation"] = parameters =>
            {
                return View["Relation"];
            };

        }
    }
}