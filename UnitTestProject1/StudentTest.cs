using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDMBLL.InterfaceServices;
using SDMBLL.Services;
using SDMEntity.BE;

namespace UnitTestProject1
{
    [TestClass]
    public class StudentTest
    {
            IStudentService serv = new StudentService();
        [TestMethod]
        public void TestCreate()
        {
            var student = new Student()
            {
                Name = "Student Studson",
                Address = "StudentRoad",
                Email = "stu@dent.dk",
                Id = 1,
                Phone = 12345678
            };

            var newStud = serv.Create(student);

            Assert.AreEqual(newStud.Name, "Student Studson");
        }


        [TestMethod]
        public void TestGetAll()
        {
            var student = new Student()
            {
                Name = "Student Studson",
                Address = "StudentRoad",
                Email = "stu@dent.dk",
                Id = 1,
                Phone = 12345678
            };
            serv.Create(student);

            List<Student> allStudents = serv.GetAll();

            Assert.IsNotNull(allStudents);

        }

        [TestMethod]
        public void TestGetById()
        {
        }

        [TestMethod]
        public void TestDelete()
        {
        }
    }
