using System.Numerics;
using Physics;
using Physics.CollisionDetection;

namespace Game
{
    public class BilliardBall : DynamicObject
    {
        private int idNo; // individual identitfier
        private float radius = 0.0285f; // 57mm diameter / 2 expressed in meters 
        public float Diameter => radius * 2;
        public Vector3 Velocity { get; set; }
        public CircleCollider CircleCollider { get; private set; }
        
        public BilliardBall(int id, UnityEngine.Vector3 startingPosition, Vector3 startingVelocity, float mass) : base(mass)
        {
            idNo = id;
            Transform = new Transform(startingPosition, Quaternion.Identity, Vector3.One);
            Velocity = startingVelocity;
            if (startingVelocity != Vector3.Zero)
            {
                var transform = Transform;
                transform.Rotation = Quaternion.CreateFromAxisAngle(startingVelocity,0);
                Transform = transform;
            }
            CircleCollider = new CircleCollider(radius,this);
        }
    }
}