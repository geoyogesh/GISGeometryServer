using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class OffsetModule : NancyModule
    {
        public OffsetModule()
            : base("GeometryServer")
        {
            Get["/offset"] = parameters =>
            {
                return View["OffsetView"];
            };

        }
    }
}