using Vector3 = System.Numerics.Vector3;

namespace Physics.CollisionDetection
{
    public struct CollisionPoint
    {
        public Vector3 localPositionA;
        public Vector3 localPositionB;
        public float penetration;
        public Vector3 normal;
    }

    public struct CollisionInfo
    {
        public Collider A { get; set; }
        public Collider B { get; set; }
        public CollisionPoint Point { get; set; }

        public void AddCollisionPoint(Vector3 localA, Vector3 localB, Vector3 normal, float penetration)
        {
            var point = Point;
            point.localPositionA = localA;
            point.localPositionB = localB;
            point.normal = normal;
            point.penetration = penetration;
            Point = point;
        }
    }
}