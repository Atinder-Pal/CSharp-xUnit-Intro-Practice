using System;
using System.Collections.Generic;

namespace XUnitIntroPractice
{
    public class Program
    {
        static List<string> validStrings = new List<string>() { "YES", "Y", "NO", "N" };
        public static void Main(string[] args)
        {
            //Testing the method here first
            //Console.WriteLine(IsYesOrNo("      y 4    "));
        }

        public static bool IsYesOrNo(string inputString)
        {            
            bool result = validStrings.Contains(inputString.Trim().ToUpper());
            return result;
        }

        public static void ThrowsFormatException()
        {
            float.Parse("Hello");
        }

        public static void ThrowsIndexOutOfRangeException()
        {
            int[] StudentIds = new int[]{ 1,2,3,4,5};
            //Get StudentID at tenth index in array
            int output = StudentIds[10];
        }

        public static void ThrowsNullReferenceException()
        {
            string foo = null;
            foo.ToUpper();
        }

        public static void ThrowsDivideByZeroException()
        {
            int foo = 19;
            int bar = foo/0;
        }

       
        public static void ThrowsStackOverflowException()
        {
            /* The following code should work but the test took a lot of time, so manually throwing exception*/
            //int i = 0;
            //while(true)
            //{
            //    i++;
            //}
            throw new StackOverflowException("Manually thrown Stack Overflow Exception");
        }
    }
}
