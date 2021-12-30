using System;

namespace sumOfArrayElementsArray
{
  class Program
  {
    static void Main(string[] args)
    {
      int range;
      Console.WriteLine("\n\n");
      Console.WriteLine("Find the sum of all elements of the array :");
      Console.WriteLine("-------------------------------------------");
      Console.WriteLine("\n\n");
      Console.WriteLine("Enter the number of elements to be stored in an array :");
      range = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("\n");
      Console.WriteLine($"Enter {range} elements in the array:");
      int[] values = new int[range];
      int result = 0;
      for (int j = 0; j < values.Length; j++)
      {
        Console.Write($"Element - {j + 1} : ");
        values[j] = Convert.ToInt32(Console.ReadLine());
        result += values[j];
      }
      Console.WriteLine("Sum of all elements stored in the array : {0}", result);
    }
  }
}
