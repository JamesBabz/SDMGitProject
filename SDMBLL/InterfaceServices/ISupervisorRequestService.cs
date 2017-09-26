using System;
using System.Collections.Generic;
using System.Text;
using SDMEntity.BE;

namespace SDMBLL.InterfaceServices
{
    interface ISupervisorRequestService
    {
        //C
        SupervisorRequest Create(SupervisorRequest supervisorRequest);

        //R
        List<SupervisorRequest> GetAll();
        SupervisorRequest GetById(int id);

        //U
        SupervisorRequest Update(SupervisorRequest supervisorRequest);

        //D
        SupervisorRequest Delete(int id);
    }
}
