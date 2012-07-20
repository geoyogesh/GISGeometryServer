using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class CutModuleModule : NancyModule
    {
        public CutModuleModule()
            : base("/rest/services/Geometry/GeometryServer/")
        {
            Get["/cut"] = parameters =>
            {
                return View["Cut"];
            };

        }
    }
}