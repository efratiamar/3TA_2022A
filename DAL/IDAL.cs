using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLApi
{
    public interface IDAL
    {

        //CRUD Student
        public DO.Student GetStudent(int id);
        public bool CheckStudent(int id);
        public void AddStudent(DO.Student stud);
        public void UpdStudent(DO.Student stud);
        public void DelStudent(int id);
        public IEnumerable<DO.Student> GetALLStudents();

        public IEnumerable<DO.Student> GetStudentsByPerdicate(Predicate<DO.Student> predicate);


        //CRUD StudentInCourse
        //AddCourse
        //UpdCourse
        //
        public IEnumerable<DO.StudentInCourse> GetStudentsInCourseByPredicate(Predicate<DO.StudentInCourse> predicate);



        //CRUD Lecturer

        //CRUD Courses
        public DO.Course GetCourse(int id);
        public bool CheckCourse(int id);
        public IEnumerable<DO.Course> GetALLCourses();
        public IEnumerable<DO.Course> GetCoursesByPredicate(Predicate<DO.Course> predicate);


        //public IEnumerable<DO.Student> GetALLCourses();
        //public void AddCourse(DO.Student stud);
        //public void UpdCourse(DO.Student stud);
        //public void DelCourse(int id);


    }
}
