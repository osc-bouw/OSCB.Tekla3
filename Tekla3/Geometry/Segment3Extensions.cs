using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Common.Geometry;

namespace OSCB.Tekla3.Geometry
{
    public static class Segment3Extensions
    {

        /// <summary>
        /// Get angle in degrees between two segments
        /// </summary>
        /// <param name="segment">first segment</param>
        /// <param name="segment1">second segment</param>
        /// <returns>a double with the angle in degrees</returns>
        public static double GetAngle(this Segment3 segment, Segment3 segment1)
        {
            double angle1 = Math.Atan2(segment.PositiveEnd.Y - segment.NegativeEnd.Y, segment.PositiveEnd.X - segment.NegativeEnd.X);
            double angle2 = Math.Atan2(segment1.PositiveEnd.Y - segment1.NegativeEnd.Y, segment1.PositiveEnd.X - segment1.NegativeEnd.X);

            double angleDifference = (angle1 - angle2) * (180 / Math.PI);
            double roundedAngleDifference = Math.Round(angleDifference);

            return roundedAngleDifference;

        }

        /// <summary>
        /// Get angle in degrees between a segment and a direction
        /// </summary>
        /// <param name="segment">Segment3 segment</param>
        /// <param name="direction">UnitVector3 direction</param>
        /// <returns>a double with the angle in degrees</returns>
        public static double GetAngle(this Segment3 segment, UnitVector3 direction)
        {
            Segment3 segment1 = new Segment3(new Vector3(0, 0, 0), (1000 * direction));

            double angle1 = Math.Atan2(segment.PositiveEnd.Y - segment.NegativeEnd.Y, segment.PositiveEnd.X - segment.NegativeEnd.X);
            double angle2 = Math.Atan2(segment1.PositiveEnd.Y - segment1.NegativeEnd.Y, segment1.PositiveEnd.X - segment1.NegativeEnd.X);

            double angleDifference = (angle1 - angle2) * (180 / Math.PI);
            double roundedAngleDifference = Math.Round(angleDifference);

            return roundedAngleDifference;

        }

    }
}
