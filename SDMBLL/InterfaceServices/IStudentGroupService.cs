using System;
using System.Collections.Generic;
using System.Text;
using SDMEntity.BE;

namespace SDMBLL.InterfaceServices
{
    interface IStudentGroupService
    {
        //C
        StudentGroup Create(StudentGroup studentGroup);

        //R
        List<StudentGroup> GetAll();
        StudentGroup GetById(int id);

        //U
        StudentGroup Update(StudentGroup studentGroup);

        //D
        StudentGroup Delete(int id);
    }
}
