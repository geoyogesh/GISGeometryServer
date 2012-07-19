using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class DensifyModule : NancyModule
    {
        public DensifyModule()
            : base("GeometryServer")
        {
            Get["/densify"] = parameters =>
            {
                return View["DensifyView"];
            };

        }
    }
}