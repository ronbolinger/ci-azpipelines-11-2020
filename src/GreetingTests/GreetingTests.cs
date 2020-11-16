using Greeting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GreetingTests
{
    [TestClass]
    public class GreetingTests
    {
        [TestMethod]
        public void GreetingTest_MessageContent()
        {
            Greeting.Greeting myGreeting = new Greeting.Greeting();
            //myGreeting.Message = "Not a greeting message";

            string expectedMessage = "Hello World!";
            
            Assert.AreEqual(expectedMessage, myGreeting.Message);
        }
    }
}
