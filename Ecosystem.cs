using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Ecosystem
    {
        private List<LivingOrganism> organisms;

        public Ecosystem()
        {
            organisms = new List<LivingOrganism>();
        }

        public void AddOrganism(LivingOrganism organism)
        {
            organisms.Add(organism);
        }

        public void SimulateEcosystem()
        {
            foreach (LivingOrganism organism in organisms)
            {
              

                if (organism is IReproducible reproducible)
                {
                    reproducible.Reproduce();
                }

                if (organism is IPredator predator)
                { 
                    foreach (LivingOrganism prey in organisms.Where(o => o != organism))
                    {
                        predator.Hunt(prey);
                    }
                }
            }
        }
    }
}
