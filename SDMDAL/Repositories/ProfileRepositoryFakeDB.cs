using System;
using System.Collections.Generic;
using System.Text;

namespace SDMDAL.Repositories
{
    using SDMDAL.InterfaceRepositories;

    using SDMEntity.BE;

    public class ProfileRepositoryFakeDB : IProfileRepository
    {
        public CompanyProfile Create(CompanyProfile profile)
        {
            throw new NotImplementedException();
        }

        public List<CompanyProfile> GetAll()
        {
            throw new NotImplementedException();
        }

        public CompanyProfile Get(int id)
        {
            throw new NotImplementedException();
        }

        public CompanyProfile Update(CompanyProfile profile)
        {
            throw new NotImplementedException();
        }

        public CompanyProfile Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
