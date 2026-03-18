using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locations.divisions
{
    class Supercluster: Division
    {
        public Supercluster(string name_, List<Division>? subdivisions_ = null): base(name_, subdivisions_)
        {
        }

        public void add_local_group(LocalGroup localgroup)
        {
            subdivisions.Add(localgroup);
        }
    }
}
