// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] GenerateArray(int size, int leftRange, int rightRange)
// {
//     int[] array = new int[size];
//     var rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(leftRange, rightRange + 1);
//     }
//     return array;
// }

// int SumNumberEven(int[] arr) 
// {
//     int result = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0)
//         {
//             result++;
//         }
//     }
//     return result;
// }

// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join(", ", array) + "]");
// }

// int[] arr = GenerateArray(7, 100, 1000);
// PrintArray(arr);
// System.Console.WriteLine($"Количество четных чисел в массиве = {SumNumberEven(arr)}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
//  стоящих на нечётных позициях.
//  [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] GenerateArray(int size, int leftRange, int rightRange)
// {
//     int[] array = new int[size];
//     var rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(leftRange, rightRange + 1);
//     }
//     return array;
// }

// int SumNumberEven(int[] arr)
// {
//     int result = 0;
//     for (int i = 1; i < arr.Length; i = i + 2)
//     {
//         result = result + arr[i];
//     }
//     return result;
// }

// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join(", ", array) + "]");
// }

// int[] arr = GenerateArray(6, 1, 20);
// PrintArray(arr);
// System.Console.WriteLine($"Сумма чисел на нечетных позициях в массиве = {SumNumberEven(arr)}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
//  элементов массива.
// [3 7 22 2 78] -> 76

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

void FindMaxAndMin(int[] arr, out int Max, out int Min, out int SumMaxMin)
{
    Max = 0;
    Min = arr[0];
    SumMaxMin = 0;
    
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > Max)
        {
            Max = arr[i];
        }
        else if (arr[i] < Min)
        {
            Min = arr[i];
        }
        SumMaxMin = Max - Min;
    }
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] arr = GenerateArray(6, 1, 20);
PrintArray(arr);
FindMaxAndMin(arr,out int Max, out int Min, out int SumMaxMin);
System.Console.WriteLine($"Разница между макс и мин в массиве = {Max}-{Min} = {SumMaxMin}");

