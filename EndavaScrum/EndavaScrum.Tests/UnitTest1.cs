using Microsoft.VisualStudio.TestTools.UnitTesting;
using EndavaScrum.Models;
using EndavaScrum.Controllers;

namespace EndavaScrum.Tests
{
    [TestClass]
    public class SessionControllerTestClass
    {
        [TestMethod]
        public void GetAllSessions_ShouldReturnAllSessions()
        {
            var context = new TestEndavaScrumContext();
            context.Sessions.Add(new Session { session_id = "asdfghjklz", is_changed = false, Users = { } });
            context.Sessions.Add(new Session { session_id = "qwertyuiop", is_changed = false, Users = { } });
            context.Sessions.Add(new Session { session_id = "zxcvbnmasd", is_changed = true, Users = { } });

            var controller = new SessionsController(context);
            var result = controller.GetSessions() as TestSessionDbSet;

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Local.Count);
        }
    }
}
