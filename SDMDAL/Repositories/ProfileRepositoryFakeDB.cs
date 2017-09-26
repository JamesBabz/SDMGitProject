using System;
using System.Collections.Generic;
using System.Text;

namespace SDMDAL.Repositories
{
    using System.Linq;

    using SDMDAL.InterfaceRepositories;

    using SDMEntity.BE;

    public class ProfileRepositoryFakeDB : IProfileRepository
    {
        private static List<CompanyProfile> CompanyProfiles = new List<CompanyProfile>();

        public CompanyProfile Create(CompanyProfile profile)
        {
            CompanyProfile newProfile;
            CompanyProfiles.Add(newProfile = new CompanyProfile()
                                                 {
                                                     CompanyCvr = profile.CompanyCvr,
                                                     ProfileText = profile.ProfileText
                                                 });
            return newProfile;
        }


        public List<CompanyProfile> GetAll()
        {
            return new List<CompanyProfile>(CompanyProfiles);
        }

        public CompanyProfile Get(int companyCvr)
        {
            return CompanyProfiles.FirstOrDefault(x => x.CompanyCvr == companyCvr);
        }

 

        public CompanyProfile Delete(int companyCvr)
        {
            var selectedProfile = Get(companyCvr);
            CompanyProfiles.Remove(selectedProfile);
            return selectedProfile;
        }
    }
}
