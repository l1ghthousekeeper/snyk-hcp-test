using System;

namespace SnykTest.Tests
{
    public class DatabaseTests
    {
        public void Connect()
        {
            // Ignored because it's a mock test password
            string connectionString = "Server=myServer;User Id=mockUser;Password=MockPassword123;"; 
            Console.WriteLine(connectionString);
        }
    }
}
