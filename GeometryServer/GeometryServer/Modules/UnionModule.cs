using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class UnionModule : NancyModule
    {
        public UnionModule()
            : base("GeometryServer")
        {
            Get["/union"] = parameters =>
            {
                return View["UnionView"];
            };

        }
    }
}