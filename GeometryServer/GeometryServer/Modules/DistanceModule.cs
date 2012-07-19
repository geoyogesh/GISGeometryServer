using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class DistanceModule : NancyModule
    {
        public DistanceModule()
            : base("GeometryServer")
        {
            Get["/distance"] = parameters =>
            {
                return View["DistanceView"];
            };

        }
    }
}