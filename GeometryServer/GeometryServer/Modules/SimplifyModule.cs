using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class SimplifyModule : NancyModule
    {
        public SimplifyModule()
            : base("GeometryServer")
        {
            Get["/simplify"] = parameters =>
            {
                return View["SimplifyView"];
            };

        }
    }
}