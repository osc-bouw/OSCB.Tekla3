using System;
using System.Collections.Generic;
using Tekla.BIM.Geometry;
using Tekla.Common.Geometry;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Solid;

namespace OSCB.Tekla3.Geometry
{
    public static class FaceExtensions
    {


        /// <summary>
        /// Get all vertical Face3 faces of a given Solid
        /// </summary>
        /// <param name="solid">Input Solid of a Tekla part</param>
        /// <returns>An IEnumerable of Face3 faces</returns>
        public static IEnumerable<Face3> GetVerticalFaces(this Solid solid)
        {
            FaceEnumerator enumerator = solid.GetFaceEnumerator();
            while (enumerator.MoveNext())
            {
                Face current = enumerator.Current;
                if (current != null && !current.Normal.GetLength().ZeroLength())
                {
                    Face3 face = current.ToFace3();
                    if (face != null)
                    {
                        if (face.Normal.ToVector() == UnitVector3.UnitZ.ToVector())
                        {
                            yield return face;
                        }

                    }
                }
            }
        }
    }
}
