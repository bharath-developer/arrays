using System;

namespace twodArrayPrintArray
{
  class Program
  {
    static void Main(string[] args)
    {
      int[,] data = new int[50, 50];
      int r, c, i, j;
      Console.WriteLine("\n");
      Console.WriteLine("Print two dimension array :");
      Console.WriteLine("---------------------------");
      Console.WriteLine("\n");
      Console.WriteLine("Enter the row of array :");
      r = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter the coloum of array :");
      c = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter the values of array :");
      for (i = 0; i < r; i++)
      {
        for (j = 0; j < c; j++)
        {
          Console.WriteLine($"Element - {i},{j} : ");
          data[i, j] = Convert.ToInt32(Console.ReadLine());
        }
      }
      Console.WriteLine("The matrix is :");
      for (i = 0; i < r; i++)
      {
        Console.Write("\n");
        for (j = 0; j < c; j++)
        {
          Console.Write($"{data[i, j]}\t");
        }
      }
      Console.WriteLine("");
    }
  }
}
