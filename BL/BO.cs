using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BO
{

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int StartYear { get; set; }
        public StudentStatus Status { get; set; }
        public IEnumerable<CourseForList> StudentCourses { get; set; }
    }

    public class StudentForList
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float CreditPoint { get; set; }
        public int Year { get; set; }
        public enum Semester { ELUL, A, B, YEAR, SUMMER }

        //public IEnumerable<LecturerForList> CourseLecturers { get; set; }

    }

    public class CourseForList
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

}

