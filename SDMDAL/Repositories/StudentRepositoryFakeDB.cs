using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SDMDAL.InterfaceRepositories;
using SDMEntity.BE;

namespace SDMDAL.Repositories
{
    class StudentRepositoryFakeDB : IStudentRepository
    {
        private static int Id = 1;
        private static List<Student> Students = new List<Student>();

        public Student Create(Student student)
        {
            Student newStudent;
            Students.Add(newStudent = new Student()
            {
                Id = Id++,
                Name = student.Name,
                Address = student.Address,
                Email = student.Email,
                Phone = student.Phone
            });
            return newStudent;
        }

        public List<Student> GetAll()
        {
            return new List<Student>(Students);
        }

        public Student GetById(int id)
        {
            return Students.FirstOrDefault(x => x.Id == id);
        }

        public Student Delete(int id)
        {
            var studentFound = GetById(id);
            Students.Remove(studentFound);
            return studentFound;
        }
    }
}
