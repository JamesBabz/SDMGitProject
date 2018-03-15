using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDMBLL.Services;
using SDMEntity.BE;

namespace UnitTestProject1
{
    [TestClass]
    public class SupervisorTest
    {
        [TestMethod]
        public void TestCreateSupervisor()
        {
            var serv = new SupervisorService();
            var supervisor = new Supervisor()
            {
                Name = "Supervisor Studson",
                Address = "SupervisorRoad",
                Email = "stu@dent.dk",
                Phone = 12345678
            };

            var newStud = serv.Create(supervisor);

            Assert.AreEqual(newStud.Name, "Supervisor Studson");
        }


        [TestMethod]
        public void TestGetAllSupervisors()
        {
            var serv = new SupervisorService();
            var supervisor = new Supervisor()
            {
                Name = "Supervisor Studson",
                Address = "SupervisorRoad",
                Email = "stu@dent.dk",
                Phone = 12345678
            };
            serv.Create(supervisor);
            List<Supervisor> allSupervisors = serv.GetAll();


            Assert.AreEqual(1, allSupervisors.Count);

        }

        [TestMethod]
        public void TestGetSupervisorById()
        {
            var serv = new SupervisorService();
            var supervisor = new Supervisor()
            {
                Name = "Supervisor Studson",
                Address = "SupervisorRoad",
                Email = "stu@dent.dk",
                Phone = 12345678
            };
            var supervisor2 = new Supervisor()
            {
                Name = "Supervisor Studson2",
                Address = "SupervisorRoad2",
                Email = "stu@dent.dk2",
                Phone = 12345678
            };
            serv.Create(supervisor);
            serv.Create(supervisor2);
            var stud = serv.GetById(2);

            Assert.AreEqual("Supervisor Studson2", stud.Name);
        }

        [TestMethod]
        public void TestDeleteSupervisor()
        {
            var serv = new SupervisorService();
            var supervisor = new Supervisor()
            {
                Name = "Supervisor Studson",
                Address = "SupervisorRoad",
                Email = "stu@dent.dk",
                Phone = 12345678
            };
            var supervisor2 = new Supervisor()
            {
                Name = "Supervisor Studson2",
                Address = "SupervisorRoad2",
                Email = "stu@dent.dk2",
                Phone = 12345678
            };
            serv.Create(supervisor);
            serv.Create(supervisor2);
            serv.Delete(1);
            var allSupervisors = serv.GetAll();
            int count = allSupervisors.Count;
            Assert.AreEqual(1, count);
            Assert.IsFalse(allSupervisors.Exists(x => x.Name == supervisor.Name));
            Assert.IsTrue(allSupervisors.Exists(x => x.Name == supervisor2.Name));
        }

        [TestMethod]
        public void TestSupervisorAvailability()
        {
            var serv = new SupervisorService();
            var supervisor = new Supervisor()
            {
                Name = "Supervisor Studson",
                Address = "SupervisorRoad",
                Email = "stu@dent.dk",
                Phone = 12345678
            };
            supervisor.IsAvailable = true;

            Assert.IsTrue(supervisor.IsAvailable);
        }
}
}
