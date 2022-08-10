using System;

public class Program
{
  public static long hamming(string DNA1, string DNA2)
  {
    long hamm = 0;
    for (int i = 0; i<DNA1.Length; i++)
    {
      if (DNA1[i] != DMA2[i])
      {
        hamm++;
      }
    }
    return hamm;
  }
  public static void Main()
  {
    string DNA1 = Console.ReadLine();
    string DNA2 = Console.ReadLine();
    Console.WriteLine(hamming(DNA1, DNA2));
  }
}
