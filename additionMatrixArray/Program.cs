using System;

namespace additionMatrixArray
{
  class Program
  {
    static void Main(string[] args)
    {
      int row, coloum;
      Console.WriteLine("\n");
      Console.WriteLine("Enter rows of  array :");
      row = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter coloums of array :");
      coloum = Convert.ToInt32(Console.ReadLine());
      int[,] first = new int[row, coloum];
      int[,] second = new int[row, coloum];
      int[,] sum = new int[row, coloum];
      Console.WriteLine("\n");
      Console.WriteLine("Enter values of first array :");
      for (int i = 0; i < row; i++)
      {
        for (int k = 0; k < coloum; k++)
        {
          Console.WriteLine($"Element {i},{k} : ");
          first[i, k] = Convert.ToInt32(Console.ReadLine());
        }
      }
      Console.WriteLine("Enter values of second array :");
      for (int i = 0; i < row; i++)
      {
        for (int k = 0; k < coloum; k++)
        {
          Console.WriteLine($"Element {i},{k} : ");
          second[i, k] = Convert.ToInt32(Console.ReadLine());
        }
      }

      Console.WriteLine("The first matrix is :");
      for (int i = 0; i < row; i++)
      {
        Console.Write("\n");
        for (int k = 0; k < coloum; k++)
        {
          Console.Write($"{first[i, k]}\t");
        }
      }
      Console.Write("\n");
      Console.WriteLine("The second matrix is :");
      for (int i = 0; i < row; i++)
      {
        Console.Write("\n");
        for (int k = 0; k < coloum; k++)
        {
          Console.Write($"{second[i, k]}\t");
        }
      }
      Console.Write("\n");
      Console.WriteLine("The Addition of two matrix is :");
      for (int i = 0; i < row; i++)
      {
        Console.Write("\n");
        for (int k = 0; k < coloum; k++)
        {
          sum[i, k] = first[i, k] + second[i, k];
          Console.Write($"{sum[i, k]}\t");
        }
      }
    }
  }
}
