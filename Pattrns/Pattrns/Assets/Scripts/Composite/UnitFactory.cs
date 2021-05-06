using System;

namespace Asteroids.Composite
{
    internal sealed class UnitFactory
    {
        public event Action<Unit> OnCreateUnit;
        public void CreateUnit()
        {
            ///
            var unit = new Unit();
            OnCreateUnit?.Invoke(unit);
        }
    }
}
