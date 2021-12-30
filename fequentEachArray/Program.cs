using System;

namespace fequentEachArray
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr1 = new int[100];
      int[] fr1 = new int[100];
      int i, j, ctr, range;
      Console.WriteLine("\n");
      Console.WriteLine("Count the frequency of element in array :");
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("\n");
      Console.WriteLine("Enter the range of array :");
      range = Convert.ToInt32(Console.ReadLine());
      for (i = 0; i < range; i++)
      {
        Console.WriteLine("Element - {0} :", i + 1);
        arr1[i] = Convert.ToInt32(Console.ReadLine());
        fr1[i] = -1;
      }
      for (i = 0; i < range; i++)
      {
        ctr = 1;
        for (j = i + 1; j < range; j++)
        {
          if (arr1[i] == arr1[j])
          {
            ctr++;
            fr1[j] = 0;
          }
        }
        if (fr1[i] != 0)
        {
          fr1[i] = ctr;
        }
      }
      Console.WriteLine("Frequency of all elements of array :");
      for (i = 0; i < range; i++)
      {
        if (fr1[i] != 0)
        {
          Console.WriteLine($"{arr1[i]}  occurs {fr1[i]} times ");
        }
      }
    }
  }
}
