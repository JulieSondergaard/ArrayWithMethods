using System;

namespace ArrayWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            GetNumbers();
        }
        public static void GetNumbers()
        {
            int[] numbers = new int[9];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;

                if (i == 5)
                {
                    numbers[i] = numbers[i - 1] * 2;
                }
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
