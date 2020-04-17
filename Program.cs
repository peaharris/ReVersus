using System;

namespace ReverseString
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str = "hello";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(str[i]);

            }
        }
    }
}
