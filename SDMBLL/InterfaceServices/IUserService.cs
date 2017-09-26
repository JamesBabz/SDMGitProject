using SDMEntity.BE;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDMBLL.InterfaceServices
{
    public interface IUserService
    {
        //C
        User Create(User);

        //R
        List<User> Getall();

        User Get(int Id);
        //U
        User Update(User);

        //D
        User Delete(int Id);
    }
}

