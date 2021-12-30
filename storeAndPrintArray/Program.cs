using System;

namespace storeAndPrintArray
{
  class Program
  {
    static void Main(string[] args)
    {

      int[] data = new int[10];
      int[] result = new int[10];
      Console.WriteLine("Read and Print elements of an array:");
      Console.WriteLine("------------------------------------");
      Console.WriteLine("Input 10 elements in the array :");
      for (int j = 0; j < data.Length; j++)
      {
        Console.WriteLine($"element - {j+1} ");
        result[j] = Convert.ToInt32(Console.ReadLine());
      }
      Console.Write("Elements in an array are : ");
      foreach (int i in result)
      {
        Console.Write($"{i} ");
      }
      Console.ReadLine();
    }
  }
}
