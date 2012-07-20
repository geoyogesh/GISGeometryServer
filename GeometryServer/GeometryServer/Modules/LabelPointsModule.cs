using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class LabelPointsModule : NancyModule
    {
        public LabelPointsModule()
            : base("/rest/services/Geometry/GeometryServer/")
        {
            Get["/labelPoints"] = parameters =>
            {
                return View["LabelPoints"];
            };

        }
    }
}