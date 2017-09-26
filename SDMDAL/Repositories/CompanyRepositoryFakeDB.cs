using System;
using System.Collections.Generic;
using System.Text;

namespace SDMDAL.Repositories
{
    using System.Linq;

    using SDMDAL.InterfaceRepositories;

    using SDMEntity.BE;

    public class CompanyRepositoryFakeDB : ICompanyRepository
    {

        private static List<Company> Companies = new List<Company>();

        public Company Create(Company company)
        {
            Company newCompany;
            Companies.Add(newCompany = new Company()
                                           {
                                               Name = company.Name,
                                               Cvr = company.Cvr,
                                               Adress = company.Adress,
                                               ContactPerson = company.ContactPerson,
                                               Mail = company.Mail,
                                               Phone = company.Phone
                                              
                                           });
            return newCompany;
        }

        public List<Company> GetAll()
        {
            return new List<Company>(Companies);
        }

        public Company Get(int cvr)
        {
            return Companies.FirstOrDefault(x => x.Cvr == cvr);
        }

        public Company Delete(int cvr)
        {
            var selectedCompany = Get(cvr);
            Companies.Remove(selectedCompany);
            return selectedCompany;
        }
    }
}