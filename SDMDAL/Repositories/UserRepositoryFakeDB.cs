using SDMDAL.InterfaceRepositories;
using SDMEntity.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDMDAL.Repositories
{
    class UserRepositoryFakeDB : IUserRepository
    {
        private static List<User> Users = new List<User>();


        public User Create(User usr)
        {
            User newUsr;
            Users.Add(newUsr = new User()
            {
                PersonId = usr.PersonId,
                Username = usr.Username,
                Password = usr.Password,
                Level = usr.Level
            });
            return newUsr;
        }

        public User Delete(int Id)
        {
            var usr = Get(Id);
            Users.Remove(usr);
            return usr;
        }

        public User Get(int Id)
        {
            return Users.FirstOrDefault(x => x.PersonId == Id);
        }

        public List<User> Getall()
        {
            return new List<User>(Users);
        }

        public User Update(User usr)
        {
            throw new NotImplementedException();
        }
    }
}
}
