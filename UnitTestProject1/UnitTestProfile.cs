using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using SDMBLL.Services;

    using SDMEntity.BE;

    [TestClass]
   public class UnitTestProfile
    {
        [TestMethod]
        public void TestCreateProfile()
        {
            ProfileService service = new ProfileService();
            CompanyProfile profile = new CompanyProfile()
                                         {
                                             CompanyCvr = 12345678,
                                             ProfileText = "This is the profile"
                                         };
            service.Create(profile);
            CompanyProfile profile2 = new CompanyProfile()
                                          {
                                              CompanyCvr = 23456789,
                                              ProfileText = "This is the second profile"
                                          };
            service.Create(profile2);
            
            Assert.AreEqual(profile.CompanyCvr, 12345678);

        }

        [TestMethod]
        public void TestGetAllProfiles()
        {
            ProfileService service = new ProfileService();
            CompanyProfile profile = new CompanyProfile()
                                         {
                                             CompanyCvr = 12345678,
                                             ProfileText = "This is the profile"
                                         };
            service.Create(profile);
            CompanyProfile profile2 = new CompanyProfile()
                                          {
                                              CompanyCvr = 23456789,
                                              ProfileText = "This is the second profile"
                                          };
            service.Create(profile2);

            Assert.AreEqual(service.GetAll().Count, 2);
        }

        [TestMethod]
        public void TestGetProfileByCompanyCvr()
        {
            ProfileService service = new ProfileService();
            CompanyProfile profile = new CompanyProfile()
                                         {
                                             CompanyCvr = 12345678,
                                             ProfileText = "This is the profile"
                                         };
            service.Create(profile);
            CompanyProfile profile2 = new CompanyProfile()
                                          {
                                              CompanyCvr = 23456789,
                                              ProfileText = "This is the second profile"
                                          };
            service.Create(profile2);

            Assert.AreEqual(service.Get(profile2.CompanyCvr).CompanyCvr, 23456789);
        }

        [TestMethod]
        public void TestDeleteProfile()
        {
            ProfileService service = new ProfileService();
            CompanyProfile profile = new CompanyProfile()
                                         {
                                             CompanyCvr = 12345678,
                                             ProfileText = "This is the profile"
                                         };
            service.Create(profile);
            CompanyProfile profile2 = new CompanyProfile()
                                          {
                                              CompanyCvr = 23456789,
                                              ProfileText = "This is the second profile"
                                          };
            service.Create(profile2);
            service.Delete(profile2.CompanyCvr);

            Assert.IsFalse(service.GetAll().Exists(x => x.CompanyCvr == profile2.CompanyCvr));
            Assert.AreEqual(service.GetAll().Count, 1);
        }
    }
}
