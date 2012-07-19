using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class BufferModule : NancyModule
    {
        public BufferModule()
            : base("GeometryServer")
        {
            Get["/buffer"] = parameters =>
            {
                return View["BufferView"];
            };

        }
    }
}