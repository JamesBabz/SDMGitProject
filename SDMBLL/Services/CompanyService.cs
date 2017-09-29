using System;
using System.Collections.Generic;
using System.Text;

namespace SDMBLL.Services
{
    using SDMBLL.InterfaceServices;

    using SDMDAL;
    using SDMDAL.InterfaceRepositories;

    using SDMEntity.BE;

    public class CompanyService : ICompanyService
    {
        private ICompanyRepository repo = new DALFacade().CompanyRepository;

        public Company Create(Company company)
        {
            return this.repo.Create(company);
        }

        public List<Company> GetAll()
        {
            return this.repo.GetAll();
        }

        public Company Get(int cvr)
        {
            return this.repo.Get(cvr);
        }

        public Company Update(Company company)
        {
            throw new NotImplementedException();
        }

        public Company Delete(int cvr)
        {
           return this.repo.Delete(cvr);
        }
    }
}
