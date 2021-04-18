using UnityEngine;

namespace Asteroids
{
    public class Fire : MonoBehaviour
    {
        private Rigidbody2D _bullet;
        private float _force = 600;

        private void Awake()
        {
            _bullet = Resources.Load<Rigidbody2D>("Prefabs/Bullet");
        }

        public void FireBullet()
        {
            var temAmmunition = Instantiate(_bullet, this.transform.position, this.transform.rotation);
            temAmmunition.AddForce(this.transform.up * _force);
        }
    }
}
