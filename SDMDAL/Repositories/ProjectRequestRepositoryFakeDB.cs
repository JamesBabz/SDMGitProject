using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SDMDAL.InterfaceRepositories;
using SDMEntity.BE;

namespace SDMDAL.Repositories
{
    class ProjectRequestRepositoryFakeDB : IProjectRequest
    {
        private int Id = 1;
        private List<ProjectRequest> projectRequests = new List<ProjectRequest>();
        
        public ProjectRequest Create(ProjectRequest projectRequest)
        {
            ProjectRequest newProjectRequest;
            projectRequests.Add(newProjectRequest = new ProjectRequest()
            {
                Priority = projectRequest.Priority,
                IsAccepted = projectRequest.IsAccepted
            });
            return newProjectRequest;
        }

        public ProjectRequest Delete(int pId, int gId)
        {
            var projectFound = Get(pId, gId);
            projectRequests.Remove(projectFound);
            return projectFound;
        }

        public ProjectRequest Get(int pId, int gId)
        {
            return projectRequests.FirstOrDefault(x => x.ProjectID == pId && x.GroupID == gId);
        }

        public List<ProjectRequest> GetAll()
        {
            return new List<ProjectRequest>(projectRequests);
        }
    }
}
