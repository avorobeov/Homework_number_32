using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_32
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            numbers = Shuffle(numbers);

            DrawArray(numbers);

            Console.ReadLine();
        }

        private static int[] Shuffle(int [] numbers)
        {
            Random random = new Random();

            int tempNumber = 0;
            int indexRandomElement = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                indexRandomElement = random.Next(0, numbers.Length);
                tempNumber = numbers[indexRandomElement];
                numbers[indexRandomElement] = numbers[i];
                numbers[i] = tempNumber;
            }

            return numbers;
        }

        private static void DrawArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
