using UnityEngine;

namespace Asteroids
{
    public class ShipController:IExecute
    {
        private Ship _ship;
        private Camera _camera;
        private Vector3 _direction;
        private GameObject _position;

        public ShipController(Ship ship, Camera camera, GameObject position)
        {
            _ship = ship;
            _camera = camera;
            _position = position;
        }

        public void Execute(float deltaTime)
        {
            _direction = Input.mousePosition - _camera.WorldToScreenPoint(_position.transform.position);
            _ship.Rotation(_direction);
            _ship.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), deltaTime);
        }
    }
}