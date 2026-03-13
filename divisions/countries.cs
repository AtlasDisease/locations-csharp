using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locations.divisions
{
    public class Country: Division
    {
        int max_capital_num;
        string prefix;

        public Country(string name_, List<Division> subdivisions_ = null, int max_capital_num_ = 1, string prefix_ = ""): base(name_, subdivisions_)
        {
            max_capital_num = max_capital_num_;
            prefix = prefix_;
        }
    }
}
