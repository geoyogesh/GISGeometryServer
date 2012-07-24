using Nancy;


namespace GeometryServer.Modules
{
    public class CatalogModule
        : NancyModule
    {
        public CatalogModule()
            : base("/rest/services/")
        {
            Get["/"] = parameters =>
            {
                return View["Catalog"];
            };

        }
    }
}