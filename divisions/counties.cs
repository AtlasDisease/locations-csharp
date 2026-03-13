using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locations.divisions
{
    class County: Division
    {
        int max_seat_num;

        public County(string name_, List<Division> subdivisions_ = null, int max_seat_num_ = 1): base(name_, subdivisions_)
        {
            max_seat_num = max_seat_num_;
        }
    }
}
