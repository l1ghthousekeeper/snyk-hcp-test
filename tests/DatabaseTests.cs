using System;

namespace SnykTest.Tests
{
    public class DatabaseTests
    {
        public void Connect()
        {
            // Ignored because it's a mock test password
            string thisAlsoHasAPassword = "Server=myServer;User Id=mockUser;Password=MockPassword123;"; 
            Console.WriteLine(thisAlsoHasAPassword);
        }
    }
}