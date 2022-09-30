// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int arrayRow = 2;
int arrayCol = 2;
int arrayDep = 2;
int min = 10;
int max = 99;
int[,,] CreateMatrix(int arrayRow, int arrayCol, int arrayDep, int min, int max)
{
    int[,,] matrix = new int[arrayRow, arrayCol, arrayDep];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max + 1);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.WriteLine($"{matrix[i, j, k],1} ({i}, {j}, {k})");
            }
        }
        Console.WriteLine();
    }
}

int[,,] array3D = CreateMatrix(arrayRow, arrayCol, arrayDep, min, max);
PrintMatrix(array3D);