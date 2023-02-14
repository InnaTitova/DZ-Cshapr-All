﻿// -------Задача 19------
// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// System.Console.WriteLine("Enter number : ");
// string number = Console.ReadLine();
// if (number is not null)
// {
//     if (number.Length == 5)
//     {
//         if ((number[0] == number[4]) && (number[1] == number[3]))
//         {
//             Console.WriteLine("Число является палиндромом");
//         }
//         else
//         {
//             Console.WriteLine("Число не является палиндром");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Введено не 5-значное число");
//     }
// }


// -------Задача 21-----
// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int ImputNum(string strxyz) 
// {
//     System.Console.WriteLine(strxyz);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int x1 = ImputNum("Enter ax: "); 
// int y1 = ImputNum("Enter ay: ");
// int z1 = ImputNum("Enter az: ");
// int x2 = ImputNum("Enter bx: ");
// int y2 = ImputNum("Enter by: ");
// int z2 = ImputNum("Enter bz: ");

// System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2)), 2));


// -----------Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов 
// чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void PrintSquares(int x)
{
for (int i = 1; i <= x; i++)
{
System.Console.Write(Math.Pow(i, 3) + ", ");
}
}

System.Console.WriteLine("Введите число N");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
PrintSquares(a);