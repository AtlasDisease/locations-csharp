using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locations.divisions
{
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
    }
}
