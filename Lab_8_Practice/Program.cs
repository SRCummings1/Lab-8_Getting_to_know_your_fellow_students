using System;

namespace Lab_8_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentNumber;
            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about?(enter a number 1-5)");
            studentNumber = int.Parse(Console.ReadLine());
            int[] array = new int[5]; // Create an array.
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;
            Test(array);
            Test(null); // No output.
            Test(new int[0]); // No output.
        }

        static void Test(int[] array)
        {
            if (array != null &&
                array.Length > 0)
            {
                int first = array[2];
                Console.WriteLine(first);
            }
        }
    }

}