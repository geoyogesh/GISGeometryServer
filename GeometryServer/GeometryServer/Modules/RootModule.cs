using Nancy;


namespace GeometryServer.Modules
{
    public class RootModule : NancyModule
    {
        public RootModule()
            : base("/rest/services/Geometry/GeometryServer/")
        {
            Get["/"] = parameters =>
            {
                return View["GeometryService"];
            };

        }
    }
}