using UnityEngine;

namespace Asteroids.Composite
{
    internal sealed class Example : MonoBehaviour
    {
        private void Start()
        {
            var unitFactory = new UnitFactory();
            IAttack attack = new Unit();
            IAttack attack2 = new Unit();
            IAttack attack3 = new Unit();
            IAttack attack4 = new Unit();
            Detachment attacks = new Detachment();
            unitFactory.OnCreateUnit += attacks.AddUnit;
            attacks.AddUnit(attack);
            attacks.AddUnit(attack2);
            attacks.AddUnit(attack3);
            attacks.AddUnit(attack4);

            attack.Attack();
            
            attacks.Attack(); 
            
            attacks.RemoveUnit(attack);
        }
    }
}
