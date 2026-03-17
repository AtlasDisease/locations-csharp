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
        public List<Division> subdivisions;

        public Division(string name_, List<Division> subdivisions_ = null)
        {
            name = name_;
            subdivisions = subdivisions_;
            if (subdivisions == null)
                subdivisions = new List<Division>();
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return name;
        }
    }
}
