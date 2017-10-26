using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDMBLL.Services;
using SDMEntity.BE;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestCategory
    {
        [TestMethod]
        public void TestGetAllCategories()
        {
            var serv = new CategoryService();



            var cat = new Category()
            {
                ID = 1,
                Name = "C#",
            }; var cat2 = new Category()
            {
                ID = 2,
                Name = "C#",
            };

            var newCat = serv.Create(cat);
            var newCat2 = serv.Create(cat2);

            Assert.AreEqual(serv.GetAll().Count, 2);
        }


        [TestMethod]
        public void TestCreateCategory()
        {
            var serv = new CategoryService();
            var cat = new Category()
            {
                ID = 1,
                Name = "C#",
            };

            var newCat = serv.Create(cat);

            Assert.AreEqual(serv.GetById(1).Name, "C#");
        }

        [TestMethod]
        public void TestCategoryGetByID()
        {
            var serv = new CategoryService();
            var cat = new Category()
            {
                ID = 1,
                Name = "C#",
            };
            var cat2 = new Category()
            {
                ID = 2,
                Name = "C++",
            };

            var newCat = serv.Create(cat);
            var newCat2 = serv.Create(cat2);

            var category = serv.GetById(2);

            

            Assert.AreEqual("C++", category.Name);
        }

        [TestMethod]
        public void TestDeleteCategories()
        {

            var serv = new CategoryService();
            var cat = new Category()
            {
                ID = 1,
                Name = "C#",
            }; var cat2 = new Category()

            {
                ID = 2,
                Name = "C#",
            };

            serv.Delete(2);

            Assert.AreEqual(null, serv.GetById(2));

        }



    }
}
