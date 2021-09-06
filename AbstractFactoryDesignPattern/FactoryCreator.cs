using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public class FactoryCreator
    {
        public static SourceCourseFactory GetSourceCourseFactory(string type)
        {
            if (type=="course")
            {
                return new CourseFactory();
            }
            if (type=="source")
            {
                return new SourceFactory();
            }
            return null;
        }

       
    }
}
