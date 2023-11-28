// Задача 3: Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива.
// Пример:
// массив [2.2 0.4 9.11 7.2 78.98] => 78.58
// массив [1.22 4.5 3.33] => 3.28


using System;

class Program
{
    static void Main()
    {
        // Создание рандомного массива из вещественных чисел
        Random random = new Random();
        double[] array = new double[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.NextDouble() * 100; // Генерация случайного вещественного числа
        
        }
        // Нахождение максимального и минимального элементов массива
        double max = array[0];
        double min = array[0];
        foreach (double num in array)
        {
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        
        }
        // Нахождение разницы между максимальным и минимальным элементами
        double difference = max - min;

        // Вывод результата
        Console.WriteLine("Массив: " + string.Join(", ", array));
        Console.WriteLine("Максимальный элемент: " + max);
        Console.WriteLine("Минимальный элемент: " + min);
        Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
    }
}