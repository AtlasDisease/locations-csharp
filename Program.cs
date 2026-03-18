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
            District district, district1;
            City city, city1;
            County county, county1;
            Country country;
            Continent continent;
            Planet planet;
            PlanetarySystem planetary_system;
            Galaxy galaxy;
            LocalGroup localgroup;
            Supercluster supercluster;
            Universe universe;

            district = new District("Downtown");
            district1 = new District("Downtown");

            city = new City("Austin", CityTypes.CITY, AdministrativeTypes.SEAT | AdministrativeTypes.CAPITAL, null, 1_007_435);
            city.add_subdivision(district);

            city1 = new City("Waco", CityTypes.CITY, AdministrativeTypes.SEAT);
            city.add_subdivision(district1);

            county = new County("Travis");
            county.add_city(city);

            county1 = new County("McLennan");
            county1.add_city(city1);

            country = new Country("Republic of Texas");
            country.add_county(county);
            country.add_county(county1);

            continent = new Continent("North America");
            continent.add_country(country);

            planet = new Planet("Earth");
            planet.add_continent(continent);

            planetary_system = new PlanetarySystem("Solar");
            planetary_system.add_planet(planet);

            galaxy = new Galaxy("Milky Way");
            galaxy.add_planetary_system(planetary_system);

            localgroup = new LocalGroup("Local");
            localgroup.add_galaxy(galaxy);

            supercluster = new Supercluster("Laniakea");
            supercluster.add_local_group(localgroup);

            universe = new Universe("Universe 1");
            universe.add_supercluster(supercluster);

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

