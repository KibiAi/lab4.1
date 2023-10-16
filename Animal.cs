using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
     class Animal : LivingOrganism, IPredator, IReproducible
    {
        public string Species { get; set; }
        public int Speed { get; set; }

        public Animal(double energy, int age, double size, string species, int speed)
            : base(energy, age, size)
        {
            Species = species;
            Speed = speed;
        }

        public void Reproduce()
        {
            Console.WriteLine("Тварина розмножується.");
        }

        public void Hunt(LivingOrganism prey)
        {
            Console.WriteLine("Тварина полює на інший організм.");
        }
    }
}
