using System;
using System.Collections.Generic;

namespace SE307_Project
{
    public class Alert
    {
      
        public Alert()
        {
        }

        public string lowRiskMessaage()
        {
            return ("strange Aircraft entered out borders");
        }

        public string highRiskMessage()
        {
            return "There is a chance to get attacked by the AirCraft please evacuate the area";
        }
        
    }
}