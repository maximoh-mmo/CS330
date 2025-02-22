using System;
using System.Numerics;

namespace Physics
{
    public class PhysicsObject
    {
        public Transform Transform { get; set; } = new Transform(Vector3.Zero, Quaternion.Identity, Vector3.One);
        public float Mass { get; protected set; }
    }
    
    public class StaticObject : PhysicsObject
    {
        public StaticObject() : base()
        {
            Mass = Single.PositiveInfinity;
        }
    }

    public class DynamicObject : PhysicsObject
    {
        public DynamicObject(float mass) : base()
        {
            Mass = mass;
        }
    }
}