using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class UnionModule : NancyModule
    {
        public UnionModule()
            : base("/rest/services/Geometry/GeometryServer/")
        {
            Get["/union"] = parameters =>
            {
                return View["Union"];
            };

        }
    }
}