using Nancy;


namespace GeometryServer.Modules
{
    public class GeometryServerModule : NancyModule
    {
        public GeometryServerModule()
            : base("/rest/services/Geometry/GeometryServer/")
        {
            Get["/"] = parameters =>
            {
                return View["GeometryService"];
            };

        }
    }
}