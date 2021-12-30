using System;

namespace minAndMaxInArray
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr1 = new int[100];
      int range, i, mx, mn;
      Console.WriteLine("\n");
      Console.WriteLine("Minimum and maximum in array :");
      Console.WriteLine("------------------------------");
      Console.WriteLine("\n");
      Console.WriteLine("Enter the range of array :");
      range = Convert.ToInt32(Console.ReadLine());
      for (i = 0; i < range; i++)
      {
        Console.WriteLine($"Element - {i + 1} :");
        arr1[i] = Convert.ToInt32(Console.ReadLine());
      }
      mx = arr1[0];
      mn = arr1[0];
      for (i = 0; i < range; i++)
      {
        if (arr1[i] > mx)
        {
          mx = arr1[i];
        }
        if (arr1[i] < mn)
        {
          mn = arr1[i];
        }
      }
      Console.WriteLine($"Mamimum element is : {mx}");
      Console.WriteLine($"Minimum element is : {mn}");
    }
  }
}
