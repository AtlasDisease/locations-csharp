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
        CAPITAL
    }


    public class City: Division, IFormattable
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

        new public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format.Contains("F") || format.Contains("O"))
            {
                if (adminType != AdministrativeTypes.NONE)
                {
                    if (format.Contains("-"))
                        return $"The {adminType} of {name}";
                    return $"The {adminType} of {name}";
                }
                return $"The {type} of {name}";
            }
            return name;
        }

        public static bool operator ==(City city1, City city2)
        {
            return city1.type == city2.type;
        }

        public static bool operator !=(City city1, City city2)
        {
            return !(city1.type == city2.type);
        }

        public static bool operator >(City city1, City city2)
        {
            return city1.type >= city2.type;
        }

        public static bool operator <(City city1, City city2)
        {
            return city1.type <= city2.type;
        }

        public bool incorporated()
        {
            return type >= CityTypes.TOWN;
        }

        public bool abandoned()
        {
            return type < CityTypes.COMMUNITY && type != CityTypes.UNKNOWN;
        }

        public bool historical()
        {
            return type == CityTypes.SITE;
        }
    }
}
