using System;
using System.Collections.Generic;
using System.Linq;
namespace Задачки
{

    public class Solution
    {


        static void remover(int[] array, int val)
        {

            int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) != val)
                {
                    array[k] = array[i];
                    k++;
                }
                else
                    continue;
            }
        }
        public static bool Palindromtest(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)

                if (s[i] != s[s.Length - i - 1])
                    return false;
            return true;
        }
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
        static int[] BubbleSort(int[] array)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Реализовать приложение C#, которое предоставит функционал \n сложения каждого второго нечетного числа из массива чисел \n тела запроса и вернёт их сумму по модулю.\n");
            Console.ResetColor();
            int[] nums = new int[] { 1, 2, 2, 2, 2, 3, 1, 5, 1, 7 };
            Console.WriteLine("Изначальный массив :");
            foreach (int i in nums)
                Console.Write($"{i} ");
            int size = 0;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    nums[i] = 0;
                }

                else
                {
                    size++;
                }
            }
            remover(nums, 0);
            Array.Resize(ref nums, size);
            Console.WriteLine("");

            for (int j = 0; j < size; j++)
            {
                if (j % 2 == 1)
                {
                    sum += Math.Abs(nums[j]);
                }
            }
            Console.WriteLine($"Сумма всех нечетных чисел,каждое из которых является вторым, равна - {sum}\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("2. Реализовать приложение C#, которое предоставит функционал \n определения входящий строки на предмет, является ли она палиндромом.");
            Console.ResetColor();

            Console.WriteLine("Анализ палиндромов\n\nВведите строку:");
            string s = Console.ReadLine();
            if (Palindromtest(s.ToLower()))
                Console.WriteLine("Эта строка - палиндром");
            else Console.WriteLine("Эта строка - не палиндром");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("3. Реализовать приложение C#, которое отсортирует \n и выведет список целых чисел.");
            Console.ResetColor();

            Console.Write("Введите элементы массива: ");
            var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var array = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                array[i] = Convert.ToInt32(parts[i]);
            }
            Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", BubbleSort(array)));
            /* Я выбрал пузырчатую сортировку массива, я слышал про нее больше всего, алгоритм заключается в цикле, который при каждой итерации проверяет пары чисел на то какое больше и если левое больше - ставит его направо
             * после таких проходов все числа, что были больше, окажутся справа, а те что меньше - слева , так они и встанут в порядке возрастания - "1,2,3,4,5"
             * 
             * 
             * 
             * 
             * 
             */
        }
    }
}





