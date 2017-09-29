using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SDMDAL.InterfaceRepositories;
using SDMEntity.BE;

namespace SDMDAL.Repositories
{
    class StudentGroupRepositoryFakeDB : IStudentGroupRepository
    {
        private static int Id = 1;
        private static List<StudentGroup> studentGroups = new List<StudentGroup>();

        public StudentGroup Create(StudentGroup group)
        {
            StudentGroup newStudentGroup = null;
            studentGroups.Add(newStudentGroup = new StudentGroup()
            {
                StudentGroupID = Id++,
                Name = newStudentGroup.Name,
                Semester = newStudentGroup.Semester
            });
            return newStudentGroup;
        }

        public StudentGroup Delete(int StudentGroupID)
        {
            var studentGroupFound = Get(StudentGroupID);
            studentGroups.Remove(studentGroupFound);
            return studentGroupFound;
        }

        public StudentGroup Get(int group)
        {
            return studentGroups.FirstOrDefault(x => x.StudentGroupID == group);
        }

        public List<StudentGroup> GetAll()
        {
            return new List<StudentGroup>(studentGroups);
        }
    }
}
