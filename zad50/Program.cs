// Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, 
//и возвращает его индексы первого найденого числа или же указание, что такого элемента нет.
Console.Clear();
Console.WriteLine("введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] matrix = GetRandomMatrixint(5, 5, 1, 10);
PrintMatrix(matrix);
IndexMatrix(matrix, num);

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
      Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
  }

}
void IndexMatrix(int[,] matrix, int numbers)
{
  int rows = 0;
  int columns = 0;
  int tmp = 1;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if ( matrix[i, j] != numbers )
        tmp = 0;
      else
      {
        rows = i; columns = j;
        Console.Write($"индекс строки = {rows} ; индекс столбца = {columns} ");
        return;
      }

    }

  }
  if (tmp == 0)
    Console.Write("такого элемента нет.");
}