using System;
using System.Collections.Generic;
using System.Text;

namespace SDMDAL.Repositories
{
    using SDMDAL.InterfaceRepositories;

    using SDMEntity.BE;

    public class ProjectRepositoryFakeDB : IProjectRepository
    {
        public Project Create(Project project)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetAll()
        {
            throw new NotImplementedException();
        }

        public Project Get(int id)
        {
            throw new NotImplementedException();
        }

        public Project Update(Project project)
        {
            throw new NotImplementedException();
        }

        public Project Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
