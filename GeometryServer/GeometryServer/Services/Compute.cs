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
    }
}