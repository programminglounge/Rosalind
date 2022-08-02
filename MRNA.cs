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
  public static long mrnareverse(string rna)
  {
    long count = 3;
    List<Tuple<char, int>>map = new List<Tuple<char, int>>();
    map.Add(new Tuple<char, int>('F', 2));
    map.Add(new Tuple<char, int>('L', 6));
    map.Add(new Tuple<char, int>('S', 6));
    map.Add(new Tuple<char, int>('P', 4));
    map.Add(new Tuple<char, int>('Y', 2));
    map.Add(new Tuple<char, int>('I', 3));
    map.Add(new Tuple<char, int>('V', 4));
    map.Add(new Tuple<char, int>('A', 4));
    map.Add(new Tuple<char, int>('T', 4));
    map.Add(new Tuple<char, int>('G', 4));
    map.Add(new Tuple<char, int>('R', 6));
    map.Add(new Tuple<char, int>('K', 2)); 
    map.Add(new Tuple<char, int>('D', 2));
    map.Add(new Tuple<char, int>('N', 2));
    map.Add(new Tuple<char, int>('E', 2));
    map.Add(new Tuple<char, int>('Q', 2));
    map.Add(new Tuple<char, int>('H', 2));
    map.Add(new Tuple<char, int>('C', 2));
    map.Add(new Tuple<char, int>('W', 1));
    map.Add(new Tuple<char, int>('M', 1));
    for (int i = 0; i<rna.Length; i++)
    {
      Tuple<char, int> x = map.Find(x=>x.Item1 == rna[i]);
      count = count *x.Item2;
    }
    return count;
  }
}
