using System;
using System.Collections.Generic;
using System.Text;
using SDMBLL.InterfaceServices;
using SDMDAL;
using SDMDAL.InterfaceRepositories;
using SDMEntity.BE;

namespace SDMBLL.Services
{
    class SupervisorService : ISupervisorService
    {
        private ISupervisorRepository repo = new DALFacade().SupervisorRepository;
        public Supervisor Create(Supervisor supervisor)
        {
            throw new NotImplementedException();
        }

        public List<Supervisor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Supervisor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Supervisor Update(Supervisor supervisor)
        {
            throw new NotImplementedException();
        }

        public Supervisor Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
