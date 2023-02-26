// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
// ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int NumPositiv(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0)
//         {
//             count = count + 1;
//         }
//     }
//     return count;
// }
// System.Console.Write("Введите числа: ");
// int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// System.Console.Write($"Количество чисел больше нуля = {NumPositiv(array)}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных
//  уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double  GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double b1 = GetNumber("Введите b1: ");
double k1 = GetNumber("Введите k1: ");
double b2 = GetNumber("Введите b2: ");
double k2 = GetNumber("Введите k2: ");

double x = (b1 - b2) / (k2 - k1);
double y = k2 * ((b1 - b2) / (k2 - k1)) + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");