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
    }
}
