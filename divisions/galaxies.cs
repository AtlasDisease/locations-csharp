using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locations.divisions
{
    class Galaxy: Division
    {
        public Galaxy(string name_, List<Division>? subdivisions_ = null): base(name_, subdivisions_)
        {
        }

        public void add_planetary_system(PlanetarySystem planetary_system)
        {
            subdivisions.Add(planetary_system);
        }
    }
}
