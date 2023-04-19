// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();
double[,] matrix = GetRandomMatrixDouble(5, 5, 10, 99);
PrintMatrix(matrix);

double[,] GetRandomMatrixDouble(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];

    var random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round((random.Next(minValue, maxValue +1 ) + random.NextDouble()),1);
        }
    }

    return array;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
           Console.WriteLine();
    }

}
