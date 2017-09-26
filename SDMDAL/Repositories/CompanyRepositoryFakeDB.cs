using System;
using System.Collections.Generic;
using System.Text;

namespace SDMDAL.Repositories
{
    using SDMDAL.InterfaceRepositories;

    using SDMEntity.BE;

    public class CompanyRepositoryFakeDB : ICompanyRepository
    {
        public Company Create(Company company)
        {
            throw new NotImplementedException();
        }

        public List<Company> GetAll()
        {
            throw new NotImplementedException();
        }

        public Company Get(int id)
        {
            throw new NotImplementedException();
        }

        public Company Update(Company company)
        {
            throw new NotImplementedException();
        }

        public Company Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
