using System;
using System.Collections.Generic;
using Tekla.BIM.Geometry;
using Tekla.Common.Geometry;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Solid;

namespace OSCB.Tekla3.Geometry
{
    public static class UnitVector3Extensions
    {

        /// <summary>
        /// Convert an UnitVector3 to a Vector3
        /// </summary>
        /// <param name="uv">Input UnitVector3</param>
        /// <returns>a Vector3</returns>
        public static Vector3 ToVector3(this UnitVector3 uv)
        {
            return new Vector3(uv.X, uv.Y, uv.Z);
        }

        /// <summary>
        /// Convert an UnitVector3 to a Vector
        /// </summary>
        /// <param name="uv">Input UnitVector3</param>
        /// <returns>a Vector</returns>
        public static Vector ToVector(this UnitVector3 uv)
        {
            return new Vector(uv.X, uv.Y, uv.Z);
        }

    }
}
