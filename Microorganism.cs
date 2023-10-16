using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Microorganism : LivingOrganism, IReproducible
    {
        public string Type { get; set; }

        public Microorganism(double energy, int age, double size, string type)
            : base(energy, age, size)
        {
            Type = type;
        }

        public void Reproduce()
        {
            Console.WriteLine("Мікроорганізм розмножується.");
        }
    }

}
