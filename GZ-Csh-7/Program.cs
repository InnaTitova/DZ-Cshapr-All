// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// пример:
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// double[,] GenereteMatrix(int rows, int cols)
// {
//         double[,] matrix = new double [rows, cols];
//     Random rand = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(-100, 100) + Math.Round(rand.NextDouble(), 3);
//         }
//     }
//     return matrix;
// }


// void PrintMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine(); // вывод пустой строки, чтобы было красиво
//     }
// }

// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("Введите кличество столбцов: ");
// System.Console.WriteLine(); //пустая строка для красивого вывода
// double[,] MyMatrix = GenereteMatrix(rows, cols);
// PrintMatrix(MyMatrix);


// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine(); // вывод пустой строки, чтобы было красиво
//     }
// }

// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("Введите кличество столбцов: ");

// System.Console.WriteLine(); //пустая строка для красивого вывода
// int[,] MyMatrix = GenereteMatrix(rows, cols);
// PrintMatrix(MyMatrix);
// int irows = ReadInt("Введите позицию элемента в строке: ");
// int jcols = ReadInt("Введите позицию элемента в столбце: ");
// if (irows > MyMatrix.GetLength(0) || jcols > MyMatrix.GetLength(1))
// {
//     Console.WriteLine("такого элемента нет");
// }
// else
// {
//     Console.WriteLine($"значение элемента {irows} строки и {jcols} столбца равно {MyMatrix[irows - 1, jcols - 1]}");
// }


// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenereteMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 11);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine(); // вывод пустой строки, чтобы было красиво
    }
}

void MeanNumCols(int[,] arr)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, i];
        }
        double average = sum / arr.GetLength(0);
        Console.Write($"{average:f1}; ");
    }
}

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите кличество столбцов: ");

int[,] MyMatrix = GenereteMatrix(rows, cols);
PrintMatrix(MyMatrix);
System.Console.WriteLine(); //пустая строка для красивого вывода
MeanNumCols(MyMatrix);
