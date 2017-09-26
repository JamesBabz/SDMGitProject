using System.Collections.Generic;
using SDMEntity.BE;

namespace SDMDAL.InterfaceRepositories
{
    public interface ISupervisorRepository
    {
        //C
        Supervisor Create(Supervisor supervisor);

        //R
        List<Supervisor> GetAll();
        Supervisor GetById(int id);

        //D
        Supervisor Delete(int id);
    }
}