using UnityEngine;

namespace Asteroids
{
    public sealed class GameController : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        [SerializeField] private float _hp;
        private Player _player;

        private GameObject _barrel;
        private Fire _fire;
        [SerializeField] private float _force;
        private float _deltaTime;

        private InputController _inputController;

        private ShipController _shipController;

        private IExecute[] _executes;


        private Camera _camera;
        private Ship _ship;

        private void Start()
        {
            _player = new Player(_speed, _acceleration, _hp, this);
            _barrel = this.transform.Find("Barrel").gameObject;
            _fire = _barrel.gameObject.AddComponent<Fire>();


            _camera = Camera.main;
            var moveTransform = new AccelerationMove(transform, _player.speed, _player.acceleration);
            var rotation = new RotationShip(transform);
            _ship = new Ship(moveTransform, rotation);

            _inputController = new InputController(_ship, _fire);
            _shipController = new ShipController(_ship,_camera, this.gameObject);

            _executes = new IExecute[] { _inputController,_shipController };
        }

        private void Update()
        {
            _deltaTime = Time.deltaTime;
            for (int i = 0; i < _executes.Length; i++)
            {
                _executes[i].Execute(_deltaTime);
            }
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            _player.Collision();
        }

        public void Die()
        {
            Destroy(gameObject);
        }
    }
}
