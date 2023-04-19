// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();
int[,] matrix = GetRandomMatrixint(3, 3, 1, 10);
PrintMatrix(matrix);
ArithmeticMeanColumns(matrix);
int[,] GetRandomMatrixint(int rows, int columns, int minValue, int maxValue)
{
  int[,] array = new int[rows, columns];

  var random = new Random();

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = random.Next(minValue, maxValue + 1);
    }
  }

  return array;
}
void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      System.Console.Write($"{matrix[i, j]} ");
    }
    System.Console.WriteLine();
  }

}
void ArithmeticMeanColumns(int[,] matrix)
{

  for (int i = 0; i < matrix.GetLength(1); i++)
  {
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
      sum += matrix[j, i];
    }
    sum /=  matrix.GetLength(0);
    Console.WriteLine($"Среднее арифметическое столбца {i} равняется {sum:F1}");
  }
}