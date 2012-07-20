using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class LengthsModule : NancyModule
    {
        public LengthsModule()
            : base("/rest/services/Geometry/GeometryServer/")
        {
            Get["/lengths"] = parameters =>
            {
                return View["Lengths"];
            };

        }
    }
}