using System;
using System.Collections.Generic;
using System.Text;
using SDMEntity.BE;

namespace SDMDAL.InterfaceRepositories
{
    public interface IProjectRequest
    {
        //C
        ProjectRequest Create(ProjectRequest projectRequest);

        //R
        List<ProjectRequest> GetAll();

        ProjectRequest Get(int pId, int gId);
        
        //U


        //D
        ProjectRequest Delete(int pId, int gId);

    }
}
