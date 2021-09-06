using System;
using System.Linq;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "this is a super cool space   remove test    from string";
            Console.WriteLine(str.RemoveSpaceFromString());
            var a = string.Join(" ", str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            Console.WriteLine(a);
            Employee emp = new Employee() { FirstName = "Shani", LastName = "Bhati", Salary = 66000 };
            Console.WriteLine("Employee full name is "+emp.FullName());
        }
    }
}
