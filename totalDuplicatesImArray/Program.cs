using System;

namespace totalDuplicatesImArray
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr1 = new int[100];
      int[] arr2 = new int[100];
      int[] arr3 = new int[100];
      int s1, s2, i, j, mm = 1, ctr = 0;
      Console.WriteLine("Count total number of duplicate elements in an array :");
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("Enter the elements need to be stored in an array :");
      s1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine($"Enter {s1} elements in array :");
      for (i = 0; i < s1; i++)
      {
        Console.WriteLine($"Element - {i + 1} :");
        arr1[i] = Convert.ToInt32(Console.ReadLine());
      }
      for (i = 0; i < s1; i++)
      {
        arr2[i] = arr1[i];
        arr3[i] = 0;
      }
      for (i = 0; i < s1; i++)
      {
        for (j = 0; j < s1; j++)
        {
          if (arr1[j] == arr2[j])
          {
            arr3[j] = mm;
            mm++;
          }
        }
        mm = 1;
      }
      for (i = 0; i < s1; i++)
      {
        if (arr3[i] == 2)
        {
          ctr++;
        }
      }
      Console.WriteLine($"The number of duplicate elements is {ctr}");

      Console.ReadLine();
    }
  }
}
