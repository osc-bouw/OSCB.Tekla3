using OSCB.Tekla3.Geometry;
using System.Net;
using Tekla.BIM.Geometry;
using Tekla.Common.Geometry;
using Tekla.Structures;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;

namespace OSCB.Tekla3.Initiators
{
    public class BeamInitiator : Part
    {

        protected Beam beamPart;


        public Segment3 Segment { get; set; } = new Segment3();

        public Vector3 StartPoint { get; set; } = new Vector3(0, 0, 0);

        public Vector3 EndPoint { get; set; } = new Vector3(0, 0, 0);

        /// <summary>
        /// Get the length of the Beam
        /// </summary>
        public double Length
        {
            get
            {
                return Segment.Length();
            }
        }

        /// <summary>
        /// Create a default beam instance with startpoint 0,0,0 and endpoint 1000,0,0
        /// </summary>
        public BeamInitiator()
        {
            StartPoint = new Vector3(0, 0, 0);
            EndPoint = new Vector3(1000, 0, 0);
            Segment = new Segment3(StartPoint, EndPoint);
            InitiateBeam();
        }

        /// <summary>
        /// Create a default beam instance with two points
        /// </summary>
        /// <param name="startPoint">StartPoint</param>
        /// <param name="endPoint">EndPoint</param>
        public BeamInitiator(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint.ToVector3();
            EndPoint = endPoint.ToVector3();
            Segment = new Segment3(StartPoint, EndPoint);
            InitiateBeam();
        }

        /// <summary>
        /// Create a default beam instance with two (vector3)points
        /// </summary>
        /// <param name="startPoint">StartPoint</param>
        /// <param name="endPoint">EndPoint</param>
        public BeamInitiator(Vector3 startPoint, Vector3 endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            Segment = new Segment3(StartPoint, EndPoint);
            InitiateBeam();
        }

        /// <summary>
        /// Create a default beam instance with a (Sement3)Line
        /// </summary>
        /// <param name="segment">Input (Segment3) line</param>
        public BeamInitiator(Segment3 segment)
        {
            Segment = segment;
            StartPoint = segment.NegativeEnd;
            EndPoint = segment.PositiveEnd;
            InitiateBeam();
        }

        /// <summary>
        /// Sets al default values for the Beam
        /// </summary>
        /// <returns>Beam instance</returns>
        internal Beam InitiateBeam()
        {
            beamPart = new Beam(Beam.BeamTypeEnum.BEAM)
            {
                Name = "DEFAULT_BEAM",
                StartPoint = StartPoint.ToPoint(),
                StartPointOffset = new Offset()
                {
                    Dx = 0,
                    Dy = 0,
                    Dz = 0
                },
                EndPoint = EndPoint.ToPoint(),
                EndPointOffset = new Offset()
                {
                    Dx = 0,
                    Dy = 0,
                    Dz = 0
                },
                Class = "1",
                Material = new Material()
                {
                    MaterialString = "DUMMY"
                },
                Profile = new Profile()
                {
                    ProfileString = "100*100"
                },
                Finish = "",
                CastUnitType = CastUnitTypeEnum.PRECAST,
                Position = new Position()
                {
                    Depth = Position.DepthEnum.FRONT,
                    DepthOffset = 0,
                    Plane = Position.PlaneEnum.LEFT,
                    PlaneOffset = 0,
                    Rotation = Position.RotationEnum.FRONT,
                    RotationOffset = 0,
                },
                AssemblyNumber = new NumberingSeries()
                {
                    Prefix = "B",
                    StartNumber = 0
                },
                PartNumber = new NumberingSeries()
                {
                    Prefix = "P",
                    StartNumber = 0
                },
                DeformingData = new DeformingData()
                {
                    Angle = 0,
                    Angle2 = 0,
                    Cambering = 0,
                    Shortening = 0
                },
                Identifier = new Identifier(),
                PourPhase = 0,
            };

            return beamPart;
        }

        /// <summary>
        /// Delete the beam instance
        /// </summary>
        /// <returns>true or false</returns>
        public override bool Delete()
        {
            if (beamPart != null)
            {
                return beamPart.Delete();
            }

            return false;

        }

        /// <summary>
        /// Insert the beam instance
        /// </summary>
        /// <returns>true or false</returns>
        public override bool Insert()
        {
            if (beamPart != null)
            {
                return beamPart.Insert();
            }

            return false;
        }

        /// <summary>
        /// Modify the beam instance
        /// </summary>
        /// <returns>true or false</returns>
        public override bool Modify()
        {
            if (beamPart != null)
            {
                return beamPart.Modify();
            }

            return false;
        }

        /// <summary>
        /// Select the beam instance in the model
        /// </summary>
        /// <returns>true or false</returns>
        public override bool Select()
        {
            if (beamPart != null)
            {
                return beamPart.Select();
            }

            return false;
        }
    }
}
