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

        Company Get(int cvr);

        //U

        //D
        Company Delete(int cvr);
    }
}
