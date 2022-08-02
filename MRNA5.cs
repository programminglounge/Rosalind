using System;
  
public class Program
{
  public static int Main()
  {
    string mrna;
    Console.WriteLine("Enter the mRNA")
    mrna = Console.ReadLine();
    long number = mrnareverse (mrna);
    Console.WriteLine(number);
  }
  public static long mrnareverse (string rna)
  {
    long count = 3;
    Dictionary<char, int> map = new Dictionary<char, int>();
    map.Add('F', 2);
    map.Add('L', 6);
    map.Add('S', 6);
    map.Add('P', 4);
    map.Add('Y', 2);
    map.Add('I', 3);
    map.Add('V', 4);
    map.Add('A', 4);
    map.Add('T', 4);
    map.Add('G', 4);
    map.Add('R', 6);
    map.Add('K', 2);
    map.Add('D', 2);
    map.Add('N', 2);
    map.Add('E', 2);
    map.Add('Q', 2);
    map.Add('H', 2);
    map.Add('C', 3);
    map.Add('W', 1);
    map.Add('M', 1);
    for (int i = 0; i<rna.Length; i++)
    {
      count = count * map[rna[i]];
    }
    return count;
  }
}
