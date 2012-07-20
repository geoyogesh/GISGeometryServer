using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class IntersectModule : NancyModule
    {
        public IntersectModule()
            : base("/rest/services/Geometry/GeometryServer/")
        {
            Get["/intersect"] = parameters =>
            {
                return View["Intersect"];
            };

        }
    }
}