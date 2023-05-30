using Render;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Common.Geometry;

namespace OSCB.Tekla3.Geometry
{
    public static class IEnumerablePointExtensions
    {

        /// <summary>
        /// Convert a Point-list to a Vector3-list
        /// </summary>
        /// <param name="points">List with Points</param>
        /// <returns>List with Vector3 vectors</returns>
        public static List<Vector3> ToVector3List(this List<Point> points)
        {
            return points.Select(p => new Vector3(p.x, p.y, p.z)).ToList();
        }
    }
}
