using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locations.divisions
{
    class LocalGroup: Division
    {
        public LocalGroup(string name_, List<Division> subdivisions_ = null): base(name_, subdivisions_)
        {
        }
    }
}
