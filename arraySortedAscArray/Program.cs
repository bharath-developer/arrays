using System;

namespace arraySortedAscArray
{
  class Program
  {
    static void Main(string[] args)
    {
      int s1, s2, i, j;
      int[] arr1 = new int[100];
      int[] arr2 = new int[100];
      int[] arr3 = new int[100];
      Console.WriteLine("\n\n");
      Console.WriteLine("Merge two array sorted ascendingly :");
      Console.WriteLine("------------------------------------");
      Console.WriteLine("Enter the first array size :");
      s1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter the Second array size :");
      s2 = Convert.ToInt32(Console.ReadLine());
      for (i = 0; i < s1; i++)
      {
        Console.WriteLine($"Element {i + 1} : ");
        arr1[i] = Convert.ToInt32(Console.ReadLine());
      }
      for (i = 0; i < s2; i++)
      {
        Console.WriteLine($"Element {i + 1} : ");
        arr2[i] = Convert.ToInt32(Console.ReadLine());
      }
      int s3 = s1 + s2;
      for (i = 0; i < s1; i++)
      {
        arr3[i] = arr1[i];
      }
      for (j = 0; j < s2; j++)
      {
        arr3[i] = arr2[j];
        i++;
      }
      for (i = 0; i < s3 - 1; i++)
      {
        for (int k = 0; k < s3 - 1; k++)
        {
          if (arr3[k] >= arr3[k + 1])
          {
            j = arr3[k + 1];
            arr3[k + 1] = arr3[k];
            arr3[k] = j;
          }
        }
      }
      Console.WriteLine("The merged array in ascending order :");
      for (i = 0; i < s3; i++)
      {
        Console.Write("{0} ", arr3[i]);
      }
    }
  }
}
