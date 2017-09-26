using SDMDAL.InterfaceRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using SDMEntity.BE;
using System.Linq;

namespace SDMDAL.Repositories
{
    class AdminRepositoryFakeDB : IAdminRepository
    {

        private static List<Admin> Admins = new List<Admin>();


        public Admin Create(Admin adm)
        {
            Admin newAdm;
            Admins.Add(newAdm = new Admin()
            {
                Id = adm.Id,
                Name = adm.Name,
                PhoneNumber = adm.PhoneNumber,
                Email = adm.Email,
                Address = adm.Address
            });
            return newAdm;
        }

        public Admin Delete(int Id)
        {
            var adm = Get(Id);
            Admins.Remove(adm);
            return adm;
        }

        public Admin Get(int Id)
        {
            return Admins.FirstOrDefault(x => x.Id == Id);
        }

        public List<Admin> Getall()
        {
            return new List<Admin>(Admins);
        }

        public Admin Update(Admin adm)
        {
            throw new NotImplementedException();
        }
    }
}
