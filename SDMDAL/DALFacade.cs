using System;
using System.Collections.Generic;
using System.Text;
using SDMDAL.InterfaceRepositories;
using SDMDAL.Repositories;

namespace SDMDAL
{
    public class DALFacade
    {
        public ICompanyRepository CompanyRepository => new CompanyRepositoryFakeDB();
        public IAdminRepository AdminRepository => new AdminRepositoryFakeDB();
        public IProfileRepository ProfileRepository => new ProfileRepositoryFakeDB();
        public IProjectRepository ProjectRepository => new ProjectRepositoryFakeDB();
        public IStudentRepository StudentRepository => new StudentRepodsfsfdssitoryFakeDB();
        public ISupervisorRepository SupervisorRepository => new SupervisorRepositoryFakeDB();
        public ISupervisorRequestRepository SupervisorRequestRepository => new SupervisorRequestRepositoryFakeDB();
        public IUserRepository UserRepository => new UserRepositoryFakeDB();
        public ICategoryRepository CategoryRepository => new CategoryRepositoryFakeDB();
        public IProjectRequest ProjectRequest => new ProjectRequestRepositoryFakeDB();
        public IStudentGroupRepository StudentGroupRepository => new StudentGroupRepositoryFakeDB();

    }
}
