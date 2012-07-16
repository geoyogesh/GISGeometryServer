using Nancy;


namespace GeometryServer.Modules
{
    public class GeometryService : NancyModule
    {
        public GeometryService()
            : base("/rest/services/Geometry/GeometryServer")
        {
            //Get["/"] = parameters =>
            //{
            //    return "Welcome";
            //};
            //Get["/{Name}"] = parameters =>
            //{
            //    return String.Format("Welcome {0}{1}", parameters.Name, Request.Query["Hi"]);
            //};

            //http://sampleserver1.arcgisonline.com/ArcGIS/rest/services/Geometry/GeometryServer

            Get["/"] = parameters =>
            {
                return View["GeometryService"];
            };

        }
    }
}