using System;

namespace SnykTest.SomethingElse
{
    public class DatabaseSomethingElse
    {
        public void Connect()
        {
            // Ignored because it's a mock test password
            string password = "MockPassword123456"; 
            Console.WriteLine(password);
        }
    }
}