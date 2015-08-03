using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Structures__Cond.Statements__Loops
{
    public class Chef
    {
        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }
        
        private Potato GetPotato()
        {
            return new Potato();
        }

        private void Peel(Vegetable vegetable)
        {
            throw new MissingMethodException();
        }

        private void Cut(Vegetable vegetable)
        {
            throw new MissingMethodException();
        }

        public void Cook(Vegetable[] products)
        {
            Bowl bowl = this.GetBowl();

            foreach (var vegetable in products)
            {
                this.Peel(vegetable);
                this.Cut(vegetable);
                bowl.Add(vegetable);                   
            }           
        }
    }
}
