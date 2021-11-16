using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BLApi;
using DLApi;

namespace BL
{
    class BLImp : IBL
    {
        IDAL dl;
        public BLImp()
        {
            dl = new DalObject.DalObject();
        }
        public BO.Student GetStudent(int id)
        {
            BO.Student boStudent = new BO.Student();
            try
            {
                DO.Student doStudent = dl.GetStudent(id);
                boStudent.ID = doStudent.ID;
                boStudent.Name = doStudent.Name;
                boStudent.StartYear = doStudent.StartYear;
                boStudent.Status = (BO.StudentStatus)doStudent.Status;

                boStudent.StudentCourses = GetCoursesPerStudent(id);
                //boStudent.StudentCourses = from sic in dl.GetStudentsInCourseByPredicate(sic => sic.StudentId == id)
                //                           let crs = dl.GetCourse(sic.CourseId)
                //                           select new BO.CourseForList()
                //                           {
                //                               ID = crs.ID,
                //                               Name = crs.Name
                //                           };
            }
            catch (DO.MissingIdException ex)
            {
                throw new BO.MissingIdException(ex.ID, ex.EntityName);
            }

            return boStudent;
        }

        //private!! Help method
        private IEnumerable<BO.CourseForList> GetCoursesPerStudent(int id)
        {
            return from sic in dl.GetStudentsInCourseByPredicate(sic => sic.StudentId == id)
                   let crs = dl.GetCourse(sic.CourseId)
                   select new BO.CourseForList()
                   {
                       ID = crs.ID,
                       Name = crs.Name
                   };
        }

        public IEnumerable<BO.Student> GetAllStudents()
        {
            return from doStud in dl.GetALLStudents()
                   select new BO.Student()
                   {
                       ID = doStud.ID,
                       Name = doStud.Name,
                       StartYear = doStud.StartYear,
                       Status = (BO.StudentStatus)doStud.Status,
                       StudentCourses = GetCoursesPerStudent(doStud.ID)
                   };

        }

        
        //public IEnumerable<BO.StudentForList> GetAllStudentsForList()
        //{
        //    throw new NotImplementedException();
        //}

    }
}
