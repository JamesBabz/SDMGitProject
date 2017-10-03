using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1
{
    using System.Reflection.PortableExecutable;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using SDMBLL.Services;

    using SDMEntity.BE;

    [TestClass]
   public class UnitTestProject
    {
        [TestMethod]
        public void TestCreateProjeckt()
        {
            ProjectService service = new ProjectService();
            Project project = new Project()
                                  {
                                      Name = "Project",
                                      CompanyCvr = 12345678,
                                      CreationDate = DateTime.Today,
                                      ProjectDescription = "This is a project"
                                  };
            service.Create(project);
            Assert.AreEqual(project.Name, "Project");
        }

        [TestMethod]
        public void TestGetAllProjects()
        {
            ProjectService service = new ProjectService();
            Project project = new Project()
                                  {
                                      Name = "Project",
                                      CompanyCvr = 12345678,
                                      CreationDate = DateTime.Today,
                                      ProjectDescription = "This is a project"
                                  };
            service.Create(project);
            Project project2 = new Project()
                                  {
                                      Name = "Project2",
                                      CompanyCvr = 23456789,
                                      CreationDate = DateTime.Today,
                                      ProjectDescription = "This is a project"
                                  };
            service.Create(project2);

            Assert.AreEqual(service.GetAll().Count, 2);

        }

        [TestMethod]
        public void TestGetProjectById()
        {
            ProjectService service = new ProjectService();
            Project project = new Project()
                                  {
                                      Name = "Project",
                                      CompanyCvr = 12345678,
                                      CreationDate = DateTime.Today,
                                      ProjectDescription = "This is a project"
                                  };
            service.Create(project);
            Project project2 = new Project()
                                   {
                                       Name = "Project2",
                                       CompanyCvr = 23456789,
                                       CreationDate = DateTime.Today,
                                       ProjectDescription = "This is a project"
                                   };
            service.Create(project2);

            Assert.AreEqual(service.Get(project.Id).Name, "Project");
        }

        [TestMethod]
        public void TestDeleteProject()
        {
            ProjectService service = new ProjectService();
            Project project = new Project()
                                  {
                                      Name = "Project",
                                      CompanyCvr = 12345678,
                                      CreationDate = DateTime.Today,
                                      ProjectDescription = "This is a project"
                                  };
            service.Create(project);
            Project project2 = new Project()
                                   {
                                       Name = "Project2",
                                       CompanyCvr = 23456789,
                                       CreationDate = DateTime.Today,
                                       ProjectDescription = "This is a project"
                                   };
            service.Create(project2);
            service.Delete(project.Id);
            Assert.IsFalse(service.GetAll().Exists(x => x.Name == project.Name));
            Assert.AreEqual(service.GetAll().Count, 1);

        }


    }
}
