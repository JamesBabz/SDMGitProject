using System;
using System.Collections.Generic;
using System.Text;

namespace SDMDAL.InterfaceRepositories
{
    using SDMEntity.BE;

    public interface ICompanyRepository
    {
        //C
        Company Create(Company company);

        //R
        List<Company> GetAll();

        Company Get(int id);

        //U
        Company Update(Company company);

        //D
        Company Delete(int id);
    }
}
