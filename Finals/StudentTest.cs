using System;
using System.Collections.Generic;
using System.Text;


namespace Finals
{
    class StudentTest
    {
        public StudentTest() { }

        
        
        public Student data1 { get; set; }
        public Student data2 { get; set; }
        public void DoTest()
        {
            Student test = new Student("John Doe", "BS Architecture II", "Computer Programming 2", "University of the Philippines", "johndoe@gmail.com", "09475346671");
            Student test2 = new Student("John Doe", "BS Architecture II", "Computer Programming 2", "University of the Philippines", "johndoe@gmail.com");
            data1 = test;
            data2 = test2;


        }
        public void DisplayData1()
        {
            data1.displayData();
        }

        public void DisplayData2()
        {
            data2.displayData();
        }
    }
}
