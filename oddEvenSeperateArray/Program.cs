using System;

namespace oddEvenSeperateArray
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr1 = new int[100];
      int[] arr2 = new int[100];
      int[] arr3 = new int[100];
      int i, j = 0, k = 0, range;
      Console.WriteLine("\n");
      Console.WriteLine("Separate odd and even integers in arrays :");
      Console.WriteLine("------------------------------------------");
      Console.WriteLine("\n");
      Console.WriteLine("Enter the range of array :");
      range = Convert.ToInt32(Console.ReadLine());
      for (i = 0; i < range; i++)
      {
        Console.WriteLine($"Element - {i + 1} :");
        arr1[i] = Convert.ToInt32(Console.ReadLine());
      }
      for (i = 0; i < range; i++)
      {
        if (arr1[i] % 2 == 0)
        {
          arr2[j] = arr1[i];
          j++;
        }
        else
        {
          arr3[k] = arr1[i];
          k++;
        }
      }
      Console.WriteLine("The even elements are :");
      for (i = 0; i < j; i++)
      {
        Console.WriteLine($"{arr2[i]}");
      }
      Console.WriteLine("The odd elements are :");
      for (i = 0; i < k; i++)
      {
        Console.WriteLine($"{arr3[i]}");
      }
    }
  }
}
