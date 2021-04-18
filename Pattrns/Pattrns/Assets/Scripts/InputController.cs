using UnityEngine;

namespace Asteroids
{
    public sealed class InputController : IExecute
    {
        private Ship _ship;
        private Fire _fire;

        public InputController(Ship ship, Fire fire)
        {
            _ship = ship;
            _fire = fire;
        }

        public void Execute(float deltaTime)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _ship.AddAcceleration();
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _ship.RemoveAcceleration();
            }

            if (Input.GetButtonDown("Fire1"))
            {
                _fire.FireBullet();
            }
        }
    }
}
