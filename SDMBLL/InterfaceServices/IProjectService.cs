using System;
using System.Collections.Generic;
using System.Text;

namespace SDMBLL.InterfaceServices
{
    using SDMEntity.BE;

    public interface IProjectService
    {
        //C
        Project Create(Project project);

        //R
        List<Project> GetAll();

        Project Get(int id);

        //U
        Project Update(Project project);

        //D
        Project Delete(int id);
    }
}
