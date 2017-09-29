using System;
using System.Collections.Generic;
using System.Text;
using SDMBLL.InterfaceServices;
using SDMDAL;
using SDMDAL.InterfaceRepositories;
using SDMEntity.BE;

namespace SDMBLL.Services
{
    class SupervisorRequestService : ISupervisorRequestService
    {
        private ISupervisorRequestRepository repo = new DALFacade().SupervisorRequestRepository;
        public SupervisorRequest Create(SupervisorRequest supervisorRequest)
        {
            throw new NotImplementedException();
        }

        public List<SupervisorRequest> GetAll()
        {
            throw new NotImplementedException();
        }

        public SupervisorRequest GetBySupervisorAndGroupId(int sId, int gId)
        {
            throw new NotImplementedException();
        }

        public SupervisorRequest Update(SupervisorRequest supervisorRequest)
        {
            throw new NotImplementedException();
        }

        public SupervisorRequest DeleteBySupervisorAndGroupId(int sId, int gId)
        {
            throw new NotImplementedException();
        }
        
    }
}
