namespace Physics.CollisionDetection
{
    public static class CollisionDetection
    {
        static bool ObjectIntersection(Collider a, Collider b, out CollisionInfo collisionInfo)
        {
            collisionInfo =  new CollisionInfo();
            CollisionVolume volA = a.Volume;
            CollisionVolume volB = b.Volume;

            if (volA == null || volB == null)
            {
                return false;
            }

            collisionInfo.A = a;
            collisionInfo.B = b;

            Transform transformA = a.Parent.Transform;
            Transform transformB = b.Parent.Transform;

            VolumeType paarType = (VolumeType)((int)volA.VolumeType | (int)volB.VolumeType);
            if (paarType == VolumeType.AABB)
            {
                return AABBIntersection((AABBVolume)volA, transformA, (AABBVolume)volB, transformB, ref collisionInfo);
            }

            if (paarType == VolumeType.Sphere)
            {
                return SphereIntersection((SphereVolume)volA, transformA, (SphereVolume)volB, transformB,
                    ref collisionInfo);
            }

            if (volA.VolumeType == VolumeType.AABB && volB.VolumeType == VolumeType.Sphere)
            {
                return AABBSphereIntersection((AABBVolume)volA, transformA, (SphereVolume)volB, transformB,
                    ref collisionInfo);
            }

            if (volA.VolumeType == VolumeType.Sphere && volB.VolumeType == VolumeType.AABB)
            {
                collisionInfo.A = b;
                collisionInfo.B = a;

                return AABBSphereIntersection((AABBVolume)volB, transformB, (SphereVolume)volA, transformA,
                    ref collisionInfo);
            }

            return false;
        }

        static bool SphereIntersection(SphereVolume volA, Transform transformA, SphereVolume volB, Transform transformB,
            ref CollisionInfo collisionInfo)
        {
            throw new System.NotImplementedException();
        }

        static bool AABBIntersection(AABBVolume volA, Transform transformA, AABBVolume volB, Transform transformB,
            ref CollisionInfo collisionInfo)
        {
            throw new System.NotImplementedException();
        }

        static bool AABBSphereIntersection(AABBVolume volA, Transform transformA, SphereVolume volB, Transform transformB,
            ref CollisionInfo collisionInfo)
        {
            throw new System.NotImplementedException();
        }
    }
}