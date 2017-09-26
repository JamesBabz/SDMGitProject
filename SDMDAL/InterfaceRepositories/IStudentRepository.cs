using System;
using System.Collections.Generic;
using System.Text;
using SDMEntity.BE;

namespace SDMDAL.InterfaceRepositories
{
    public interface IStudentRepository
    {
        //C
        Student Create(Student student);

        //R
        List<Student> GetAll();
        Student GetById(int id);

        //D
        Student Delete(int id);
    }
}
