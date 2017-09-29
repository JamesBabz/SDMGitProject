using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDMBLL.Services;
using SDMEntity.BE;

namespace UnitTestProject1
{
    [TestClass]
    class UnitTestCategory
    {


        [TestMethod]
        public void TestMethodCreate()
        {
            var serv = new CategoryService();
            var cat = new Category()
            {
                ID = 1,
                Name = "C#",
            };

            var newCat = serv.Create(cat);

            Assert.AreEqual(cat.Name, "C#");
        }


    }
}
