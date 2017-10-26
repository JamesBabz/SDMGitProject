using SDMBLL.InterfaceServices;
using System;
using System.Collections.Generic;
using System.Text;
using SDMDAL;
using SDMDAL.InterfaceRepositories;
using SDMEntity.BE;

namespace SDMBLL.Services
{
    public class AdminService : IAdminService
    {
        kurt
        private IAdminRepository repo = new DALFacade().AdminRepository;

        public Admin Create(Admin adm)
        {
            return repo.Create(adm);
        }

        public Admin Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Admin Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Admin> Getall()
        {
            return repo.Getall();
        }

        public Admin Update(Admin adm)
        {
            throw new NotImplementedException();
        }
    }
}
