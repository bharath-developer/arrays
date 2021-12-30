using System;

namespace nNumberReverseArray
{
  class Program
  {
    static void Main(string[] args)
    {
      int value;
      Console.WriteLine("\n\n");
      Console.WriteLine("Reverse the n numbers :");
      Console.WriteLine("-----------------------");
      Console.WriteLine("Enter the number of elements to store in the array :");
      value = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine($"Input {value} elements in the array:");
      Console.WriteLine("-------------------------------------");
      int[] data = new int[value];
      for (int j = 0; j < data.Length; j++)
      {
        Console.WriteLine($"element - {j + 1} :");
        data[j] = Convert.ToInt32(Console.ReadLine());
      }
      Console.WriteLine("The values stored  into the array are:");
      foreach (int i in data)
      {
        Console.Write($"{i} ");
      }
      //   int[] reverse = Array.Reverse(data);
      Console.WriteLine("\nThe values stored  into the array in reverse are:");
      Array.Reverse(data);
      foreach (int i in data)
      {
        Console.Write($"{i} ");
      }
    }
  }
}
