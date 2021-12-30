using System;

namespace arrayTransposeArray
{
  class Program
  {
    static void Main(string[] args)
    {
      int i, j, r, c;
      int[,] arr1 = new int[50, 50];
      int[,] brr1 = new int[50, 50];
      Console.WriteLine("\n");
      Console.WriteLine("Transpose of matrix :");
      Console.WriteLine("\n");
      Console.WriteLine("Enter the number of rows :");
      r = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter the number of coloums :");
      c = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("\n");
      Console.WriteLine("Enter elements in the matrix :");
      for (i = 0; i < r; i++)
      {
        for (j = 0; j < c; j++)
        {
          Console.WriteLine($"Element - [{i}],[{j}] : ");
          arr1[i, j] = Convert.ToInt32(Console.ReadLine());
        }
      }
      Console.WriteLine("The first matrix is : ");
      for (i = 0; i < r; i++)
      {
        Console.Write("\n");
        for (j = 0; j < c; j++)
        {
          Console.Write($"{arr1[i, j]} \t");
        }
      }
      Console.Write("\n");
      Console.WriteLine("The transpose of matrix is : ");
      for (i = 0; i < r; i++)
      {
        Console.Write("\n");
        for (j = 0; j < c; j++)
        {
          brr1[j, i] = arr1[i, j];
          //Console.Write($"{brr1[i, j]} \t");
        }
      }
      for (i = 0; i < r; i++)
      {
        Console.Write("\n");
        for (j = 0; j < c; j++)
        {
          //brr1[j, i] = arr1[i, j];
          Console.Write($"{brr1[i, j]} \t");
        }
      }
    }
  }
}


