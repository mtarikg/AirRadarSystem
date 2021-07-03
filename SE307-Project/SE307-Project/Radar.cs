using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SE307_Project
{
    public class Radar
    {
        private double highRiskRadius, lowRiskRadius;
        private bool isThereRisk;
        private string file = @"E:\radarLog.txt";
        List<string> lines = new List<string>();

        public Radar()
        {
        }

        public double HighRiskRadius
        {
            get => highRiskRadius;
            set => highRiskRadius = value;
        }

        public double LowRiskRadius
        {
            get => lowRiskRadius;
            set => lowRiskRadius = value;
        }

        public Radar(double highRiskRadius, double lowRiskRadius)
        {
            this.highRiskRadius = highRiskRadius;
            this.lowRiskRadius = lowRiskRadius;
        }

        public void SaveIntoLogs(AirCraft airCraft)
        {
            if (LogsChecker() == true)
            {
                AircraftManager aircraftManager = new AircraftManager();
                lines.Add(aircraftManager.ShowData(airCraft));
                File.WriteAllLines(file, lines);
            }
            else
            {
                CreateNewLog();
                SaveIntoLogs(airCraft);
            }
        }

        public void ReadLogs()
        {
            LogsChecker();
            if (LogsChecker() == true)
            {
                lines = File.ReadAllLines(file).ToList();
                foreach (var VARIABLE in lines)
                {
                    Console.WriteLine(VARIABLE);
                }
            }
            else
            {
                Console.WriteLine("This File does not exist please create one");
            }
        }

        public void CreateNewLog()
        {
            if (LogsChecker() == false)
            {
                using (FileStream fs = File.Create(file))
                {
                    ;
                }
            }

            else
                Console.WriteLine("This File is already exist");
        }

        public bool LogsChecker()
        {
            if (File.Exists(file))
            {
                return true;
            }

            return false;
        }

        public void DeleteLog()
        {
            if (File.Exists(file))
                File.Delete(file);
            else
                Console.WriteLine("This File does not exist to be deleted");
        }

        public bool IsEnemyChecker(AirCraft airCraft, List<string> alliesCountries)
        {
            if (alliesCountries.Contains(airCraft.Departure))
            {
                Console.WriteLine("This AirCraft Belongs to an ally so it is passed");
                isThereRisk = false;
                return false;
            }
            Console.WriteLine("This AirCraft belongs to an enemy ");
            isThereRisk = true;
            return true;
        }
    }
}