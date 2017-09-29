using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using SDMBLL.Services;

    using SDMEntity.BE;

    [TestClass]
    public class UnitTestCompany
    {
        [TestMethod]
        public void TestCreateCompany()
        {
            CompanyService service = new CompanyService();

            Company company = new Company()
                                  {
                                      Name = "Company",
                                      Adress = "Adress22",
                                      ContactPerson = "Captain jack",
                                      Cvr = 12345678,
                                      Mail = "This@mail.com",
                                      Phone = 12345678
                                  };
           service.Create(company);
            Assert.AreEqual(company.Name, "Company");
        }

        [TestMethod]
        public void TestGetAllCompanies()
        {
            CompanyService service = new CompanyService();
            Company company = new Company()
                                  {
                                      Name = "Company",
                                      Adress = "Adress22",
                                      ContactPerson = "Captain jack",
                                      Cvr = 12345678,
                                      Mail = "This@mail.com",
                                      Phone = 12345678
                                  };
            service.Create(company);
            
            List<Company> companies = service.GetAll();
            Assert.AreEqual(service.GetAll().Count, 1);
        }

        [TestMethod]
        public void TestGetCompanyByCvr()
        {
            CompanyService service = new CompanyService();
            Company company = new Company()
                                  {
                                      Name = "Company",
                                      Adress = "Adress22",
                                      ContactPerson = "Captain jack",
                                      Cvr = 23456789,
                                      Mail = "This@mail.com",
                                      Phone = 12345678
                                  };
            service.Create(company);
            Company company2 = new Company()
                                  {
                                      Name = "Company2",
                                      Adress = "Adress22",
                                      ContactPerson = "Captain jack",
                                      Cvr = 12345678,
                                      Mail = "This@mail.com",
                                      Phone = 12345678
                                  };
            service.Create(company2);

            Assert.AreEqual(service.Get(company2.Cvr).Name, "Company2" );
        }

        [TestMethod]
        public void TestDeleteCompany()
        {
            CompanyService service = new CompanyService();
            Company company = new Company()
                                  {
                                      Name = "Company",
                                      Adress = "Adress22",
                                      ContactPerson = "Captain jack",
                                      Cvr = 23456789,
                                      Mail = "This@mail.com",
                                      Phone = 12345678
                                  };
            service.Create(company);
            Company company2 = new Company()
                                   {
                                       Name = "Company2",
                                       Adress = "Adress22",
                                       ContactPerson = "Captain jack",
                                       Cvr = 12345678,
                                       Mail = "This@mail.com",
                                       Phone = 12345678
                                   };
            service.Create(company2);

            service.Delete(company2.Cvr);
            Assert.IsFalse(service.GetAll().Exists(x=>x.Name == company2.Name));
            Assert.AreEqual(service.GetAll().Count, 1);
           
        }
    }
}