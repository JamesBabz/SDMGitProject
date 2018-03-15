using System;
using System.Collections.Generic;
using System.Text;
using SDMEntity.BE;

namespace SDMBLL.InterfaceServices
{
    interface ISupervisorService
    {
        //C
        Supervisor Create(Supervisor supervisor);

        //R
        List<Supervisor> GetAll();
        Supervisor GetById(int id);

        //U
        Supervisor Update(Supervisor supervisor);

        //D
        Supervisor Delete(int id);

        bool GetAvailability(int id);
    }
}
