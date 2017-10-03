using System;
using System.Collections.Generic;
using System.Text;

namespace SDMBLL.Services
{
    using SDMBLL.InterfaceServices;

    using SDMDAL;
    using SDMDAL.InterfaceRepositories;

    using SDMEntity.BE;

    public class ProfileService : IProfileService
    {
        private IProfileRepository repo = new DALFacade().ProfileRepository;

        public CompanyProfile Create(CompanyProfile profile)
        {
            return this.repo.Create(profile);
        }

        public List<CompanyProfile> GetAll()
        {
            return this.repo.GetAll();
        }

        public CompanyProfile Get(int companyCvr)
        {
            return this.repo.Get(companyCvr);
        }

        public CompanyProfile Update(CompanyProfile profile)
        {
            throw new NotImplementedException();
        }

        public CompanyProfile Delete(int companyCvr)
        {
            return this.repo.Delete(companyCvr);
        }
    }
}
