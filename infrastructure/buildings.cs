using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locations.infrastructure
{
    public class Building
    {
        public string name;
        public List<Building> subdivisions;

        public Building(string name_, List<Building>? subdivisions_ = null)
        {
            name = name_;
            subdivisions = subdivisions_ ?? new List<Building>();
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return name;
        }
    }

    public class CommercialBuilding: Building
    {
        public CommercialBuilding(string name_, List<Building> subdivisions_ = null): base(name_, subdivisions_)
        {
        }
    }

    public class ResidentialBuilding : Building
    {
        int population;

        public ResidentialBuilding(string name_, List<Building> subdivisions_ = null, int population_ = 0) : base(name_, subdivisions_)
        {
            population = population_;
        }
    }
}
