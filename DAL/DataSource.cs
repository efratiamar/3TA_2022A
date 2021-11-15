
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DalObject
{
    public class DataSource
    {
        internal class Config
        {
            //internal static int cntStudentId = 0;

        }

        internal static List<DO.Student> StudentsList = new List<DO.Student>();
        internal static List<DO.Course> CoursesList = new List<DO.Course>();
        internal static List<DO.StudentInCourse> StudentInCourseList = new List<DO.StudentInCourse>();



        static Random rand = new Random(); //add current time
        public static void Init()
        {
            createStudents();
            createCourses();
            createStudentsInCourses();
            //createLecturers();
            //createLecturersInCourse();

        }
        private static void createStudents()
        {

            StudentsList = new List<DO.Student>
            {
                new DO.Student
                {
                    ID = rand.Next(100, 200),
                    StartYear = 2018,
                    Status = DO.StudentStatus.ACTIVE,
                },
                new DO.Student
                {
                    ID = rand.Next(100, 200),
                    StartYear = 2017,
                    Status = DO.StudentStatus.FINISHED,
                },
                new DO.Student
                {
                    ID = rand.Next(100, 200),
                    StartYear = 2013,
                    Status = DO.StudentStatus.FINISHED,
                }

            };

        }

        private static void createCourses()
        {
            CoursesList = new List<DO.Course>
            {
                new DO.Course
                {
                    ID = 1,
                    Name = "MiniProject with Windows Systems",
                    CreditPoint = 3,
                    Year = 2010,
                    Semester = DO.Semester.A
                },

                new DO.Course
                {
                    ID = 2,
                    Name = "Intro to CS",
                    CreditPoint = 4,
                    Year = 2011,
                    Semester = DO.Semester.B
                },

                new DO.Course
                {
                    ID = 3,
                    Name = "Data Structure 1",
                    CreditPoint = 4,
                    Year = 2014,
                    Semester = DO.Semester.A
                },

                new DO.Course
                {
                    ID = 4,
                    Name = "Data Structure 2",
                    CreditPoint = 4,
                    Year = 2014,
                    Semester = DO.Semester.B
                }


            };
        }

        private static void createStudentsInCourses()
        {
            StudentInCourseList = new List<DO.StudentInCourse>
            {
                new DO.StudentInCourse
                {
                    StudentId = StudentsList[0].ID,
                    CourseId = CoursesList[0].ID,
                    Grade = 100
                },
                new DO.StudentInCourse
                {
                    StudentId = StudentsList[1].ID,
                    CourseId = CoursesList[1].ID,
                    Grade = 100
                },
                new DO.StudentInCourse
                {
                    StudentId = StudentsList[1].ID,
                    CourseId = CoursesList[2].ID,
                    Grade = 100
                },
                new DO.StudentInCourse
                {
                    StudentId = StudentsList[2].ID,
                    CourseId = CoursesList[2].ID,
                    Grade = 100
                }
            };

        }



    }
}
