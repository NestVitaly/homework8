// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[n, m];
int min = Convert.ToInt32(Int32.MaxValue);
int count = 0;
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
sum(numbers);
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
            if (j != arr.GetLength(1) - 1)
                Console.Write($"|{arr[i, j]}|, ");
            else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1)
                Console.WriteLine($"|{arr[i, j]}|");
            else if (j == arr.GetLength(1) - 1)
                Console.WriteLine($"|{arr[i, j]}|,");
        }
    }
}

void sum(int[,] number)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sum = sum + numbers[i, j];
        }
        if (sum < min)
        {
            min = sum;
            count++;
        }
    }
}
Console.WriteLine("Наименьшая сумма элементов: " + (min) + ", строка: " + (count));