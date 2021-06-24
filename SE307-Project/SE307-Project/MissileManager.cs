using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SE307_Project
{
    class MissileManager : IDataService<Missile>, IOperationService<Missile, Country>
    {
        public void Add(Missile missile, Country country)
        {
            country.Missiles.Add(missile);
            Console.WriteLine("The following missile, " + missile.Type + ", has been added to the country: " + country.CountryName + ".");
            Console.WriteLine();
        }

        public void Delete(Missile missile, Country country)
        {
            bool isMissileFound = false;
            foreach (var eachMissile in country.Missiles)
            {
                if (missile.Type.Equals(eachMissile.Type) && missile.Id == eachMissile.Id)
                {
                    isMissileFound = true;
                    break;
                }
            }

            if (isMissileFound)
            {
                country.Missiles.Remove(missile);
                Console.WriteLine("The following missile, " + missile.Type + ", has been deleted from the country: " + country.CountryName + ".");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Turkey has no such missile.");
            }
        }

        public string ShowData(Missile missile)
        {
            Console.WriteLine("Missile type: " + missile.Type);
            Console.WriteLine("Missile speed: " + missile.Speed);
            Console.WriteLine("Missile status: " + missile.MissilesStaus);
            return "Missile type: " + missile.Type + "\n" + "Missile speed: " + missile.Speed + "\n" +
                   "Missile status: " + missile.MissilesStaus;
        }
    }
}
