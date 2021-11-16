using System;
using System.Collections.Generic;

namespace BLApi
{
    public interface IBL
    {
        BO.Student GetStudent(int id);

        IEnumerable<BO.Student> GetAllStudents();

        //IEnumerable<BO.StudentForList> GetAllStudentsForList();



    }
}
