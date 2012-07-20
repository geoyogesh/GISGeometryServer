using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class GeneralizeModule : NancyModule
    {
        public GeneralizeModule()
            : base("/rest/services/Geometry/GeometryServer/")
        {
            Get["/generalize"] = parameters =>
            {
                return View["Generalize"];
            };

        }
    }
}