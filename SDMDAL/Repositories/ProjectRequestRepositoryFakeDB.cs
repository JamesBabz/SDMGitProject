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
        private static int Id = 1;
        private static List<ProjectRequest> projectRequests = new List<ProjectRequest>();
        
        public ProjectRequest Create(ProjectRequest projectRequest)
        {
            ProjectRequest newProjectRequest = null;
            projectRequests.Add(newProjectRequest = new ProjectRequest()
            {
                Priority = newProjectRequest.Priority,
                IsAccepted = newProjectRequest.IsAccepted
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
