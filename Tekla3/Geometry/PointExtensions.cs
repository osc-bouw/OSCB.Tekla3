using System;
using System.Collections.Generic;
using Tekla.BIM.Geometry;
using Tekla.Common.Geometry;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Solid;

namespace OSCB.Tekla3.Geometry
{ 

    public static class PointExtensions
    {

        /// <summary>
        /// Rounding the X, Y and Z values
        /// </summary>
        /// <param name="point">Input point to round</param>
        /// <param name="d">number of decimals for rounding</param>
        /// <returns></returns>
        public static Point Round(this Point point, int d = 0)
        {
            return new Point(Math.Round(point.X, d), Math.Round(point.Y, d), Math.Round(point.Z, d));
        }

    }
}
