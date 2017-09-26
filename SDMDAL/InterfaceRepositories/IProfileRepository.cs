using System;
using System.Collections.Generic;
using System.Text;

namespace SDMDAL.InterfaceRepositories
{
    using SDMEntity.BE;

    public interface IProfileRepository
    {
        //C
        CompanyProfile Create(CompanyProfile profile);

        //R
        List<CompanyProfile> GetAll();

        CompanyProfile Get(int id);

        //U
        CompanyProfile Update(CompanyProfile profile);

        //D
        CompanyProfile Delete(int id);
    }
}
