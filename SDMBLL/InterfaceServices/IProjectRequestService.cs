using System;
using System.Collections.Generic;
using System.Text;
using SDMEntity.BE;

namespace SDMBLL.InterfaceServices
{
    interface IProjectRequestService
    {
        //C
        ProjectRequest Create(ProjectRequest projectRequest);

        //R
        List<ProjectRequest> GetAll();
        ProjectRequest GetById(int pId, int gId);

        //U
        ProjectRequest Update(ProjectRequest projectRequest);

        //D
        ProjectRequest Delete(int id);
    }
}
