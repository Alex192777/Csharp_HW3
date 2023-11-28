// Задача 1: Задайте одномерный массив из 10 целых
// чисел от 1 до 100. Найдите количество элементов
// массива, значения которых лежат в отрезке [20,90]
// пример: 
// массив [10 21 14 93 23] => 2


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
            
            if (array[i] >= 20 && array[i] <= 90)
            {
                count++;
            }
        }

        Console.WriteLine("\nКоличество элементов, значения которых лежат в отрезке [20, 90]: " + count);
    }
}
