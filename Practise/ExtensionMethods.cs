using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practise
{
    public static class ExtensionMethods
    {
        public static string RemoveSpaceFromString(this string str)
        {
            return new string(str.ToCharArray().Where(c => !char.IsWhiteSpace(c)).ToArray());
        }

        public static string FormatUniformSpaceInString(this string str1)
        {
            return string.Join(" ", str1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }

        public static void MethodA(this IMyInterface myInterface, int i)
        {
            Console.WriteLine
                ("Extension.MethodA(this IMyInterface myInterface, int i)");
        }

        public static void MethodA(this IMyInterface myInterface, string s)
        {
            Console.WriteLine
                ("Extension.MethodA(this IMyInterface myInterface, string s)");
        }

        // This method is never called in ExtensionMethodsDemo1, because each
        // of the three classes A, B, and C implements a method named MethodB
        // that has a matching signature.
        public static void MethodB(this IMyInterface myInterface)
        {
            Console.WriteLine
                ("Extension.MethodB(this IMyInterface myInterface)");
        }
    }
}
