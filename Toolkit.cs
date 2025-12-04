using System;

namespace BeginnerToolkit
{
    public static class Toolkit
    {
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers.Length == 0) return 0;
            double sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;
        }

        public static string ReverseString(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public static int SquareNumber(int number)
        {
            return number * number;
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
