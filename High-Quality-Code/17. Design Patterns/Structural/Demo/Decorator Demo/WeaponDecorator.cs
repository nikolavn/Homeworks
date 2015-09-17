namespace Decorator_Demo
{
    internal abstract class WeaponDecorator:Weapon
    {
        protected WeaponDecorator(Weapon weapon)
        {
            this.Weapon = weapon;
        }

        protected Weapon Weapon { get; private set; }

        public override void DisplayStats()
        {
            this.Weapon.DisplayStats();
        }
    }
}
