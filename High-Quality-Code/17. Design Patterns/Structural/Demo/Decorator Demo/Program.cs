using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Demo
{
    class Program
    {
        static void Main()
        {
            var sword = new Sword("The Patriarch", 150, 35);
            sword.DisplayStats();
            Console.WriteLine(new string('=',40));

            var axe = new Axe("Brainhew", 280, 10);
            axe.DisplayStats();
            Console.WriteLine(new string('=', 40));

            Console.WriteLine("-----Making sword craftable-----");
            var craftableSword = new Craftable(sword);
            craftableSword.AddRune("Dol");
            craftableSword.AddRune("Um");
            craftableSword.AddRune("Ber");
            craftableSword.AddRune("Ist");
            craftableSword.DisplayStats();
            Console.WriteLine(new string('=', 40));

            Console.WriteLine("-----Making axe craftable-----");
            var craftableAxe = new Craftable(axe);
            craftableAxe.AddRune("Fal");
            craftableAxe.AddRune("Ohm");
            craftableAxe.AddRune("Um");
            craftableAxe.DisplayStats();
            Console.WriteLine(new string('=', 40));

            Console.WriteLine("-----Making sword imbuable-----");
            var imbuableCraftableSword = new Imbuable(craftableSword);
            imbuableCraftableSword.Imbue("+ 150% Enchanced Damage");
            imbuableCraftableSword.Imbue("Adds 324 Magic Damage");
            imbuableCraftableSword.DisplayStats();
        }
    }
}
