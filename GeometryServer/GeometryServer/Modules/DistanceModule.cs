using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class DistanceModule : NancyModule
    {
        public DistanceModule()
            : base("/rest/services/Geometry/GeometryServer/")
        {
            Get["/distance"] = parameters =>
            {
                return View["Distance"];
            };

        }
    }
}