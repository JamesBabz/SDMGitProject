using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SDMDAL.InterfaceRepositories;
using SDMEntity.BE;

namespace SDMDAL.Repositories
{
    class SupervisorRequestRepositoryFakeDB : ISupervisorRequestRepository
    {
        private readonly List<SupervisorRequest> SupervisorRequests = new List<SupervisorRequest>();

        public SupervisorRequest Create(SupervisorRequest supervisorRequest)
        {
            SupervisorRequest newSupervisorRequest = new SupervisorRequest()
            {
                AdminId = supervisorRequest.AdminId,
                GroupId = supervisorRequest.GroupId,
                SupervisorId = supervisorRequest.SupervisorId,
                IsAccepted = false
            };
            return newSupervisorRequest;
        }

        public List<SupervisorRequest> GetAll()
        {
            return new List<SupervisorRequest>(SupervisorRequests);
        }

        public SupervisorRequest GetBySupervisorAndGroupId(int sId, int gId)
        {
            return SupervisorRequests.FirstOrDefault(x => x.SupervisorId == sId && x.GroupId == gId);
        }

        public SupervisorRequest DeleteBySupervisorAndGroupId(int sId, int gId)
        {
            SupervisorRequest foundSupervisorRequest = GetBySupervisorAndGroupId(sId, gId);
            SupervisorRequests.Remove(foundSupervisorRequest);
            return foundSupervisorRequest;
        }
    }
}
