using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class AutoCompleteModule : NancyModule
    {
        public AutoCompleteModule()
            : base("/rest/services/Geometry/GeometryServer/")
        {
            Get["/autoComplete"] = parameters =>
            {
                return View["AutoComplete"];
            };

        }
    }
}