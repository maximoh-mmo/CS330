using System.Numerics;

namespace Physics.CollisionDetection
{
    public abstract class Collider
    {
        public CollisionVolume Volume { get; protected set; }
        public PhysicsObject Parent { get; protected set; }

        protected Collider(PhysicsObject parent)
        {
            Parent = parent;
        }
    }

    public class CircleCollider : Collider
    {
        public float Radius { get; private set; }
        
        public CircleCollider(float radius, PhysicsObject parent) : base(parent)
        {
            Radius = radius;
            Volume = new SphereVolume(radius);
        }
    }

    public class BoundaryCollider : Collider
    {
        public Vector2 HalfBounds { get; private set; }

        public BoundaryCollider(Vector2 halfBounds, PhysicsObject parent) : base(parent)
        {
            HalfBounds = halfBounds;
        }
        
    }
}