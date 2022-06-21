using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ReversingTask("Fidan muazzamdi");

        }

        static void ReversingTask(string word)
        {
            string reverseString = string.Empty;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverseString += word[i];
            }
            Console.Write($"Reverse String is : {reverseString} ");
        }


    }
}
