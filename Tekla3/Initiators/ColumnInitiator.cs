using OSCB.Tekla3.Geometry;
using System;
using Tekla.BIM.Geometry;
using Tekla.Common.Geometry;
using Tekla.Structures;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;

namespace OSCB.Tekla3.Initiators
{
    public class ColumnInitiator : BeamInitiator
    {

        public double RotationAngle
        {
            get => beamPart.Position.RotationOffset;
            set => beamPart.Position.RotationOffset = value;
        }

        public double Height
        {
            get => Math.Abs(StartPoint.Z - EndPoint.Z);
            set => EndPoint = StartPoint + new Vector3(0, 0, Height);
        }

        public ColumnInitiator(Point startPoint)
        {
            StartPoint = startPoint.ToVector3();
            EndPoint = (startPoint + new Vector(0, 0, 1000)).ToVector3();
            Segment = new Segment3(StartPoint, EndPoint);
            InitiateColumn();
        }

        public ColumnInitiator(Vector3 startPoint)
        {
            StartPoint = startPoint;
            EndPoint = startPoint + new Vector3(0, 0, 1000);
            Segment = new Segment3(StartPoint, EndPoint);
            InitiateColumn();
        }


        public Beam InitiateColumn()
        {
            Beam column = base.InitiateBeam();
            column.Position.Plane = Position.PlaneEnum.MIDDLE;
            column.Position.Depth = Position.DepthEnum.MIDDLE;

            return column;
        }

    }
}
