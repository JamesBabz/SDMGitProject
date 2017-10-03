using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDMBLL.Services;
using SDMEntity.BE;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var serv = new AdminService();
            var adm = new Admin()
            {
                Address = "testvej",
                Email = "testMail",
                Name = "testName",
                Id = 1,
                PhoneNumber = 12345678
            };
            var newAdm = serv.Create(adm);

            Assert.AreEqual(serv.Get(1).Address, "testvej");
        }
    }
}
