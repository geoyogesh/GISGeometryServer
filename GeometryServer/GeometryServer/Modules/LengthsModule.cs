using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class LengthsModule : NancyModule
    {
        public LengthsModule()
            : base("GeometryServer")
        {
            Get["/lengths"] = parameters =>
            {
                return View["LengthsView"];
            };

        }
    }
}