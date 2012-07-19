using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class IntersectModule : NancyModule
    {
        public IntersectModule()
            : base("GeometryServer")
        {
            Get["/intersect"] = parameters =>
            {
                return View["IntersectView"];
            };

        }
    }
}