using System;
using System.Collections.Generic;
using System.Text;

namespace SDMBLL.InterfaceServices
{
    using SDMEntity.BE;

    public interface ICompanyService
    {
        //C
        Company Create(Company company);

        //R
        List<Company> GetAll();

        Company Get(int cvr);

        //U
        Company Update(Company company);

        //D
        Company Delete(int cvr);
    }
}
