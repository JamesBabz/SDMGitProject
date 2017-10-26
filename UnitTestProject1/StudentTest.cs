using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDMBLL.InterfaceServices;
using SDMBLL.Services;
using SDMDAL.InterfaceRepositories;
using SDMEntity.BE;

namespace UnitTestProject1
{
    [TestClass]
    public class StudentTest
    {

        [TestMethod]
        public void TestCreateStudent()
        {
        var serv = new StudentService();
            var student = new Student()
            {
                Name = "Student Studson",
                Address = "StudentRoad",
                Email = "stu@dent.dk",
                Id = 1,
                Phone = 12345678
            };

            var newStud = serv.Create(student);

            Assert.AreEqual(newStud.Name, "Student Studsons");
        }


        [TestMethod]
        public void TestGetAllStudents()
        {
            var serv = new StudentService();
            var student = new Student()
            {
                Name = "Student Studson",
                Address = "StudentRoad",
                Email = "stu@dent.dk",
                Phone = 12345678
            };
            serv.Create(student);
            List<Student> allStudents = serv.GetAll();


            Assert.AreEqual(1, allStudents.Count);

        }

        [TestMethod]
        public void TestGetStudentById()
        {
            var serv = new StudentService();
            var student = new Student()
            {
                Name = "Student Studson",
                Address = "StudentRoad",
                Email = "stu@dent.dk",
                Phone = 12345678
            };
            var student2 = new Student()
            {
                Name = "Student Studson2",
                Address = "StudentRoad2",
                Email = "stu@dent.dk2",
                Phone = 12345678
            };
            serv.Create(student);
            serv.Create(student2);
            var stud = serv.GetById(2);

            Assert.AreEqual("Student Studson2", stud.Name);
        }

        [TestMethod]
        public void TestDeleteStudent()
        {
            var serv = new StudentService();
            var student = new Student()
            {
                Name = "Student Studson",
                Address = "StudentRoad",
                Email = "stu@dent.dk",
                Phone = 12345678
            };
            var student2 = new Student()
            {
                Name = "Student Studson2",
                Address = "StudentRoad2",
                Email = "stu@dent.dk2",
                Phone = 12345678
            };
            serv.Create(student);
            serv.Create(student2);
            serv.Delete(1);
            var allStudents = serv.GetAll();
            int count = allStudents.Count;
            Assert.AreEqual(1, count);
            Assert.IsFalse(allStudents.Exists(x => x.Name == student.Name));
            Assert.IsTrue(allStudents.Exists(x => x.Name == student2.Name));
        }
    }
}
