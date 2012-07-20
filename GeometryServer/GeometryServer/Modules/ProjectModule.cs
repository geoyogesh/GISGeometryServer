using System;
using Nancy;
using DotSpatial.Projections;

namespace GeometryServer.Modules
{
    public class ProjectModule : NancyModule
    {
        public ProjectModule()
            : base("/rest/services/Geometry/GeometryServer/")
        {
            Get["/project"] = parameters =>
            {
                int inSR, outSR;
                string geometries,format;

                #region Required Parameter
                
                if (Request.Query["inSR"].Value != null)
                {
                    inSR = Convert.ToInt32(Request.Query["inSR"].Value);
                }

                if (Request.Query["outSR"].Value != null)
                {
                    outSR = Convert.ToInt32(Request.Query["outSR"].Value);
                }

                
                if (Request.Query["geometries"].Value != null)
                {
                    geometries = Request.Query["geometries"].Value;
                }
                #endregion

                #region Optional Parameter
                if (Request.Query["f"].Value != null)
                {
                    format = Request.Query["f"].Value;
                }
                else
                {
                    format = "HTML";
                }
                #endregion




                //Sets up a array to contain the x and y coordinates
                double[] xy = new double[2];
                xy[0] = 0;
                xy[1] = 0;
                //An array for the z coordinate
                double[] z = new double[1];
                z[0] = 1;

                Reprojection(ref xy, ref z, 1);

                //return "Welcome to geometry service";
                //return View["First"];
                return View["Project"];

            };

        }
        private void Reprojection(ref double[] xy, ref double[] z, int count)
        {
            //Defines the starting coordiante system
            ProjectionInfo pStart = KnownCoordinateSystems.Geographic.World.WGS1984;
            //Defines the ending coordiante system
            ProjectionInfo pEnd = KnownCoordinateSystems.Projected.NorthAmerica.USAContiguousLambertConformalConic;
            //Calls the reproject function that will transform the input location to the output locaiton
            Reproject.ReprojectPoints(xy, z, pStart, pEnd, 0, count);
        }
    }
}