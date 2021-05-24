using System;
using System.Collections.Generic;
using System.Text;

namespace Finals
{
    class Student
    {
        public string fullName { get; set; }
        public string course { get; set; }
        public string subject { get; set; }
        public string university { get; set; }
        public string email { get; set; }
        public string pN { get; set; }
        public Student(string FullName, string Course, string Subject, string University, string Email, string PN)
        {
            this.fullName = FullName;
            this.course = Course;
            this.subject = Subject;
            this.university = University;
            this.email = Email;
            this.pN = PN;
            
        }
        public Student(string FullName, string Course, string Subject, string University, string Email)
        {
            this.fullName = FullName;
            this.course = Course;
            this.subject = Subject;
            this.university = University;
            this.email = Email;
            this.pN = null;

        }
        public Student(string FullName, string Course, string Subject, string University)
        {
            this.fullName = FullName;
            this.course = Course;
            this.subject = Subject;
            this.university = University;
            this.email = null;
            this.pN = null;

        }
        public Student(string FullName, string Course, string Subject)
        {
            this.fullName = FullName;
            this.course = Course;
            this.subject = Subject;
            this.university = null;
            this.email = null;
            this.pN = null;

        }
        public Student(string FullName, string Course)
        {
            this.fullName = FullName;
            this.course = Course;
            this.subject = null;
            this.university = null;
            this.email = null;
            this.pN = null;

        }
        public Student(string FullName)
        {
            this.fullName = FullName;
            this.course = null;
            this.subject = null;
            this.university = null;
            this.email = null;
            this.pN = null;

        }
        public Student()
        {
            this.fullName = null;
            this.course = null;
            this.subject = null;
            this.university = null;
            this.email = null;
            this.pN = null;

        }
        public static int InstanceCounter = 0;
        public  void displayData()
        {
            Console.WriteLine($"The data of the student: {fullName} \nCourse: {course}\nSubject: {subject}\nUniversity:{university}\nEmail:{email}\nPhone Number: {pN}");
        }

    }
}
