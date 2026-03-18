using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locations.divisions
{
    using Neighborhood = Division;
    using District = Division;

    public class Division
    {
        public string name;
        protected List<Division> subdivisions;

        public Division(string name_, List<Division>? subdivisions_ = null)
        {
            name = name_;
            subdivisions = subdivisions_ ?? new List<Division>();
        }

        public virtual string ToString(string? format, IFormatProvider? formatProvider)
        {
            return name;
        }

        public virtual void add_subdivision(Division division)
        {
            subdivisions.Add(division);
        }
    }
}
