using Nancy;


namespace GeometryServer.Modules
{
    public class RootModule : NancyModule
    {
        public RootModule()
            : base("GeometryServer")
        {
            Get["/"] = parameters =>
            {
                return View["GeometryService"];
            };

        }
    }
}