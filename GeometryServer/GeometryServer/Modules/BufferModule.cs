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
                var model = new Models.Buffer();

                #region Required Parameter

                if (Request.Query["inSR"].Value != null)
                {
                    model.InputSpatialReference = Convert.ToInt32(Request.Query["sr"].Value);
                }

                if (Request.Query["outSR"].Value != null)
                {
                    model.OutputSpatialReference = Convert.ToInt32(Request.Query["outSR"].Value);
                }

                if (Request.Query["bufferSR"].Value != null)
                {
                    model.BufferSpatialReference = Convert.ToInt32(Request.Query["bufferSR"].Value);
                }

                if (Request.Query["distances"].Value != null)
                {
                    model.BufferDistance = Convert.ToInt32(Request.Query["distances"].Value);
                }

                if (Request.Query["unit"].Value != null)
                {
                    model.DistanceUnit = Convert.ToInt32(Request.Query["unit"].Value);
                }

                if (Request.Query["geometries"].Value != null)
                {
                    model.InputGeometries = Request.Query["geometries"].Value;
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

                if (model.InputGeometries != null)
                {

                    var inputgeom = Services.Utilities.GetGeometries(model.InputGeometries);

                    var buffergeometries = Services.Compute.Buffer(inputgeom,model.BufferDistance);

                    var gispolygon = Services.Utilities.GetGISGeometries(buffergeometries);


                    switch (model.Format)
                    {
                        case "json":
                            model.Result = Services.Utilities.getJSON(gispolygon);
                            break;
                        case "pjson":
                            model.Result = Services.Utilities.getPJSON(gispolygon);
                            break;
                        default:
                            model.Result = Services.Utilities.getPJSON(gispolygon);
                            break;
                    }

                }


                if (model.Format.Equals("HTML"))
                {
                    return View["Buffer", model];
                }
                else
                {
                    return model.Result;
                }
            };

        }
    }
}