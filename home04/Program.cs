// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
int[, ] CreateMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int x = new Random().Next(-100, 101);
            matrix[i , j] = x;
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }

    return matrix;
}


void CheckMatrix(int i, int j, int[, ] matrix)
{
    if (i < matrix.GetLength(0) && j < matrix.GetLength(1) && i >= 0 && j >= 0)
        Console.WriteLine(matrix[i, j]);
    else
        Console.WriteLine("Error");
}

int[, ] matrix = new int[4, 4];
matrix = CreateMatrix(matrix);
Console.WriteLine("Enter coordinates: ");
int i = Convert.ToInt32(Console.ReadLine());
int j = Convert.ToInt32(Console.ReadLine());
CheckMatrix(i, j, matrix);