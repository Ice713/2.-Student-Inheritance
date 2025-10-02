using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Student_Inheritance
{
    internal class Student : Person
    {
        public string Course { get; set; }

        public Student(string name, int age, string course) : base(name, age)
        {
            Course = course;
        }
    }
}
