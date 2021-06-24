using System;
using System.Collections.Generic;
using System.IO;

namespace SE307_Project
{
    public class Radar
    {
        private double highRiskRadius, lowRiskRadius;
        private bool isThereRisk;
        private string file = @"E:\SE307\AirRadarSystem\SE307-Project\SE307-Project\radarLog.txt";

        public Radar(double highRiskRadius, double lowRiskRadius)
        {
            this.highRiskRadius = highRiskRadius;
            this.lowRiskRadius = lowRiskRadius;
        }

        public void saveIntoLogs(AirCraft airCraft)
        {
            if (logsChecker() == true)
            {
                using (StreamWriter streamWriter = File.CreateText(file))
                {
                    streamWriter.WriteLine(airCraft.ToString());
                }
                return;
            }
            else
            {
                Console.WriteLine("This File does not exist please create one");
            }
            
           
        }

        public void ReadLogs()
        {
            if (logsChecker() == true)
            {
                using (StreamReader streamReader = File.OpenText(file))
                {
                    string s = "";
                    while ((s = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            else
            {
                Console.WriteLine("This File does not exist please create one");
            }
        }

        public void createNewLog()
        {
            if(logsChecker()==false)
            File.CreateText(file);
            else
            Console.WriteLine("This File is already exist");
            }

        public bool logsChecker()
        {
            if (File.Exists(file))
            {
                return true;
            }

            return false;
        }

        public void deleteLog()
        {
            if(File.Exists(file))
                File.Delete(file);
            else
            Console.WriteLine("This File does not exist to be deleted");
            }

        public bool isEnemyChecker(AirCraft airCraft, List<Country> alliesCountries)
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
        
        

        public Radar()
        {
        }
    }
}