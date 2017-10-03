using System;
using System.Collections.Generic;
using System.Text;

namespace SDMBLL.Services
{
    using SDMBLL.InterfaceServices;

    using SDMDAL;
    using SDMDAL.InterfaceRepositories;

    using SDMEntity.BE;

    public class ProjectService : IProjectService
    {
        private IProjectRepository repo = new DALFacade().ProjectRepository;

        public Project Create(Project project)
        {
            return this.repo.Create(project);
        }

        public List<Project> GetAll()
        {
            return this.repo.GetAll();
        }

        public Project Get(int id)
        {
            return this.repo.Get(id);
        }

        public Project Update(Project project)
        {
            throw new NotImplementedException();
        }

        public Project Delete(int id)
        {
            return this.repo.Delete(id);
        }
    }
}
