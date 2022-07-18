// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
double[,] a = new double[n, m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        a[i, j] = new Random().NextDouble() * 20 - 10;
        Console.Write("{0,6:F2}", a[i, j]);
    }
    Console.WriteLine();
}

