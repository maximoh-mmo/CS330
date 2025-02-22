using System.Numerics;

namespace Physics.CollisionDetection
{
    public enum VolumeType
    {
        AABB = 1,
        Sphere = 2,
        Boundary = 4,
        Invalid = 8
    }

    public class CollisionVolume
    {
        public VolumeType VolumeType { get; protected set; } = VolumeType.Invalid;
    }

    public class SphereVolume : CollisionVolume
    {
        public float Radius { get; private set; }
        public SphereVolume(float radius)
        {
            VolumeType = VolumeType.Sphere;
            Radius = radius;
        }
    }

    public class BoundaryVolume : CollisionVolume
    {
        public Vector2 Center { get; private set; }
        public Vector2 Bounds { get; private set; }
    }
    public class AABBVolume : CollisionVolume
    {
    }
}