using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeometryServer.Services
{
    public static class Compute
    {
        public static dynamic ConvexHull(dynamic geometries)
        {
            if (geometries is DotSpatial.Topology.MultiPoint)
            {
                return (DotSpatial.Topology.Polygon)geometries.ConvexHull();
            }
            else if (geometries is List<DotSpatial.Topology.Point>)
            {
                var c = new List<DotSpatial.Topology.Coordinate>();
                for (int i = 0; i < geometries.Count; i++)
                {
                    c.Add(new DotSpatial.Topology.Coordinate(geometries[i].X, geometries[i].Y));
                }
                var mutiPoint = new DotSpatial.Topology.MultiPoint(c);
                var convexHull = (DotSpatial.Topology.Polygon)mutiPoint.ConvexHull();
                return convexHull;
            }
            return null;
        }

        public static dynamic AreasAndLengths(dynamic geometries)
        {
            var result = new GISServer.Core.GS.AreasAndLengths();
            if ((geometries is DotSpatial.Topology.Polygon)||(geometries is DotSpatial.Topology.MultiPolygon))
            {
                result.Areas.Add(geometries.Area);
                result.Lengths.Add(geometries.Length);
                return result;
            }
            else if ((geometries is List<DotSpatial.Topology.Polygon>)||(geometries is List<DotSpatial.Topology.MultiPolygon>))
            {
                for (int i = 0; i < geometries.Count; i++)
                {
                    result.Areas.Add(geometries[i].Area);
                    result.Lengths.Add(geometries[i].Length);
                }
                return result;
            }
            return null;
        }

        public static dynamic Buffer(dynamic geometries, double bufferdistance)
        {
            if (geometries.GetType().GetGenericTypeDefinition()== typeof(List<>))
            {
                var result = new List<DotSpatial.Topology.IGeometry>();
                for (int i = 0; i < geometries.Count; i++)
                {
                    result.Add( geometries[i].Buffer(bufferdistance));
                }
                return result;
            }
            else
            {
                return geometries.Buffer(bufferdistance);
            }
        }
    }
}