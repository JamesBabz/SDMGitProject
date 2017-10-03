using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDMBLL.Services;
using SDMEntity.BE;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestStudentGroup
    {
        [TestMethod]
        public void UnitTestCreateStudentGroup()
        {
            var serv = new StudentGroupService();
            var stg = new StudentGroup()
            {
                StudentGroupID = 1,
                Name = "Bo",

            };

            var newStudentGroup = serv.Create(stg);

            Assert.AreEqual(stg.Name, "Bo");
        }

        [TestMethod]
        public void TestGetAllStudentGroups()
        {
            var serv = new StudentGroupService();
            var stg = new StudentGroup()
            {
                StudentGroupID = 1,
                Name = "Test1",
            }; var stg2 = new StudentGroup()
            {
                StudentGroupID = 2,
                Name = "Test2",
            };

            var newStg = serv.Create(stg);
            var newStg2 = serv.Create(stg2);

            Assert.AreEqual(serv.GetAll().Count, 2);
        }

        [TestMethod]
        public void TestStudentGroupGetByID()
        {
            var serv = new StudentGroupService();
            var stg = new StudentGroup()
            {
                StudentGroupID = 1,
                Name = "C#",
            };
            var stg2 = new StudentGroup()
            {
                StudentGroupID = 2,
                Name = "C++",
            };

            var newStg = serv.Create(stg);
            var newStg2 = serv.Create(stg2);

            var group = serv.GetById(2);



            Assert.AreEqual("C++", group.Name);
        }

        [TestMethod]
        public void TestDeleteStudentGroup()
        {

            var serv = new StudentGroupService();
            var stg = new StudentGroup()
            {
                StudentGroupID = 1,
                Name = "C#",
            }; var stg2 = new StudentGroup()

            {
                StudentGroupID = 2,
                Name = "C#",
            };

            serv.Create(stg);
            serv.Create(stg2);

            serv.Delete(2);


            Assert.AreEqual(1, serv.GetAll().Count);

        }

    }
}
