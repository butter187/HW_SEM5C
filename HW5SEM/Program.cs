// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[]array = GetRandomArray(10, 100, 999);
// Console.WriteLine($"[{String.Join(",", array)}]");
// Console.WriteLine(FindElement(array));

// // -------------------------------Общий метод-------------------------------------------
// int[] GetRandomArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }

//     return result;
// }

// // -------------------------------Общий метод-------------------------------------------
// int FindElement(int[] array)
// {
//     int count = 0;
//     foreach (int el in array)
//     {
//         if (el % 2 == 0) count++;
//     }
//     return count;
// }

// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[]array = GetRandomArray(10, 0, 99);
// Console.WriteLine($"[{String.Join(",", array)}]");
// Console.WriteLine(SumElement(array));

// // -------------------------------Общий метод-------------------------------------------
// int[] GetRandomArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }

//     return result;
// }

// // -------------------------------Общий метод-------------------------------------------
// int SumElement(int[] array)
// {
//     int sum = 0;
//     int i = 1;
//     while (i <= array.Length)
//     {
//         sum += array[i];
//         i += 2;
//     }
//     return sum;
// }

// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7.4, 22.3, 2, 78] -> 76
Console.WriteLine("Введите размер массива ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите нижнюю границу массива ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите верхнюю границу массива ");
int B = int.Parse(Console.ReadLine()!);

double[]array = GetRandomArray(N, A, B);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine(DiffElement(array));
// -------------------------------Общий метод-------------------------------------------
double[] GetRandomArray(int size, int minValue, int maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }

    return result;
}
// -------------------------------Общий метод-------------------------------------------
double DiffElement(double[] array)
{
    double diff = 0;
    double min = B;
    double max = A;

    foreach(double el in array)
{
    if (el > max ) max=el;
    if (el < min ) min=el;
}
   
    diff = max - min;
    return diff;
}

