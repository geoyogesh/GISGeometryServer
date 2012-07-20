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
                    model.SpatialReference= Convert.ToInt32(Request.Query["sr"].Value);
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

                var result =GetGeometry(model);

                model.Result = JsonConvert.SerializeObject(result);
                //ComputeConvexHull();

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

        private GISServer.Core.Geometry.Geometries GetGeometry(Models.ConvexHull model)
        {
            var c = new List<DotSpatial.Topology.Coordinate>();

            
            JObject o = JObject.Parse(model.InputGeometries);

            string geometrytype= (string)o["geometryType"];
            JArray geometries = (JArray)o["geometries"];

            for (int i = 0; i < geometries.Count; i++)
            {
                var p=geometries[i].ToObject<GISServer.Core.Geometry.Point>();
                c.Add(new DotSpatial.Topology.Coordinate(p.X, p.Y));
            }

            var mutiPoint = new DotSpatial.Topology.MultiPoint(c);
            var convexHull = (DotSpatial.Topology.Polygon)mutiPoint.ConvexHull();


            var ring = new GISServer.Core.Geometry.PointCollection();

            foreach (var item in convexHull.Coordinates)
	{
		  ring.Add(new GISServer.Core.Geometry.Point( item.X,item.Y));
	}

            var gp = new GISServer.Core.Geometry.Polygon();
            gp.Rings = new System.Collections.ObjectModel.ObservableCollection<PointCollection>();
            gp.Rings.Add(ring);

            GISServer.Core.Geometry.Geometries result = new Geometries();
            var listgeom = new List<GISServer.Core.Geometry.Geometry>();
            listgeom.Add(gp);
            result.geometries = listgeom;
            return result;
        }

        private static void ComputeConvexHull()
        {
            var c = new DotSpatial.Topology.Coordinate[50];
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                c[i] = new DotSpatial.Topology.Coordinate((rnd.Next(0, 50) + 360) - 90, (rnd.NextDouble() * 360) - 180);
            }
            var mutiPoint = new DotSpatial.Topology.MultiPoint(c);
            var convexHull = (DotSpatial.Topology.Polygon)mutiPoint.ConvexHull();
        }
    }
}