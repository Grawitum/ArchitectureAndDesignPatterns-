using UnityEngine;

namespace Asteroids.Decorator
{
    internal interface IAim 
    {
        Transform BarrelPositionAim { get; }
        GameObject AimInstance { get; }
    }
}
