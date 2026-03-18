using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locations.divisions
{
    class Continent: Division
    {
        public Continent(string name_, List<Division>? subdivisions_ = null): base(name_, subdivisions_)
        {
        }

        public void add_country(Country country)
        {
            subdivisions.Add(country);
        }
    }
}
