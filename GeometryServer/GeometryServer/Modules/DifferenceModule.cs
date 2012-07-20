using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class DifferenceModule : NancyModule
    {
        public DifferenceModule()
            : base("/rest/services/Geometry/GeometryServer/")
        {
            Get["/difference"] = parameters =>
            {
                return View["Difference"];
            };

        }
    }
}