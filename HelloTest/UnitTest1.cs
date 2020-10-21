using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloTest
{
    [TestClass]
    public class UnitTest1
    {
        private string Expected = "Hello World";
        [TestMethod]
        public void PlainText()
        {
            MessageManager.Manager he = new MessageManager.Manager();
            string response = he.DefaultMessage;
            Assert.AreEqual(Expected, response);

        }
        //Future
        public void DatabaseConnect()
        {
            //initialize connectivity and test
        }
        public void AddItem()
        {
            //add a message item and retreive responses:
        }
        public void RetreiveItem()
        {
            //get back an item:

        }
    }
}
