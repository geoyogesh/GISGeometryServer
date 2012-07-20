using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class OffsetModule : NancyModule
    {
        public OffsetModule()
            : base("/rest/services/Geometry/GeometryServer/")
        {
            Get["/offset"] = parameters =>
            {
                return View["Offset"];
            };

        }
    }
}