using SDMEntity.BE;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDMBLL.InterfaceServices
{
    public interface IUserService
    {
        //C
        User Create(User usr);

        //R
        List<User> Getall();

        User Get(int Id);
        //U
        User Update(User usr);

        //D
        User Delete(int Id);
    }
}

