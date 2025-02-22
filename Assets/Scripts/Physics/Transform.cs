using System.Numerics;

namespace Physics
{
    public struct Transform
    {
        public Vector3 Position;
        public Quaternion Rotation;
        public Vector3 Scale;

        public Transform(Vector3 position, Quaternion rotation, Vector3 scale)
        {
            Position = position;
            Rotation = rotation;
            Scale = scale;
        }

        public Transform(UnityEngine.Vector3 position, Quaternion rotation, Vector3 scale)
        {
            Position = new Vector3(position.x, position.y, position.z);
            Rotation = rotation;
            Scale = scale;
        }

        public UnityEngine.Vector3 UnityPosition => new UnityEngine.Vector3(Position.X, Position.Y, Position.Z);
    }
}