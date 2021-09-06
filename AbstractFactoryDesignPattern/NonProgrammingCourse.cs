using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    class NonProgrammingCourse : ICourse
    {
        public string getCourseName()
        {
            return "DSA";
        }
    }
}
