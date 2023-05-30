using System;
using System.Collections.Generic;
using Tekla.BIM.Geometry;
using Tekla.Common.Geometry;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Solid;

namespace OSCB.Tekla3.Geometry
{
    public static class Vector3Extensions
    {

        /// <summary>
        /// Check if a point is on a Segment3 line
        /// </summary>
        /// <param name="point">The point to check</param>
        /// <param name="line">The line to check with</param>
        /// <returns>True if the point is on the line.</returns>
        public static bool IsPointOnLine(this Vector3 point, Segment3 line)
        {
            return ((point.X - line.NegativeEnd.X) / (line.PositiveEnd.X - line.NegativeEnd.X) ==
                    (point.Y - line.NegativeEnd.Y) / (line.PositiveEnd.Y - line.NegativeEnd.Y) &&
                    (point.Y - line.NegativeEnd.Y) / (line.PositiveEnd.Y - line.NegativeEnd.Y) ==
                    (point.Z - line.NegativeEnd.Z) / (line.PositiveEnd.Z - line.NegativeEnd.Z));

        }

    }


}
