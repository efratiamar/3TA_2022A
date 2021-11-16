using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DO
{
    public struct Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int StartYear { get; set; }
        public StudentStatus Status { get; set; }
        //public override string ToString() => this.ToStringProperty();
    }

    public struct Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float CreditPoint { get; set; }
        public int Year { get; set; }
        public Semester Semester { get; set; }

    }

    public struct StudentInCourse
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public float? Grade { get; set; }
    }
    
    //Lecturer

}

