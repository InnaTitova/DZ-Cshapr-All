// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число
//  A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int GetNumber(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int a = GetNumber("Введите число A: ");
// int b = GetNumber("Введите число B: ");
// {
// if (b > 0)
// {
//     System.Console.Write("А в степени В = "  + Math.Pow(a, b));
// }
// else
// {
//     Console.Write("Введите положительное число больше 0");
// }
// }


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму
//  цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int GetNumber(string text)
// {
//     System.Console.Write(text);
//     string text1 = System.Console.ReadLine();
//     int result = int.Parse(text1); //преобразование текста в число
//     return result;
// }
// int SumNumber(int num)
// {
//     int result = 0;
//     while (num > 0)
//     {
//         result += num % 10;
//         num = num / 10;
//     }
//     return result;
// }
// int n = GetNumber("Введите число: ");
// System.Console.WriteLine($"Сумма всех цифр в числе {n} = {SumNumber(n)}");



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int GetNum(string text)
{
    System.Console.Write(text);
    string ReadText = System.Console.ReadLine();
    int result = int.Parse(ReadText); //преобразование текста в число
    return result;
}

int[] FillArray(int size, int min, int max)
{
    int[] arr1 = new int[size];
    Random ran = new Random();
    for (int i = 0; i < size; i++)
    {
        arr1[i] = ran.Next(min, max);
    }
    return arr1;
}
void PrintArray(int[] arr1)
{
    System.Console.Write("[");
    for (int i = 0; i < arr1.Length; i++)
    {
        System.Console.Write(arr1[i] + "," + " ");
     
    }
    System.Console.Write("]");
}

int size = GetNum("Введите длину массива: ");
int min = GetNum("Введите начало массива:");
int max = GetNum("Введите конец массива: ");
int [] arr1 = FillArray(size, min, max);
 PrintArray(arr1);
