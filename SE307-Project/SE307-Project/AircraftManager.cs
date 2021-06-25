using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SE307_Project
{
    class AircraftManager : IDataService<AirCraft>, IOperationService<AirCraft, Country>
    {
        public void Add(AirCraft aircraft, Country country)
        {
            country.Aircrafts.Add(aircraft);
            Console.WriteLine("The following aircraft, " + aircraft.Type + ", has been added to the country: " + country.CountryName + ".");
            Console.WriteLine();
        }

        public void Delete(AirCraft aircraft, Country country)
        {
            bool isAircraftFound = false;
            foreach (var eachAircraft in country.Aircrafts)
            {
                if (aircraft.Type.Equals(eachAircraft.Type) && aircraft.Id == eachAircraft.Id)
                {
                    isAircraftFound = true;
                    break;
                }
            }

            if (isAircraftFound)
            {
                country.Aircrafts.Remove(aircraft);
                Console.WriteLine("The following aircraft, " + aircraft.Type + ", has been deleted from the country: " + country.CountryName + ".");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Turkey has no such aircraft.");
            }
        }

        public string ShowData(AirCraft aircraft)
        {

            Console.WriteLine("Here is the information of the aircraft: ");
            Console.WriteLine("Aircraft type: " + aircraft.Type);
            Console.WriteLine("Aircraft speed: " + aircraft.Speed);
            Console.WriteLine();
            return "Here is the information of the aircraft: " + "\n " + "Aircraft type: " + aircraft.Type + "\n" +
                   "Aircraft speed: " + aircraft.Speed;
        }
    }
}
