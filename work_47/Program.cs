// Задача 47. Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.

Console.Write("Введите количество строк массива : ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива : ");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];

GetArrayDouble(array);

WriteArray(array);

Console.WriteLine();

void GetArrayDouble(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}

void WriteArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double Number = Math.Round(array[i, j], 1);
            Console.Write(Number + " ");
        }
        Console.WriteLine();
    }
}