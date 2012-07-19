using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class ConvexHullModule : NancyModule
    {
        public ConvexHullModule()
            : base("GeometryServer")
        {
            Get["/convexhull"] = parameters =>
            {
                return View["ConvexHullView"];
            };

        }
    }
}