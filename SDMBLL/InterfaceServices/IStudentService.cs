using System;
using System.Collections.Generic;
using System.Text;
using SDMEntity.BE;
namespace SDMBLL.InterfaceServices
{
    public interface IStudentService
    {
        //C
        Student Create(Student student);

        //R
        List<Student> GetAll();
        Student GetById(int id);

        //U
        Student Update(Student student);

        //D
        Student Delete(int id);
    }
}
