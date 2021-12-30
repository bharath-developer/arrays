using System;

namespace printUniqueInArray
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("\n\n");
      int n, ctr = 0;
      int[] arr = new int[100];
      int i, j, k;
      Console.WriteLine("Print all unique elements of array :");
      Console.WriteLine("------------------------------------");
      Console.WriteLine("\n");
      Console.WriteLine("Enter the number of elements to be stored in an array :");
      n = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine($"Enter {n} elements in the array : ");
      for (i = 0; i < n; i++)
      {
        Console.WriteLine("Element {0} :", n);
        arr[i] = Convert.ToInt32(Console.ReadLine());
      }
      Console.WriteLine("The unique elements found in the array are :");
      for (i = 0; i < n; i++)
      {
        ctr = 0; j = 0;
        for (j = 0; j < i - 1; j++)
        {
          if (arr[i] == arr[j])
            ctr++;
        }
        for (k = i + 1; k < n; k++)
        {
          if (arr[i] == arr[k])
          {
            ctr++;
          }
          if (arr[i] == arr[i + 1])
          {
            i++;
          }
        }
        if (ctr == 0)
        {
          Console.WriteLine($"{arr[i]}");
        }
      }

      Console.WriteLine("\n\n");
    }
  }
}
