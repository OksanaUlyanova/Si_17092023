// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    //                        0       1
    int[,] matrix = new int[rows, columns]; 
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}
// оптимизированный вариант
int SumMatrix(int[,] matrix)
{
    int size = matrix.GetLength(1);
    if (matrix.GetLength(0) < matrix.GetLength(1)) size = matrix.GetLength(0);
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

// неоптимизированный вариант
// int SumOnDiagonalVer2(int[,] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum += arr[i, j];
//             }
//         }
//     }
//     return sum;
// }

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // GetLength(0) -  функционал для определения количества строк 0 - 3 строки
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)  // GetLength(1) -  функционал для определения количества столбцов 0 - 4 столбца
        {
            Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine("  |");
    }
}
int[,] matr = CreateMatrixRndInt(5, 4, 1, 10);
PrintMatrix(matr);

int sumMatrix = SumMatrix(matr);
Console.WriteLine($"Сумма элементов на главной диагонали равна - {sumMatrix}");