using System;
using System.Collections.Generic;
using System.Text;
using SDMBLL.InterfaceServices;
using SDMDAL;
using SDMDAL.InterfaceRepositories;
using SDMEntity.BE;

namespace SDMBLL.Services
{
    public class ProjectRequestService : IProjectRequestService
    {

        private IProjectRequest repo = new DALFacade().ProjectRequest;

        public ProjectRequest Create(ProjectRequest projectRequest)
        {
           return repo.Create(projectRequest);
        }

        public ProjectRequest Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProjectRequest> GetAll()
        {
            return repo.GetAll();
        }

        public ProjectRequest Get(int pId, int gId)
        {
            throw new NotImplementedException();
        }

        public ProjectRequest Update(ProjectRequest projectRequest)
        {
            throw new NotImplementedException();
        }
    }
}
