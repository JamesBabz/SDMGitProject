using System;
using System.Collections.Generic;
using System.Text;

namespace SDMDAL.InterfaceRepositories
{
    using SDMEntity.BE;

    public interface IProjectRepository
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
