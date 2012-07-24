using System;
using Nancy;
using DotSpatial.Projections;
using GISServer.Core.Geometry;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace GeometryServer.Modules
{
    public class ConvexHullModule : NancyModule
    {
        public ConvexHullModule()
            : base("/rest/services/Geometry/GeometryServer/")
        {
            Get["/convexHull"] = parameters =>
            {
                var model = new Models.ConvexHull();

                #region Required Parameter

                if (Request.Query["sr"].Value != null)
                {
                    model.SpatialReference = Convert.ToInt32(Request.Query["sr"].Value);
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

                if (model.InputGeometries!=null)
                {
                    
                

                var inputgeom = Services.Utilities.GetGeometries(model.InputGeometries);

                var convexpolygon = Services.Compute.ConvexHull(inputgeom);

                var gispolygon = Services.Utilities.GetGISGeometries(convexpolygon);


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
                    return View["ConvexHull", model];
                }
                else
                {
                    return model.Result;
                }
            };

        }
    }
}