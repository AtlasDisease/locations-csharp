using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locations.divisions
{
    class States: Division
    {
        public States(string name_, List<Division> subdivisions_): base(name_, subdivisions_)
        {
        }
    }
}
