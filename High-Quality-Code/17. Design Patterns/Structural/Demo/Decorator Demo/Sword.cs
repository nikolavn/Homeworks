using System;

namespace Decorator_Demo
{
    internal class Sword:Weapon
    {
        public Sword(string name,int damage, int attackSpeed)
        {
            this.Name = name;
            this.Damage = damage;
            this.AttackSpeed = attackSpeed;
        }

        public override void DisplayStats()
        {
            Console.WriteLine("--==Sword==--");
            Console.WriteLine("Name: {0}",this.Name);
            Console.WriteLine("Damage: {0}",this.Damage);
            Console.WriteLine("Attack speed: {0}",this.AttackSpeed);
        }
    }
}
