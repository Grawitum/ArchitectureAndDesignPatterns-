using UnityEngine;

namespace Asteroids.Bridge
{
    internal sealed class Example : MonoBehaviour
    {
        private void Start()
        {
            var mag = new Enemy(new MagicalAttack(), new Infantry());
            var swordsman = new Enemy(new SwordAttack(), new Running());
            var pilot = new Enemy(new ShootAttack(), new Flight());
        }
    }
}
