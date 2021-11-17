using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DLApi;
using DO;

namespace DalObject
{
    public class DalObject : IDAL
    {
        public DalObject()
        {
            DataSource.Init();
        }

        #region Student
        public DO.Student GetStudent(int id)
        {
            if ( !CheckStudent(id) )
                throw new DO.MissingIdException(id, "Student");

            DO.Student stud = DataSource.StudentsList.Find(stud => stud.ID == id);                
            return stud;
        }

        public bool CheckStudent(int id)
        {
            return DataSource.StudentsList.Any(stud => stud.ID == id);
        }

        public IEnumerable<DO.Student> GetALLStudents()
        {
            return from stud in DataSource.StudentsList
                   select stud;
            //return DataSource.StudentsList;
        }

        public void AddStudent(DO.Student stud)
        {
            if ( CheckStudent(stud.ID) )
                throw new DO.DuplicateIdException(stud.ID, "Student");

            DataSource.StudentsList.Add(stud);
        }

        public void UpdStudent(DO.Student stud)
        {
            int count = DataSource.StudentsList.RemoveAll(st => stud.ID == st.ID);
            
            if (count == 0)
                throw new DO.MissingIdException(stud.ID, "Student");

            DataSource.StudentsList.Add(stud);
        }

        public void DelStudent(int id)
        {
            int count = DataSource.StudentsList.RemoveAll(stud => stud.ID == id);

            if (count == 0)
                throw new DO.MissingIdException(id, "Student");
        }

        public IEnumerable<Student> GetStudentsByPerdicate(Predicate<Student> predicate)
        {
            return from stud in DataSource.StudentsList
                   where predicate(stud)
                   select stud;
        }
        #endregion

        #region Course
        public DO.Course GetCourse(int id)
        {
            if (!CheckCourse(id))
                throw new DO.MissingIdException(id, "Course");

            DO.Course crs = DataSource.CoursesList.Find(crs => crs.ID == id);
            return crs;
        }

        public bool CheckCourse(int id)
        {
            return DataSource.CoursesList.Any(crs => crs.ID == id);
        }

        public IEnumerable<DO.Course> GetALLCourses()
        {
            return from crs in DataSource.CoursesList
                   select crs;
        }
        public IEnumerable<DO.Course> GetCoursesByPredicate(Predicate<DO.Course> predicate)
        {
            return from crs in DataSource.CoursesList
                   where predicate(crs)
                   select crs;

        }
        #endregion

        #region StudentInCourse

        public IEnumerable<DO.StudentInCourse> GetStudentsInCourseByPredicate(Predicate<DO.StudentInCourse> predicate)
        {
            return from sic in DataSource.StudentInCourseList
                   where predicate(sic)
                   select sic;
        }



        #endregion


    }
}
