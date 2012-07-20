using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class ReshapeModule : NancyModule
    {
        public ReshapeModule()
            : base("/rest/services/Geometry/GeometryServer/")
        {
            Get["/reshape"] = parameters =>
            {
                return View["Reshape"];
            };

        }
    }
}