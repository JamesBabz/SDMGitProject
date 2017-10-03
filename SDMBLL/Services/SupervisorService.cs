using System;
using System.Collections.Generic;
using System.Text;
using SDMBLL.InterfaceServices;
using SDMDAL;
using SDMDAL.InterfaceRepositories;
using SDMEntity.BE;

namespace SDMBLL.Services
{
    public class SupervisorService : ISupervisorService
    {
        private ISupervisorRepository repo = new DALFacade().SupervisorRepository;
        public Supervisor Create(Supervisor supervisor)
        {
            return repo.Create(supervisor);
        }

        public List<Supervisor> GetAll()
        {
            return repo.GetAll();
        }

        public Supervisor GetById(int id)
        {
            return repo.GetById(id);
        }

        public Supervisor Update(Supervisor supervisor)
        {
            throw new NotImplementedException();
        }

        public Supervisor Delete(int id)
        {
            return repo.Delete(id);
        }

        public bool GetAvailability(int id)
        {
            return repo.GetAvailability(id);
        }
    }
}
