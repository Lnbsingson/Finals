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
            Student test = new Student("biboy lagrosa", "CpE", "Coe123", "Mapua University", "lagrosaAte@gmail.com", "0931247141");
            Student test2 = new Student("biboy lagrosa", "CpE", "Coe123", "Mapua University", "lagrosaAte@gmail.com");
            //Student test3 = new Student("biboy lagrosa", "CpE", "Coe123", "Mapua University");
            //Student test4 = new Student("biboy lagrosa", "CpE", "Coe123");
            //Student test5 = new Student("biboy lagrosa", "CpE", "Coe123");
            //Student test6 = new Student("biboy lagrosa", "CpE");
            //Student test7 = new Student("biboy lagrosa");
            //Student test8 = new Student();
            //test.displayData();
            //test2.displayData();
            //test3.displayData();
            //test4.displayData();
            //test5.displayData();
            //test6.displayData();
            //test7.displayData();
            //test8.displayData();
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
