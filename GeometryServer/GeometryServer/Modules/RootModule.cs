using Nancy;


namespace GeometryServer.Modules
{
    public class RootModule
        : NancyModule
    {
        public RootModule()
            : base("/")
        {
            Get["/"] = parameters =>
            {
               return Response.AsRedirect("/rest/services");
            };
            Get["/rest"] = parameters =>
            {
                return Response.AsRedirect("/rest/services");
            };
        }
    }
}