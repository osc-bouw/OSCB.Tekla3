using System;
using System.Collections.Generic;
using System.Linq;
using Tekla.BIM.Geometry;
using Tekla.Common.Geometry;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Solid;
using OSCB.Tekla3.Geometry;

namespace OSCB.Tekla3.Geometry
{
    public static class SolidExtensions
    {

        /// <summary>
        /// Get all points from a Solid, including cuts
        /// </summary>
        /// <param name="solid">input solid and return the points</param>
        /// <returns>IEnumerable of points</returns>
        public static IEnumerable<Point> GetPoints(this Solid solid)
        {
            List<Point> points = new List<Point>();

            EdgeEnumerator enumerator = solid.GetEdgeEnumerator();
            while (enumerator.MoveNext())
            {
                Edge current = enumerator.Current as Edge;

                if (current != null)
                {
                    points.Add(current.StartPoint.Round(2));
                    points.Add(current.EndPoint.Round(2));

                }
            }


            return points.Distinct();
        }
      

       

    }
}
