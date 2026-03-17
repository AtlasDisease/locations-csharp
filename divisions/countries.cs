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

        public bool organized()
        {
            return capital() != null;
        }

        public City capital()
        {
            return capitals().FirstOrDefault();
        }

        public IEnumerable<City> capitals()
        {
            return subdivisions.Cast<City>().Where(div => div.adminType.HasFlag(AdministrativeTypes.CAPITAL));
        }

        public void add_city(City city, County county)
        {
            county.add_city(city);
        }

        public void add_county(County county)
        {
            subdivisions.Add(county);
        }

        public void remove_county(County county)
        {
            subdivisions.Remove(county);
        }

        public IEnumerable<City> get_cities()
        {
            IEnumerable<T> chain<T>(params IEnumerable<T>[] collections)
            {
                foreach (var collection in collections)
                {
                    foreach (var item in collection)
                    {
                        yield return item;
                    }
                }
            }

            return chain(subdivisions.Cast<City>());
        }

        private IEnumerable<Division> find_capitals(IEnumerable<City> cities)
        {
            return cities.Where(city => city.adminType.HasFlag(AdministrativeTypes.CAPITAL));
        }

        private int count_capitals_in_subdivision(IEnumerable<City> subdivision)
        {
            return find_capitals(subdivision).Count();
        }
    }
}
