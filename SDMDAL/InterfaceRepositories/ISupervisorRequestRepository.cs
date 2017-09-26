using System.Collections.Generic;
using SDMEntity.BE;

namespace SDMDAL.InterfaceRepositories
{
    public interface ISupervisorRequestRepository
    {
        //C
        SupervisorRequest Create(SupervisorRequest supervisorRequest);

        //R
        List<SupervisorRequest> GetAll();
        SupervisorRequest GetBySupervisorAndGroupId(int sId, int gId);

        //D
        SupervisorRequest DeleteBySupervisorAndGroupId(int sId, int gId);
    }
}