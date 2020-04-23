using System;

namespace ReverseString
{
    class MainClass
    {
        //This program asks the user for a word that they want to reverse. It then reverses the string.
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word or sentence that you would like to reverse: ");

            string str = Console.ReadLine();  //Converts the user input to string str

            for (int i = str.Length - 1; i >= 0; i--)  //loops the str and prints off each letter in reverse
            {
                Console.WriteLine(str[i]);

            }
        }
    }
}
