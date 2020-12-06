using System;

namespace WCA_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 1;
            //int b = 1;
            //int c = 1;
            //int d = 1;
            //int e = 1;

            // A B C D E F => values in array
            // 1 2 3 4 5 6 => item count.
            // 0 1 2 3 4 5 => index address.

            // 1)
            int[] numbers = new int[5]; //a "numbers" array with 5 values in int data type.
            numbers[4] = 10;
            numbers[0] = 20;
            numbers[1] = 30;
            numbers[2] = 40;
            numbers[3] = 50;
            // numbers[5] = 100; // index was outside the bounds of the array.

            int n = numbers[4];

            // 2)
            string[] cities = new string[5] { "istabul", "london", "tokio", "seoul", "new york" };
            string city = cities[0];


            // 3)
            char[] characters = { 'a', 'b', 'c', 'd', 'e', };
            characters[1] = 'x';

        }
    }
}
