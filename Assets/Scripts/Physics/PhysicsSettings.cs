using UnityEngine;

namespace Physics
{
    [CreateAssetMenu(fileName = "PhysicsSettings", menuName = "GameSettings/PhysicsSettings")]
    public class PhysicsSettings : ScriptableObject
    {
        public float Restitution = 0.9f; // (e) Ball Impact Co-efficent
        public float TableFriction = 0.02f; // Friction Co-efficient between ball and table.
        public float BallMass = 0.17f;  // Ball mass (kg) *https://billardregel.de/pool-billard/materialnormen/* 
    }
}