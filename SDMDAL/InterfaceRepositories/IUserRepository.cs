using SDMEntity.BE;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDMDAL.InterfaceRepositories
{
    interface IUserRepository
    {
        //C
        User Create(User us);

        //R
        List<User> Getall();

        User Get(int Id);
        //U
        User Update(User us);

        //D
        User Delete(int Id);
    }
}

