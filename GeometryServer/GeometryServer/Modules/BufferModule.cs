using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class BufferModule : NancyModule
    {
        public BufferModule()
            : base("/rest/services/Geometry/GeometryServer/")
        {
            Get["/buffer"] = parameters =>
            {
                return View["Buffer"];
            };

        }
    }
}