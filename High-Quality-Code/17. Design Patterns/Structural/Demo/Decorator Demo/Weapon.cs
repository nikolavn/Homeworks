namespace Decorator_Demo
{
    internal abstract class Weapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int AttackSpeed { get; set; }

        public abstract void DisplayStats();
    }
}
