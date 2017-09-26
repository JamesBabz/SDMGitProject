using System;
using System.Collections.Generic;
using System.Text;

namespace SDMBLL.InterfaceServices
{
    using SDMEntity.BE;

    public interface IProfileService
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
