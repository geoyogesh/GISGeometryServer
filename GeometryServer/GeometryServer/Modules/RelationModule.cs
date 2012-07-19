using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class RelationModule : NancyModule
    {
        public RelationModule()
            : base("GeometryServer")
        {
            Get["/relation"] = parameters =>
            {
                return View["RelationView"];
            };

        }
    }
}