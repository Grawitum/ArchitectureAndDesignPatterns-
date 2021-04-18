
namespace Asteroids
{
    public class MyPlayer
    {
        public float speed { get; private set; }
        public float acceleration { get; private set; }
        private float hp { get; set ; }
        private Player _player;

        public MyPlayer(float speed, float acceleration, float hp, Player player)
        {
            this.speed = speed;
            this.acceleration = acceleration;
            this.hp = hp;
            _player = player;
        }

        public void TakeDamage(float damage)
        {
            hp -= damage;
        }

        public void Collision()
        {
            if (hp <= 0)
            {
                _player.Die();
            }
            else
            {
                TakeDamage(1);
            }
        }
    }
}
