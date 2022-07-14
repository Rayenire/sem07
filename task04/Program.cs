int[, ] CreateMatr(int n, int m)
{
    int[, ] matrix = new int[n ,m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
            //matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}


void PrintMatr(int[, ] matrix)
{
    Console.WriteLine();
    int DiagonSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
                DiagonSum = DiagonSum + matrix[i, j];
        }
    }
    Console.WriteLine(DiagonSum);
}

int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
PrintMatr(CreateMatr(n, m));
