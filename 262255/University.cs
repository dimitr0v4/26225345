using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _262255
{
    internal class University
    {
        List<Student> uni=new List<Student>{ };
        public  void AddStudent(Student student) 
            { uni.Add(student);
            InsSort(uni);}
        public static void InsSort(List<Student> uni) 
            { }
    }
}
