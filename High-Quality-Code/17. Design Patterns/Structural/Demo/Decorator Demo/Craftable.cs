using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Demo
{
    class Craftable:WeaponDecorator
    {
        private readonly IList<string> runes = new List<string>();

        public Craftable(Weapon weapon) 
            : base(weapon)
        {

        }

        public void AddRune(string runeName)
        {
            this.runes.Add(runeName);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();

            Console.WriteLine("Crafted with runes: ");
            Console.WriteLine(string.Join(",",this.runes));
        }
    }
}
