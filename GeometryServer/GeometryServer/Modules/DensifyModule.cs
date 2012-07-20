using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class DensifyModule : NancyModule
    {
        public DensifyModule()
            : base("/rest/services/Geometry/GeometryServer/")
        {
            Get["/densify"] = parameters =>
            {
                return View["Densify"];
            };

        }
    }
}