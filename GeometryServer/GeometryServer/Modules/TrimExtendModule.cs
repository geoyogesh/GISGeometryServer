using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class TrimExtendModule : NancyModule
    {
        public TrimExtendModule()
            : base("GeometryServer")
        {
            Get["/trimextend"] = parameters =>
            {
                return View["TrimExtendView"];
            };

        }
    }
}