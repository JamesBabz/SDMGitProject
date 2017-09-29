using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SDMDAL.InterfaceRepositories;
using SDMEntity.BE;

namespace SDMDAL.Repositories
{
    class SupervisorRepositoryFakeDB : ISupervisorRepository
    {
        private int _id = 1;
        private readonly List<Supervisor> Supervisors = new List<Supervisor>();


        public Supervisor Create(Supervisor supervisor)
        {
            Supervisor newSupervisor;
            Supervisors.Add(newSupervisor = new Supervisor()
            {
                Id = _id++,
                Name = supervisor.Name,
                Address = supervisor.Address,
                Email = supervisor.Email,
                Phone = supervisor.Phone,
                IsAvailable = true
            });
            return newSupervisor;
        }

        public List<Supervisor> GetAll()
        {
            return new List<Supervisor>(Supervisors);
        }

        public Supervisor GetById(int id)
        {
            return Supervisors.FirstOrDefault(x => x.Id == id);
        }

        public Supervisor Delete(int id)
        {
            Supervisor foundSupervisor = GetById(id);
            Supervisors.Remove(foundSupervisor);
            return foundSupervisor;
        }

        public bool GetAvailability(int id)
        {
            Supervisor foundSupervisor = GetById(id);
            return foundSupervisor.IsAvailable;
        }
    }
}
