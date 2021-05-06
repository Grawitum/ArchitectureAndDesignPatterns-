using UnityEngine;

namespace Asteroids.Bridge
{
    internal sealed class Example : MonoBehaviour
    {
        private void Start()
        {
            var enemy = new Enemy(new MagicalAttack(), new Infantry());
        }
    }
}
