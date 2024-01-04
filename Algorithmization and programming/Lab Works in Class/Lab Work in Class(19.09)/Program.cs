using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main()
        {
            SecondProblem();
        }

        static void FirstProblem()
        {
            float number, max, sum_3 = 0;
            int amount_of_negative = 0;
            number = (float)Convert.ToDouble(Console.ReadLine());
            max = number;
            float min_positive = Math.Abs(max);
            if (number < 0)
            {
                amount_of_negative++;
            }
            if (number > 0)
            {
                if (number % 3 == 0)
                {
                    sum_3 += number;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                number = (float)Convert.ToDouble(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }
                if (number < 0)
                {
                    amount_of_negative++;
                }
                if (number > 0)
                {
                    if (number % 3 == 0)
                    {
                        sum_3 += number;
                    }
                    if (number < min_positive)
                    {
                        min_positive = number;
                    }
                }
            }
            Console.WriteLine("Максимальный элемент: " + max);
            Console.WriteLine("Количество отрицательных: " + amount_of_negative);
            Console.WriteLine("Сумма положительных кратных 3: " + sum_3);
            Console.WriteLine("Минимальный среди положительных: " + min_positive);
            Console.ReadKey();
        }

        static void SecondProblem()
        {
            int n, number1 = 0, number2 = 0, number3 = 0, current_long_of_subsequence = 0,
            amount_of_numbers_bigger_than_previous = 0,
            amount_of_numbers_bigger_than_previous_numbers = 0,
            amount_of_numbers_bigger_than_left_and_right = 0,
            longest_subsequence = 1;

            n = Convert.ToInt32(Console.ReadLine());

            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            number3 = Convert.ToInt32(Console.ReadLine());

            int current_max = number2;

            if (current_max < number1)
            {
                amount_of_numbers_bigger_than_previous_numbers++;
                current_max = number3;
            }

            if (number2 > number1)
            {
                amount_of_numbers_bigger_than_previous++;
                current_long_of_subsequence++;
            }
            else
            {
                if (longest_subsequence > current_long_of_subsequence)
                {
                    longest_subsequence = current_long_of_subsequence;
                }
                current_long_of_subsequence = 1;
            }
            if ((number2 > number1) & (number2 > number3))
            {
                amount_of_numbers_bigger_than_left_and_right++;
            }
            for (int i = 0; i < n - 3; i++)
            {
                number1 = number2;
                number2 = number3;
                number3 = Convert.ToInt32(Console.ReadLine());
                if (current_max < number1)
                {
                    amount_of_numbers_bigger_than_previous_numbers++;
                    current_max = number3;
                }
                if (number2 > number1)
                {
                    amount_of_numbers_bigger_than_previous++;
                    current_long_of_subsequence++;
                }
                else
                {
                    if (longest_subsequence > current_long_of_subsequence)
                    {
                        longest_subsequence = current_long_of_subsequence;
                    }
                    current_long_of_subsequence = 1;
                }
                if ((number2 > number1) & (number2 > number3))
                {
                    amount_of_numbers_bigger_than_left_and_right++;
                }
            }
            Console.WriteLine("Количество элементов, значение которых больше предыдущего элемента: " +
            amount_of_numbers_bigger_than_previous);
            Console.WriteLine("Количество элементов, значение которых больше левого и правого от него элементов: "
            + amount_of_numbers_bigger_than_left_and_right);
            Console.WriteLine("Количество элементов, значение которых больше всех элементов, вводимых до него: " +
            amount_of_numbers_bigger_than_previous_numbers);
            Console.WriteLine("Наибольшая длина возрастающей последовательности: " + longest_subsequence);
            Console.ReadKey(); 
        }
    }
}
