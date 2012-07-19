using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class GeneralizeModule : NancyModule
    {
        public GeneralizeModule()
            : base("GeometryServer")
        {
            Get["/generalize"] = parameters =>
            {
                return View["GeneralizeView"];
            };

        }
    }
}