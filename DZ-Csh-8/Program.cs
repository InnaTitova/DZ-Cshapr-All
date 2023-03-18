// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
//  каждой строки двумерного массива.Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenereteMatrix(int rows, int cols)
// {
//     Random rand = new Random();
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(0, 11);
//         }
//     }
//     return matrix;
// }

// void SortArrayNumbers(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t"); // \t - Это ТАБУЛЯЦИЯ для красивого вывода
//         }
//         System.Console.WriteLine(); // вывод пустой строки, чтобы было красиво
//     }
// }

// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("Введите кличество столбцов: ");
// var MyMatrix = GenereteMatrix(rows, cols);
// PrintMatrix(MyMatrix);
// System.Console.WriteLine(); //пустая строка для красивого вывода
// SortArrayNumbers(MyMatrix);
// PrintMatrix(MyMatrix);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет
//  находить строку с наименьшей суммой элементов.Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка.

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenereteMatrix(int rows, int cols)
// {
//     Random rand = new Random();
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(0, 11);
//         }
//     }
//     return matrix;
// }

// int[] StringsNum(int [,] arr)
// {
//     int[] result = new int[arr.GetLength(0)];
//     int stringSum = new int();

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             stringSum += arr[i, j]; 
//         }
//         result[i] = stringSum;
//         stringSum = 0;
//     }

//     return result;

// }

// void MinStringNum(int[] arr)
// {
//     int result = new int();
//     int min = arr.Min();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] == min) result = i + 1;
//     }

//     Console.WriteLine($"Номер строки с наименьшей суммой элементов: {result}");
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t"); // \t - Это ТАБУЛЯЦИЯ для красивого вывода
//         }
//         System.Console.WriteLine(); // вывод пустой строки, чтобы было красиво
//     }
// }

// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("Введите кличество столбцов: ");
// var MyMatrix = GenereteMatrix(rows, cols);
// PrintMatrix(MyMatrix);
// System.Console.WriteLine(); //пустая строка для красивого вывода
// MinStringNum(StringsNum(MyMatrix));

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
// int[,,] GenereteMatrix(int rows, int cols, int xbz) - такой код не работает!!!
// {
//     Random rand = new Random();
//     int[,,] matrix = new int[rows, cols, xbz];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int x = 0; x < matrix.GetLength(2); x++)
//             {
//                 matrix[i, j, x] = rand.Next(10, 100);
//             }
//         }
//     }
//     return matrix;
// }
void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 20);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
void PrintNumber(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} ({i},{j},{k})"+"\t");
            }
        }
        Console.WriteLine();
    }

}
 

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int x = 0; x < matrix.GetLength(2); x++)
            {
                System.Console.Write(matrix[i, j, x] + "\t");
            }
        }
        System.Console.WriteLine(); // вывод пустой строки, чтобы было красиво
    }
    System.Console.WriteLine(); // вывод пустой строки, чтобы было красиво
}
// int rows = 2;
// int cols = 2;
// int xbz = 2;
int rows = ReadInt("Введите координату х: ");
int cols = ReadInt("Введите координату y: ");
int xbz = ReadInt("Введите координату z: ");

// var MyMatrix = GenereteMatrix(rows, cols, xbz);
int[,,] MyMatrix = new int[rows, cols, xbz];
CreateArray(MyMatrix);
PrintMatrix(MyMatrix);
PrintNumber(MyMatrix);
