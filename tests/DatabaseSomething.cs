using System;

namespace SnykTest.Something
{
    public class DatabaseSomething
    {
        public void Connect()
        {
            // Ignored because it's a mock test password
            string password = "MockPassword123"; 
            Console.WriteLine(password);
        }
    }
}