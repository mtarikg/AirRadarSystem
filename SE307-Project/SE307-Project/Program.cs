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
            Console.WriteLine("7- Display All The Data And Terminate The Program ");
        }

        public static void ScenarioMenu()
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
            AirCraft enemyAirCraft = new EnemyAirCraft(5, "SP-20", "U.S.A", "Turkey", 450, 13, 9);
            AirCraft friendAirCraft = new Friend_AirCraft(6, "SC-30", "Qatar", "Germany", 350, 13, 9);
            LightMissiles lightMissilesEnemyScene = new LightMissiles(3221, 400, "Light Rockets", 8);
            SuperMissiles superMissilesEnemyScene = new SuperMissiles(1223, 500, "Super Rockets", 9);
            LightMissiles lightMissilesUnkownScene = new LightMissiles(4545, 550, "Light Rockets", 8);
            SuperMissiles superMissilesUnkownScene = new SuperMissiles(5454, 700, "Super Rockets", 9);
            LightMissiles lightMissilesF_O_EScene = new LightMissiles(7878, 200, "Light Rockets", 8);
            SuperMissiles superMissilesF_O_EScene = new SuperMissiles(8787, 300, "Super Rockets", 9);
            CalculationManager calculationManager = new CalculationManager();
            int numberOfAirCrafts = 0;
            int numberOfEnemyAirCrafts = 0;
            int numberOfFOEAirCrafts = 0;
            int numberOfUnkownAirCrafts = 0;
            int numberOfFriendAirCrafts = 0;
            List<AirCraft> enemyAirCrafts = new List<AirCraft>();
            List<AirCraft> friendAirCrafts = new List<AirCraft>();
            List<AirCraft> unkownAirCrafts = new List<AirCraft>();
            List<AirCraft> fOEAirCrafts = new List<AirCraft>();
            List<AirCraft> destroyedAirCrafts = new List<AirCraft>();
            List<AirCraft> passedAirCrafts = new List<AirCraft>();

            Country country1 = new Country(1, "Turkey", "85 million", "783.562 km2", airStationTurkey,
                new List<AirCraft> { },
                new List<Missile> { }, new List<Country> { }, new List<Country> { }, new LightMissilesStation(),
                new SuperMissilesStation());

            Country country2 = new Country(2, "Azerbaijan", "10.02 million", "86.600 km2");
            Country country3 = new Country(2, "Chile", "19 million", "756.950 km2");
            CountryManager countryManager = new CountryManager(aircraftManager, missileManager);

            while (true)
            {
                MainMenu();
                int operationChoice = Int32.Parse(Console.ReadLine());
                if (operationChoice <= 0 || operationChoice > 7)
                {
                    Console.WriteLine("You Have chosen invalid Operation please choose valid choice");
                    continue;
                }

                switch (operationChoice)
                {
                    case 1:
                        countryManager.ShowData(country1);
                        break;
                    case 2:
                        break;
                    case 3:
                        countryManager.ShowData(country2);
                        countryManager.Add(country2, country1);
                        countryManager.ShowData(country1);
                        break;
                    case 4:
                        countryManager.ShowData(country3);
                        countryManager.Add(country3, country1);
                        countryManager.ShowData(country1);
                        break;
                    case 5:
                        LogOptions();
                        int logsChoice = Int32.Parse(Console.ReadLine());
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
                            int scenarioChoice = Int32.Parse(Console.ReadLine());
                            if (scenarioChoice <= 0 || scenarioChoice > 5)
                            {
                                Console.WriteLine("Please Enter a Valid Scenario");
                                continue;
                            }

                            switch (scenarioChoice)
                            {
                                case 1:
                                    numberOfFriendAirCrafts++;
                                    friendAirCrafts.Add(friendAirCraft);
                                    Console.WriteLine("One AirCraft is Entering The Lands Of Turkey");
                                    Console.WriteLine("Here is its Details: ");
                                    aircraftManager.ShowData(friendAirCraft);
                                    Console.WriteLine("It is found that is a Friend AirCraft");
                                    country1.AirStation.Radar.saveIntoLogs(friendAirCraft);
                                    numberOfAirCrafts++;
                                    break;
                                case 2:
                                    numberOfAirCrafts++;
                                    numberOfEnemyAirCrafts++;
                                    enemyAirCrafts.Add(enemyAirCraft);
                                    country1.AirStation.Radar.LowRiskRadius = country1.LightMissilesStation.Location;
                                    country1.AirStation.Radar.HighRiskRadius = country1.SuperMissilesStation.Location;
                                    Console.WriteLine("One AirCraft is Entering The Lands Of Turkey");
                                    country1.AirStation.Radar.saveIntoLogs(enemyAirCraft);
                                    Console.WriteLine(country1.AirStation.Alert.lowRiskMessaage());
                                    Console.WriteLine("Here is the Details: ");
                                    aircraftManager.ShowData(enemyAirCraft);
                                    Console.WriteLine("It is shown that this is Aircraft for enemies");
                                    Console.WriteLine("Defensive Operation will be considered");
                                    Console.WriteLine("The Light Missiles are ready to be fired");
                                    country1.LightMissilesStation.fireTheMissiles(lightMissilesEnemyScene,
                                        enemyAirCraft);
                                    if (country1.LightMissilesStation.IsHitStatus == false)
                                    {
                                        Console.WriteLine(country1.AirStation.Alert.highRiskMessage());
                                        Console.WriteLine("So The Light Missiles failed ");
                                        Console.WriteLine("It is now the turn to fire the super missiles");
                                        Console.WriteLine("Super Missiles are ready to be fired ");
                                        country1.SuperMissilesStation.fireTheMissiles(superMissilesEnemyScene,
                                            enemyAirCraft);
                                        if (country1.SuperMissilesStation.IsHitStatus == false)
                                        {
                                            passedAirCrafts.Add(enemyAirCraft);
                                        }
                                        else
                                        {
                                            calculationManager.MissilesStation = country1.SuperMissilesStation;
                                            calculationManager.MissileT = superMissilesEnemyScene;
                                            calculationManager.AirCraftT = enemyAirCraft;
                                            calculationManager.methodsContainer();
                                            destroyedAirCrafts.Add(enemyAirCraft);

                                        }

                                        break;
                                    }

                                    if (country1.LightMissilesStation.IsHitStatus == false)
                                    {

                                        passedAirCrafts.Add(enemyAirCraft);
                                        Console.WriteLine("The AirCraft has escaped");
                                        break;
                                    }
                                    calculationManager.MissilesStation = country1.LightMissilesStation;
                                    calculationManager.MissileT = lightMissilesEnemyScene;
                                    calculationManager.AirCraftT = enemyAirCraft;
                                    calculationManager.methodsContainer();
                                    destroyedAirCrafts.Add(enemyAirCraft);
                                    break;
                                case 3:
                                    numberOfAirCrafts++;
                                    numberOfFOEAirCrafts++;
                                    fOEAirCrafts.Add(foeAirCraft);
                                    Console.WriteLine(country1.AirStation.Alert.lowRiskMessaage());
                                    country1.AirStation.Radar.LowRiskRadius = country1.LightMissilesStation.Location;
                                    country1.AirStation.Radar.HighRiskRadius = country1.SuperMissilesStation.Location;
                                    Console.WriteLine("One AirCraft is Entering The Lands Of Turkey");
                                    country1.AirStation.Radar.saveIntoLogs(foeAirCraft);

                                    Console.WriteLine("Here is the Details: ");
                                    aircraftManager.ShowData(foeAirCraft);
                                    Console.WriteLine("It is show that this is Aircraft for friend of an enemy");
                                    Console.WriteLine("Defensive Operation will be considered");
                                    Console.WriteLine("The Light Missiles are ready to be fired");
                                    country1.LightMissilesStation.fireTheMissiles(lightMissilesF_O_EScene, foeAirCraft);
                                    if (country1.LightMissilesStation.IsHitStatus == false)
                                    {
                                        Console.WriteLine(country1.AirStation.Alert.highRiskMessage());
                                        Console.WriteLine("So The Light Missiles failed ");
                                        Console.WriteLine("It is now the turn to fire the super missiles");
                                        Console.WriteLine("Super Missiles are ready to be fired ");
                                        country1.SuperMissilesStation.fireTheMissiles(superMissilesF_O_EScene,
                                            foeAirCraft);
                                        if (country1.SuperMissilesStation.IsHitStatus == false)
                                        {
                                            Console.WriteLine("The AirCraft has escaped");
                                            passedAirCrafts.Add(foeAirCraft);
                                        }
                                        else
                                        {
                                            calculationManager.MissilesStation = country1.SuperMissilesStation;
                                            calculationManager.MissileT = superMissilesF_O_EScene;
                                            calculationManager.AirCraftT = foeAirCraft;
                                            calculationManager.methodsContainer();
                                            destroyedAirCrafts.Add(foeAirCraft);
                                            passedAirCrafts.Add(foeAirCraft);
                                        }

                                        break;
                                    }

                                    if (country1.LightMissilesStation.IsHitStatus == false)
                                    {

                                        passedAirCrafts.Add(foeAirCraft);
                                        break;
                                    }
                                    calculationManager.MissilesStation = country1.LightMissilesStation;
                                    calculationManager.MissileT = lightMissilesF_O_EScene;
                                    calculationManager.AirCraftT = foeAirCraft;
                                    destroyedAirCrafts.Add(foeAirCraft);
                                    calculationManager.methodsContainer();
                                    break;
                                case 4:
                                    numberOfAirCrafts++;
                                    numberOfUnkownAirCrafts++;
                                    unkownAirCrafts.Add(UnkownAirCraft);
                                    Console.WriteLine(country1.AirStation.Alert.lowRiskMessaage());
                                    country1.AirStation.Radar.LowRiskRadius = country1.LightMissilesStation.Location;
                                    country1.AirStation.Radar.HighRiskRadius = country1.SuperMissilesStation.Location;
                                    Console.WriteLine("One AirCraft is Entering The Lands Of Turkey");
                                    country1.AirStation.Radar.saveIntoLogs(UnkownAirCraft);
                                    Console.WriteLine("Here is the Details: ");
                                    aircraftManager.ShowData(UnkownAirCraft);
                                    Console.WriteLine("It is show that this is Aircraft for enemies");
                                    Console.WriteLine("Defensive Operation will be considered");
                                    Console.WriteLine("The Light Missiles are ready to be fired");
                                    country1.LightMissilesStation.fireTheMissiles(lightMissilesUnkownScene,
                                        UnkownAirCraft);
                                    if (country1.LightMissilesStation.IsHitStatus == false)
                                    {
                                        Console.WriteLine(country1.AirStation.Alert.highRiskMessage());
                                        Console.WriteLine("So The Light Missiles failed ");
                                        Console.WriteLine("It is now the turn to fire the super missiles");
                                        Console.WriteLine("Super Missiles are ready to be fired ");
                                        country1.SuperMissilesStation.fireTheMissiles(superMissilesUnkownScene,
                                            UnkownAirCraft);
                                        if (country1.SuperMissilesStation.IsHitStatus == false)
                                        {

                                            passedAirCrafts.Add(UnkownAirCraft);
                                        }
                                        else
                                        {
                                            calculationManager.MissilesStation = country1.SuperMissilesStation;
                                            calculationManager.MissileT = superMissilesUnkownScene;
                                            calculationManager.AirCraftT = UnkownAirCraft;
                                            destroyedAirCrafts.Add(UnkownAirCraft);
                                            calculationManager.methodsContainer();
                                        }

                                        break;
                                    }

                                    if (lightMissilesUnkownScene.IsHit == false)
                                    {

                                        Console.WriteLine("The AirCraft has escaped");
                                        passedAirCrafts.Add(UnkownAirCraft);
                                        break;
                                    }
                                    calculationManager.MissilesStation = country1.LightMissilesStation;
                                    calculationManager.MissileT = lightMissilesUnkownScene;
                                    calculationManager.AirCraftT = UnkownAirCraft;
                                    calculationManager.methodsContainer();
                                    destroyedAirCrafts.Add(UnkownAirCraft);
                                    break;
                                case 5:
                                    Console.WriteLine("Going Back :)");
                                    break;
                            }

                            break;
                        }

                        break;

                    case 7:
                        Console.WriteLine("Data Demo");
                        Console.WriteLine("We Have " + numberOfAirCrafts + " AirCraft in this simulation");
                        Console.WriteLine("......\n......\n......");
                        Console.WriteLine("Friend AirCraft Data Demo");
                        int Counter = 1;
                        if (friendAirCrafts.Count != 0)
                        {
                            Console.WriteLine("Friend Air Crafts repeated: " + numberOfFriendAirCrafts);
                            foreach (var FAR in friendAirCrafts)
                            {
                                Console.WriteLine("Friend AirCraft Number " + Counter + " Data");
                                aircraftManager.ShowData(FAR);
                                Console.WriteLine("The Air Craft is moving from " + FAR.Departure + " to " + FAR.Destination);
                                Counter++;

                            }

                        }
                        else
                        {
                            Console.WriteLine("We Did not implement any friend air crafts in the simulation");

                        }
                        Console.WriteLine("......\n......\n......");
                        Counter = 1;
                        if (enemyAirCrafts.Count != 0)
                        {
                            Console.WriteLine("Enemy Air Crafts repeated: " + numberOfEnemyAirCrafts);
                            foreach (var EAR in enemyAirCrafts)
                            {
                                Console.WriteLine("Enemy AirCraft Number " + Counter + " Data");
                                aircraftManager.ShowData(EAR);
                                Console.WriteLine("The Air Craft is moving from " + EAR.Departure + " to " + EAR.Destination);
                                Counter++;

                            }
                        }
                        else
                        {
                            Console.WriteLine("We Did not implement any enemies air crafts in the simulation");

                        }
                        Console.WriteLine("......\n......\n......");
                        Console.WriteLine("FOE AirCrafts Data Demo");
                        Counter = 1;
                        if (fOEAirCrafts.Count != 0)
                        {
                            Console.WriteLine("FOE Air Crafts repeated: " + numberOfFOEAirCrafts);
                            foreach (var FOE in fOEAirCrafts)
                            {
                                Console.WriteLine("FOE AirCraft Number " + Counter + " Data");
                                aircraftManager.ShowData(FOE);
                                Console.WriteLine("The Air Craft is moving from " + FOE.Departure + " to " + FOE.Destination);
                                Counter++;

                            }
                        }
                        else
                        {
                            Console.WriteLine("We Did not implement any F.O.E air crafts in the simulation");

                        }
                        Console.WriteLine("Unkown AirCrafts Data Demo");
                        Console.WriteLine("......\n......\n......");
                        Counter = 1;
                        if (unkownAirCrafts.Count != 0)
                        {
                            Console.WriteLine("Unkown AirCrafts Data Demo");
                            Console.WriteLine("Friend Unkown Crafts repeated: " + numberOfUnkownAirCrafts);
                            foreach (var UNK in friendAirCrafts)
                            {
                                Console.WriteLine("Unkown AirCraft Number " + Counter + " Data");
                                aircraftManager.ShowData(UNK);

                                Counter++;

                            }
                            Console.WriteLine("Departure And Destination Countries are Unkown for the Unkown AirCrafts ");
                        }
                        else
                        {
                            Console.WriteLine("We Did not implement any unkown air crafts in the simulation");

                        }
                        Console.WriteLine("......\n......\n......");
                        Console.WriteLine("Passed Enemy AirCrafts Demo");

                        Counter = 1;
                        if (passedAirCrafts.Count != 0)
                        {
                            Console.WriteLine("Number Of Passed Enemy AirCrafts: " + passedAirCrafts.Count + " AirCraft");
                            foreach (var passed in passedAirCrafts)
                            {
                                Console.WriteLine("The Data Of The " + Counter + " passed Enemy Air Crafts");
                                aircraftManager.ShowData(passed);
                            }
                        }
                        else
                        {
                            Console.WriteLine("There is no any AirCraft that was passed");
                        }
                        Console.WriteLine("Destroyed Enemy AirCrafts Demo");
                        Counter = 1;
                        if (destroyedAirCrafts.Count != 0)
                        {
                            Console.WriteLine("Number Of Destroyed AirCrafts: " + destroyedAirCrafts.Count + " AirCraft");
                            foreach (var destroyed in destroyedAirCrafts)
                            {
                                Console.WriteLine("The Data Of The " + Counter + " destroyed Enemy Air Crafts");
                                aircraftManager.ShowData(destroyed);
                            }
                        }
                        else
                        {
                            Console.WriteLine("There is no any AirCraft that was destroyed");
                        }


                        Console.WriteLine("......\n......\n......\n......\n......\n.....\n");
                        Console.WriteLine("Bye Bye :)");
                        return;

                }
            }
        }
    }
}
