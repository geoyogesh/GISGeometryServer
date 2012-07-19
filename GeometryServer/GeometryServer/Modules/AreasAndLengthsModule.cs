using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class AreasAndLengthsModule : NancyModule
    {
        public AreasAndLengthsModule()
            : base("GeometryServer")
        {
            Get["/areasandlengths"] = parameters =>
            {
                return View["AreasAndLengthsView"];
            };

        }
    }
}