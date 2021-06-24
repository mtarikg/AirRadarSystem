using System;
using System.Collections.Generic;

namespace SE307_Project
{
    class Program
    {
        public static void MainMenu()
        {
            Console.WriteLine("Please Choose an Operation that you want to do ");
            Console.WriteLine("1- Show The Data of The Country");
            Console.WriteLine("2- Show The Data Of The Missiles");
            Console.WriteLine("3- Modify The Allies For The Country");
            Console.WriteLine("4- Modify The Enemies For The Country");
            Console.WriteLine("5- Open Logs File");
            Console.WriteLine("6- Simulate a Scenario");
            Console.WriteLine("7- Terminate The Program");
        }

        public static void  ScenarioMenu()
        {
            Console.WriteLine("Please Choose The Scenario That You Want to Process");
            Console.WriteLine("1- Friend AirCraft is Entering The Lands of Turkey");
            Console.WriteLine("2- Enemy AirCraft is Entering The Lands of Turkey ");
            Console.WriteLine("3- F.O.E AirCraft is Entering The Lands Of Turkey");
            Console.WriteLine("4- Unkown Aircraft is Entering The Lands Of Turkey");
            Console.WriteLine("5- Go Back To The Main Screen");
        }

        public static void LogOptions()
        {
            Console.WriteLine("Please Choose What type of Operation you want to do it on the Logs");
            Console.WriteLine("1- Open And Read The Logs File");
            Console.WriteLine("2- Delete The Logs File ");
            Console.WriteLine("3- Delete And Create New Logs File");
            Console.WriteLine("4- Go Back");
        }
        public static void Main(string[] args)
        {

            AirStation airStationTurkey = new AirStation("Air Station Turkey", new Radar(), new Alert());

            AirCraft aircraft1 = new Friend_AirCraft(1, "F-16", "Turkey", "Denmark", 70.0, 35, 37);
            AirCraft aircraft2 = new Friend_AirCraft(2, "F-16", "Turkey", "Estonia", 75.0, 35, 37);
            AircraftManager aircraftManager = new AircraftManager();
            MissileManager missileManager = new MissileManager();
            AirCraft UnkownAirCraft = new Unkown_AirCraft(3, "F-15", null, null, 500, 13, 9); //towards Turkey
            AirCraft foeAirCraft = new F_O_E_AirCraft(4, "F-20", "China", "Syria", 400, 13, 9);
            AirCraft enemyAirCraft = new EnemyAirCraft(5,"SP-20","U.S.A","Turkey",450,13,9);
            AirCraft friendAirCraft = new Friend_AirCraft(6, "SC-30", "Qatar", "Germany", 350, 13, 9);
            LightMissiles lightMissilesEnemyScene = new LightMissiles(3221,400,"Light Rockets",8);
            SuperMissiles superMissilesEnemyScene = new SuperMissiles(1223,500,"Super Rockets",9);
            LightMissiles lightMissilesUnkownScene = new LightMissiles(4545,550,"Light Rockets",8);
            SuperMissiles superMissilesUnkownScene = new SuperMissiles(5454,700,"Super Rockets",9);
            LightMissiles lightMissilesF_O_EScene = new LightMissiles(7878,200,"Light Rockets",8);
            SuperMissiles superMissilesF_O_EScene = new SuperMissiles(8787,300,"Super Rockets",9);
            CalculationManager calculationManager = new CalculationManager();
           
            Country country1 = new Country(1, "Turkey", "85 million", "783.562 km2", airStationTurkey,
                new List<AirCraft> { },
                new List<Missile> { }, new List<Country> { }, new List<Country> { }, new LightMissilesStation(),
                new SuperMissilesStation());
            while (true)
            {
               MainMenu();
                int operationChoice=Int32.Parse(Console.ReadLine());
                if (operationChoice <= 0 || operationChoice > 7)
                {
                    Console.WriteLine("You Have chosen invalid Operation please choose valid choice");
                    continue;
                }

                switch (operationChoice)
                {
                    case 1:
                        case 2:
                        case 3:
                        case 4:
                        aircraftManager.ShowData(aircraft2);
                        aircraftManager.Add(aircraft2, country1);
                        
                        CountryManager countryManager = new CountryManager(aircraftManager, missileManager);
                        countryManager.ShowData(country1);

                        aircraftManager.Delete(aircraft2, country1);
                        aircraftManager.Add(aircraft1, country1);
                        countryManager.ShowData(country1);

                        Console.ReadLine();
                        break;
                    case 5:
                        LogOptions();
                        int logsChoice=Int32.Parse(Console.ReadLine());
                        if (logsChoice <= 0 || logsChoice > 4)
                        {
                            Console.WriteLine("Please Enter Valid Logs Option");
                            break;
                        }

                        switch (logsChoice)
                        {
                            case 1:
                                Console.WriteLine("Reading Part is on Process");
                                country1.AirStation.Radar.ReadLogs();
                                    break;
                                case 2:
                                    country1.AirStation.Radar.deleteLog();
                                    Console.WriteLine("The Log is Deleted");
                                    break;
                                case 3:
                                    country1.AirStation.Radar.deleteLog();
                                    Console.WriteLine("The log is deleted");
                                    country1.AirStation.Radar.createNewLog();
                                    Console.WriteLine("New log is created");
                                    break;
                                case 4:
                                    break;
                                
                        }

                        ;
                        break;
                    
                    
                    case 6:
                        while (true)
                        {
                            ScenarioMenu();
                            int scenarioChoice=Int32.Parse(Console.ReadLine());
                            if (scenarioChoice <= 0 || scenarioChoice > 5)
                            {
                                Console.WriteLine("Please Enter a Valid Scenario");
                                continue;
                            }

                            switch (scenarioChoice)
                            {
                                case 1:
                                    Console.WriteLine("One AirCraft is Entering The Lands Of Turkey");
                                    Console.WriteLine("Here is its Details: ");
                                   aircraftManager.ShowData(friendAirCraft);
                                    Console.WriteLine("It is found that is a Friend AirCraft");
                                    country1.AirStation.Radar.saveIntoLogs(friendAirCraft);
                                    
                                    break;
                                case 2:
                                    country1.AirStation.Radar.LowRiskRadius = country1.LightMissilesStation.Location;
                                    country1.AirStation.Radar.HighRiskRadius = country1.SuperMissilesStation.Location;
                                    Console.WriteLine("One AirCraft is Entering The Lands Of Turkey");
                                    country1.AirStation.Radar.saveIntoLogs(enemyAirCraft);
                                   Console.WriteLine( country1.AirStation.Alert.lowRiskMessaage());
                                    Console.WriteLine("Here is the Details: ");
                                    aircraftManager.ShowData(enemyAirCraft);
                                    Console.WriteLine("It is show that this is Aircraft for enemies");
                                    Console.WriteLine("Defensive Operation will be considered");
                                    Console.WriteLine("The Light Missiles are ready to be fired");
                                    country1.LightMissilesStation.fireTheMissiles(lightMissilesEnemyScene,enemyAirCraft);
                                    if (country1.LightMissilesStation.IsHitStatus == false)
                                    {
                                        Console.WriteLine(country1.AirStation.Alert.highRiskMessage());
                                        Console.WriteLine("So The Light Missiles failed ");
                                        Console.WriteLine("It is now the turn to fire the super missiles");
                                        Console.WriteLine("Super Missiles are ready to be fired ");
                                        country1.SuperMissilesStation.fireTheMissiles(superMissilesEnemyScene,enemyAirCraft);
                                        if (country1.SuperMissilesStation.IsHitStatus == true)
                                        {
                                            calculationManager.MissilesStation = country1.SuperMissilesStation;
                                            calculationManager.MissileT = superMissilesEnemyScene;
                                            calculationManager.AirCraftT = enemyAirCraft;
                                            calculationManager.methodsContainer();
                                        }
                                        break;
                                    }

                                    calculationManager.MissilesStation = country1.LightMissilesStation;
                                    calculationManager.MissileT = lightMissilesEnemyScene;
                                    calculationManager.AirCraftT = enemyAirCraft;
                                    calculationManager.methodsContainer();
                                    break;
                                case 3:
                                    Console.WriteLine( country1.AirStation.Alert.lowRiskMessaage());
                                    country1.AirStation.Radar.LowRiskRadius = country1.LightMissilesStation.Location;
                                    country1.AirStation.Radar.HighRiskRadius = country1.SuperMissilesStation.Location;
                                    Console.WriteLine("One AirCraft is Entering The Lands Of Turkey");
                                    country1.AirStation.Radar.saveIntoLogs(foeAirCraft);
                                    
                                    Console.WriteLine("Here is the Details: ");
                                    aircraftManager.ShowData(foeAirCraft);
                                    Console.WriteLine("It is show that this is Aircraft for friend of an enemy");
                                    Console.WriteLine("Defensive Operation will be considered");
                                    Console.WriteLine("The Light Missiles are ready to be fired");
                                    country1.LightMissilesStation.fireTheMissiles(lightMissilesF_O_EScene,foeAirCraft);
                                    if (country1.LightMissilesStation.IsHitStatus == false)
                                    {
                                        Console.WriteLine(country1.AirStation.Alert.highRiskMessage());
                                        Console.WriteLine("So The Light Missiles failed ");
                                        Console.WriteLine("It is now the turn to fire the super missiles");
                                        Console.WriteLine("Super Missiles are ready to be fired ");
                                        country1.SuperMissilesStation.fireTheMissiles(superMissilesF_O_EScene,foeAirCraft);
                                        if (country1.SuperMissilesStation.IsHitStatus == true)
                                        {
                                            calculationManager.MissilesStation = country1.SuperMissilesStation;
                                            calculationManager.MissileT = superMissilesF_O_EScene;
                                            calculationManager.AirCraftT = foeAirCraft;
                                            calculationManager.methodsContainer();
                                        }
                                        break;
                                    }

                                    calculationManager.MissilesStation = country1.LightMissilesStation;
                                    calculationManager.MissileT = lightMissilesF_O_EScene;
                                    calculationManager.AirCraftT = foeAirCraft;
                                    calculationManager.methodsContainer();
                                    break;
                                case 4:
                                    Console.WriteLine( country1.AirStation.Alert.lowRiskMessaage());
                                    country1.AirStation.Radar.LowRiskRadius = country1.LightMissilesStation.Location;
                                    country1.AirStation.Radar.HighRiskRadius = country1.SuperMissilesStation.Location;
                                    Console.WriteLine("One AirCraft is Entering The Lands Of Turkey");
                                    country1.AirStation.Radar.saveIntoLogs(UnkownAirCraft);
                                    Console.WriteLine("Here is the Details: ");
                                    aircraftManager.ShowData(UnkownAirCraft);
                                    Console.WriteLine("It is show that this is Aircraft for enemies");
                                    Console.WriteLine("Defensive Operation will be considered");
                                    Console.WriteLine("The Light Missiles are ready to be fired");
                                    country1.LightMissilesStation.fireTheMissiles(lightMissilesUnkownScene,UnkownAirCraft);
                                    if (country1.LightMissilesStation.IsHitStatus == false)
                                    {
                                        Console.WriteLine(country1.AirStation.Alert.highRiskMessage());
                                        Console.WriteLine("So The Light Missiles failed ");
                                        Console.WriteLine("It is now the turn to fire the super missiles");
                                        Console.WriteLine("Super Missiles are ready to be fired ");
                                        country1.SuperMissilesStation.fireTheMissiles(superMissilesUnkownScene,UnkownAirCraft);
                                        if (country1.SuperMissilesStation.IsHitStatus == true)
                                        {
                                            calculationManager.MissilesStation = country1.SuperMissilesStation;
                                            calculationManager.MissileT = superMissilesUnkownScene;
                                            calculationManager.AirCraftT = UnkownAirCraft;
                                            calculationManager.methodsContainer();
                                        }
                                        break;
                                    }

                                    calculationManager.MissilesStation = country1.LightMissilesStation;
                                    calculationManager.MissileT = lightMissilesUnkownScene;
                                    calculationManager.AirCraftT = UnkownAirCraft;
                                    calculationManager.methodsContainer();
                                    break;
                                case 5:
                                    Console.WriteLine("Going Back :)");
                                        break;
                            }
                            break;
                        }
                        
                        break;

                        case 7:
                            Console.WriteLine("Good Bye :)");
                            return;
                }
                




            }
        }
    }
}