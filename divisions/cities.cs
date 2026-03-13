using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locations.divisions
{
    public enum CityTypes
    {
        UNKNOWN,
        LOST,
        SITE,
        COMMUNITY,
        TOWN,
        CITY
    }

    [Flags]
    public enum AdministrativeTypes
    {
        NONE,
        SEAT,
        CITY
    }


    public class City: Division
    {
        public CityTypes type;
        public AdministrativeTypes adminType;
        int population;

        public City(string name_, CityTypes type_ = CityTypes.UNKNOWN, AdministrativeTypes adminType_ = AdministrativeTypes.NONE, List<Division> subdivisions_ = null, int population_ = 0): base(name_, subdivisions_)
        {
            type = type_;
            adminType = adminType_;
            population = population_;
        }
    }
}
