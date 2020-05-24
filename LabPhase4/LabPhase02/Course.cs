using System;
using System.Collections.Generic;
using System.Text;

namespace LabPhase3
{
    public class Course
    {
        //figure out if going to use this at some point
        public string courseID { get; set; }
        public string courseName { get; set; }
        public int courseCredits { get; set; }
        public string courseGrade { get; set; }
        public string courseDescription { get; set; }


         public Course(string id, string name, int credits, string grade, string desc)
        {
            courseID = id;
            courseName = name;
            courseCredits = credits;
            courseGrade = grade;
            courseDescription = desc;
        }
        public Course(string id, string name, int credits, string desc)
        {
            courseID = id;
            courseName = name;
            courseCredits = credits;
            courseDescription = desc;
        }
    }
}
