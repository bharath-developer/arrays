using System;

namespace copyArrayToAnotherArray
{
  class Program
  {
    static void Main(string[] args)
    {
      int range;
      Console.WriteLine("\n\n");
      Console.WriteLine("Copy one array element to another :");
      Console.WriteLine("-----------------------------------");
      Console.WriteLine("\n\n");
      Console.Write("Enter the number of elements to be stored in an array : ");
      range = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("\n");
      Console.WriteLine($"Enter {range} elements in an array :");
      int[] values = new int[range];
      int[] copy = new int[range];
      for (int i = 0; i < values.Length; i++)
      {
        Console.Write($"Element - {i + 1} : ");
        values[i] = Convert.ToInt32(Console.ReadLine());
        copy[i] = values[i];
      }
      Console.WriteLine($"The elements stored in the first array");
      foreach (int j in values)
      {
        Console.Write($"{j} ");
      }
      Console.WriteLine($"\nThe elements copied into the second array are");
      foreach (int j in copy)
      {
        Console.Write($"{j} ");
      }
    }
  }
}
