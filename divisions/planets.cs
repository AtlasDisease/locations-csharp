using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locations.divisions
{
    class Planet: Division
    {
        public Planet(string name_, List<Division>? subdivisions_ = null): base(name_, subdivisions_)
        {
        }

        public void add_continent(Continent continent)
        {
            subdivisions.Add(continent);
        }
    }
}
