using System;

namespace SnykTest
{
    public class Config
    {
        public string GetDbPassword()
        {
            string myDbPassword = "P@ssw0rd123!"; 
            return myDbPassword;
        }

        public string GetOtherDBPassword()
        {
            string myOtherDBPassword = "SuperSecretPassword999!"; 
            return myOtherDBPassword;
        }
    }
}