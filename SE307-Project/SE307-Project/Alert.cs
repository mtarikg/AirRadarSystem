using System;
using System.Collections.Generic;

namespace SE307_Project
{
    public class Alert
    {
        public Alert()
        {
        }

        public string LowRiskMessaage()
        {
            return ("strange Aircraft entered out borders");
        }

        public string HighRiskMessage()
        {
            return "There is a chance to get attacked by the AirCraft please evacuate the area";
        }

    }
}