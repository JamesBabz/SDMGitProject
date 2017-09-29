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
                ID = Id++,
                Priority = newProjectRequest.Priority,
                IsAccepted = newProjectRequest.IsAccepted
            });
            return newProjectRequest;
        }

        public ProjectRequest Delete(int ProjectRequestID)
        {
            var projectFound = Get(ProjectRequestID);
            projectRequests.Remove(projectFound);
            return projectFound;
        }

        public ProjectRequest Get(int projectRequestID)
        {
            return projectRequests.FirstOrDefault(x => x.ID == projectRequestID);
        }

        public List<ProjectRequest> GetAll()
        {
            return new List<ProjectRequest>(projectRequests);
        }
    }
}
