using System;
using System.Collections.Generic;
using System.Text;
using SDMEntity.BE;

namespace SDMDAL.InterfaceRepositories
{
    public interface IStudentGroupRepository
    {
        //C
        StudentGroup Create(StudentGroup group);

        //R
        List<StudentGroup> GetAll();

        StudentGroup Get(int group);

        //U


        //D
        StudentGroup Delete(int StudentGroupID);

    }
}
