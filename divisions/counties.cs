using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locations.divisions
{
    //using Parish = County; // French version of county
    //using Shire = County; // English (UK) version of county
    //using Oblast = County; //Russian version of county
    //using Borough = County; //Alaskan version of county

    public class County: Division
    {
        int max_seat_num;

        public County(string name_, List<Division>? subdivisions_ = null, int max_seat_num_ = 1): base(name_, subdivisions_)
        {
            max_seat_num = max_seat_num_;
        }

        public IEnumerable<City> cities()
        {
            return subdivisions.Cast<City>();
        }

        public bool organized()
        {
            return seat() is not null;
        }

        public City? seat()
        {
            return seats().FirstOrDefault();
        }

        public IEnumerable<City> seats()
        {
            return subdivisions.Cast<City>().Where(div => div.adminType.HasFlag(AdministrativeTypes.SEAT));
        }

        public void add_city(Division div)
        {
            subdivisions.Add(div);
        }

        public void remove_city(Division div)
        {
            subdivisions.Remove(div);
        }

        public void move_seat(ref City old_seat, ref City new_seat)
        {
            old_seat.adminType = AdministrativeTypes.NONE;
            new_seat.adminType = AdministrativeTypes.SEAT;
        }
    }
}
