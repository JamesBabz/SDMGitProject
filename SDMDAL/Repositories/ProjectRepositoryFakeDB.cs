using System;
using System.Collections.Generic;
using System.Text;

namespace SDMDAL.Repositories
{
    using System.Linq;

    using SDMDAL.InterfaceRepositories;

    using SDMEntity.BE;

    public class ProjectRepositoryFakeDB : IProjectRepository
    {

        private  int id;
        private  List<Project> projects = new List<Project>();

        public Project Create(Project project)
        {
            Project newProject;
            projects.Add(newProject = new Project()
                                          {
                                              Id = id++,
                                              Name = project.Name,
                                              CompanyCvr = project.CompanyCvr,
                                              CreationDate = project.CreationDate,
                                              ProjectDescription = project.ProjectDescription

                                          });
            return newProject;
        }

        public List<Project> GetAll()
        {
           return new List<Project>(projects);
        }

        public Project Get(int id)
        {
            return projects.FirstOrDefault(x => x.Id == id);
        }

 

        public Project Delete(int id)
        {
            var selectedProject = Get(id);
            projects.Remove(selectedProject);
            return selectedProject;
        }
    }
}
