using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class ReshapeModule : NancyModule
    {
        public ReshapeModule()
            : base("GeometryServer")
        {
            Get["/reshape"] = parameters =>
            {
                return View["ReshapeView"];
            };

        }
    }
}