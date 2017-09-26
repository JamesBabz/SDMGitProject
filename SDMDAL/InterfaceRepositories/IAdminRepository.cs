using SDMEntity.BE;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDMDAL.InterfaceRepositories
{
    public interface IAdminRepository
    {
        //C
        Admin Create(Admin adm);

        //R
        List<Admin> Getall();

        Admin Get(int Id);
        //U
        Admin Update(Admin adm);

        //D
        Admin Delete(int Id);
    }
}

