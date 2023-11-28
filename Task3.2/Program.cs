// Задача 2: Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве.
// Пример:
// массив [6 7 19 34 3 1 4 7 9 1] => 3
// массив [1 8 43 4 55 60 3 2 1 3] => 4

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[10];
        int count = 0;

        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 100);
            Console.Write(array[i] + " ");

            if (array[i] % 2 == 0)
            {
                count++;
            }
        }

        Console.WriteLine("\nКоличество четных чисел в массиве: " + count);
    }
}