using System;
using System.Collections.Generic;
using System.Text;

namespace Practise
{
    public static class EmployeeExtensions
    {
        public static string FullName(this Employee employee)
        {
            return $"{employee.FirstName} {employee.LastName}";
        }
    }
}
