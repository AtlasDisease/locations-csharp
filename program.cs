using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using locations.divisions;

namespace locations
{
    class Program
    {
        static void Main()
        {
            ConsoleKeyInfo key;
            District district;
            City city, city1;
            County county, county1;
            Country country;
            Continent continent;
            Planet planet;
            Galaxy galaxy;
            LocalGroup localgroup;
            Supercluster supercluster;
            Universe universe;

            district = new District("Downtown");

            city = new City("Austin", CityTypes.CITY, AdministrativeTypes.SEAT | AdministrativeTypes.CITY, null, 1_007_435);
            city.subdivisions.Add(district);

            city1 = new City("Waco", CityTypes.CITY, AdministrativeTypes.SEAT);

            county = new County("Travis");
            county.subdivisions.Add(city);

            county1 = new County("McLennan");
            county1.subdivisions.Add(city1);

            country = new Country("Republic of Texas");
            country.subdivisions.Add(county);
            country.subdivisions.Add(county1);

            continent = new Continent("North America");
            continent.subdivisions.Add(country);

            planet = new Planet("Earth");
            planet.subdivisions.Add(continent);

            galaxy = new Galaxy("Milky Way");
            galaxy.subdivisions.Add(planet);

            localgroup = new LocalGroup("Local");
            localgroup.subdivisions.Add(galaxy);

            supercluster = new Supercluster("Laniakea");
            supercluster.subdivisions.Add(localgroup);

            universe = new Universe("Universe 1");
            universe.subdivisions.Add(supercluster);

            Console.Clear();
            Console.WriteLine(city.name);

            Console.WriteLine("Press 'Esc' to exit...");
            while (true)
            {
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
