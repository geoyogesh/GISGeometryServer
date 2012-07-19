using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class LabelPointsModule : NancyModule
    {
        public LabelPointsModule()
            : base("GeometryServer")
        {
            Get["/labelPoints"] = parameters =>
            {
                return View["LabelPointsView"];
            };

        }
    }
}