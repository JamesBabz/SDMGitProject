using System;
using System.Collections.Generic;
using System.Text;
using SDMBLL.InterfaceServices;
using SDMDAL;
using SDMDAL.InterfaceRepositories;
using SDMEntity.BE;

namespace SDMBLL.Services
{
    public class StudentGroupService : IStudentGroupService
    {

        private IStudentGroupRepository repo = new DALFacade().StudentGroupRepository;

        public StudentGroup Create(StudentGroup studentGroup)
        {
            return repo.Create(studentGroup);
        }

        public StudentGroup Delete(int id)
        {
            return repo.Delete(id);
        }

        public List<StudentGroup> GetAll()
        {
           return repo.GetAll();
        }

        public StudentGroup GetById(int id)
        {
            return repo.Get(id);
        }

        public StudentGroup Update(StudentGroup studentGroup)
        {
            throw new NotImplementedException();
        }
    }
}
