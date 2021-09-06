using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public class CourseFactory : SourceCourseFactory
    {
        public override ICourse getCourse(string courseType)
        {
            if (courseType=="Programming")
            {
                return new ProgrammingCourse();
            }
            else
            {
                return new NonProgrammingCourse();
            }
        }

        public override ISource getSource(string sourceType)
        {
            throw new NotImplementedException();
        }
    }
}
