using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using locations.divisions;

namespace locations.divisions
{
    class District: Division
    {
        public District(string name_, List<Division> subdivisions_ = null): base(name_, subdivisions_)
        {
            name = name_;
        }
    }
}
