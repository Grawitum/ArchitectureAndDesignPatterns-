using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Decorator
{
    internal sealed class Aim : IAim
    {
        public Transform BarrelPositionAim { get; }
        public GameObject AimInstance { get; }

        public Aim(Transform barrelPositionAim, GameObject aimInstance)
        {
            BarrelPositionAim = barrelPositionAim;
            AimInstance = aimInstance;
        }
    }
}
