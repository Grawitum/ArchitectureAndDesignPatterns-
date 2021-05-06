
namespace Asteroids
{
    public class Player
    {
        public float speed { get; private set; }
        public float acceleration { get; private set; }
        private float hp { get; set ; }
        private GameController _gameController;

        public Player(float speed, float acceleration, float hp, GameController gameController)
        {
            this.speed = speed;
            this.acceleration = acceleration;
            this.hp = hp;
            _gameController = gameController;
        }

        public void TakeDamage(float damage)
        {
            hp -= damage;
        }

        public void Collision()
        {
            if (hp <= 0)
            {
                _gameController.Die();
            }
            else
            {
                TakeDamage(1);
            }
        }
    }
}
