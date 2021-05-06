using UnityEngine;

namespace Asteroids.Decorator
{
    internal sealed class ModificationAim : ModificationWeapon
    {
        private readonly IAim _aim;
        private readonly Vector3 _aimPosition;
        private GameObject _aimObject;

        public ModificationAim(IAim aim, Vector3 aimPosition)
        {
            _aim = aim;
            _aimPosition = aimPosition;
        }

        protected override Weapon AddModification(Weapon weapon)
        {
            _aimObject = Object.Instantiate(_aim.AimInstance, _aimPosition, Quaternion.identity);
            return weapon;
        }

        protected override Weapon RemoveModification(Weapon weapon)
        {
            _aimObject.SetActive(false);
            return weapon;
        }
    }
}
