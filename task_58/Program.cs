// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Введите количество строк для первой матрицы: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов для первой матрицы: ");
int m1 = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[n1, m1];
Console.WriteLine("Введите количество строк для второй матрицы: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов для второй матрицы: ");
int m2 = Convert.ToInt32(Console.ReadLine());
int[,] matrix2 = new int[n2, m2];
int[,] matrix3 = new int[n1, m2];
FillArrayRandomNumbers(matrix1);
FillArrayRandomNumbers(matrix2);
MatrixRes(matrix3);
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение двух матриц: ");
PrintArray(matrix3);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 11);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            
                Console.Write($"{arr[i, j]}, ");
/*

            if (j != arr.GetLength(1) - 1)
                Console.Write($"({arr[i, j]}, ");
            else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1)
                Console.Write($"{arr[i, j]})");
            else if (j == arr.GetLength(1) - 1)
                Console.Write($"{arr[i, j]}),");
                */
        }
        Console.WriteLine("");
    }
}


void MatrixRes (int[,] numbers)
{
    if (m1 == n2)
    {
        for(int i = 0; i < n1; i++)
        {
            for(int j = 0; j < m2; j++)
            {
                int sum = 0;
                for(int k = 0; k <m1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                
                    matrix3[i, j] = sum;
            }
        }
    }
}