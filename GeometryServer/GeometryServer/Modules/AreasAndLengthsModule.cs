using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class AreasAndLengthsModule : NancyModule
    {
        public AreasAndLengthsModule()
            : base("/rest/services/Geometry/GeometryServer/")
        {
            Get["/areasandlengths"] = parameters =>
            {
                var model = new Models.AreasAndLengths();

                #region Required Parameter

                if (Request.Query["sr"].Value != null)
                {
                    model.SpatialReference = Convert.ToInt32(Request.Query["sr"].Value);
                }

                if (Request.Query["polygons"].Value != null)
                {
                    model.Polygon = Request.Query["polygons"].Value;
                }
                #endregion

                #region Optional Parameter
                if (Request.Query["f"].Value != null)
                {
                    model.Format = Request.Query["f"].Value;
                }
                else
                {
                    model.Format = "HTML";
                }
                #endregion

                if (model.Polygon!=null)
                {
                    
                

                var inputgeom = Services.Utilities.GetGeometry(model.Polygon, "GeometryPolygon");

                var areaandlengthresult = Services.Compute.AreasAndLengths(inputgeom);

                
                switch (model.Format)
                {
                    case "json":
                        model.Result = Services.Utilities.getJSON(areaandlengthresult);
                        break;
                    case "pjson":
                        model.Result = Services.Utilities.getPJSON(areaandlengthresult);
                        break;
                    default:
                        model.Result = Services.Utilities.getPJSON(areaandlengthresult);
                        break;
                }
                }

                if (model.Format.Equals("HTML"))
                {
                    return View["AreasAndLengths", model];
                }
                else
                {
                    return model.Result;
                }
            };

        }
    }
}