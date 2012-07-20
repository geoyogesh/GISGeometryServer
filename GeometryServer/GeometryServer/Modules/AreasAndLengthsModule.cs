using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class AreasAndLengthsModule : NancyModule
    {
        public AreasAndLengthsModule()
            : base("/rest/services/Geometry/GeometryServer/")
        {
            Get["/areasandlengths"] = parameters =>
            {
                return View["AreasAndLengths"];
            };

        }
    }
}