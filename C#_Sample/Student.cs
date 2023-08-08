using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Sample
{
    internal class Student
    {
        public String name;
        public String major;
        public double gpa;

        public Student(String name, String major, double gpa)
        {
            this.name = name;
            this.major = major; 
            this.gpa = gpa;

        }

        public bool HasHonors()
        {
            if(this.gpa > 9)
            {
                return true;
            }
            return false;
        }
    }
}
