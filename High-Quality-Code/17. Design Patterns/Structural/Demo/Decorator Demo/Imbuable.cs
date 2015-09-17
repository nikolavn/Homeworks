using System;
using System.Collections.Generic;

namespace Decorator_Demo
{
    internal class Imbuable:WeaponDecorator
    {
        private readonly IList<string> magicProperties = new List<string>();

        public Imbuable(Weapon weapon) 
            : base(weapon)
        {

        }

        public void Imbue(string magicProperty)
        {
            this.magicProperties.Add(magicProperty);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();

            Console.WriteLine("Imbued with: ");
            foreach (var item in this.magicProperties)
            {
                Console.WriteLine(item);
            }
        }
    }
}
