using SDMBLL.InterfaceServices;
using SDMEntity.BE;
using System;
using System.Collections.Generic;
using SDMDAL;
using SDMDAL.InterfaceRepositories;

namespace SDMBLL.Services
{
    public class StudentService : IStudentService
    {
        private IStudentRepository repo = new DALFacade().StudentRepository;

        public Student Create(Student student)
        {
            return repo.Create(student);
        }

        public List<Student> GetAll()
        {
            return repo.GetAll();
        }

        public Student GetById(int id)
        {
            return repo.GetById(id);
        }

        public Student Update(Student student)
        {
            throw new NotImplementedException();
        }

        public Student Delete(int id)
        {
            return repo.Delete(id);
        }
    }
}
