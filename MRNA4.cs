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
    for (int i = 0; i<rna.Length; i++)
    {
      switch(rna[i]
      {
        case 'F':
          count = count * 2;
          break;
        case 'L':
          count = count * 6;
          break;
        case 'S':
          count = count * 6;
          break;
        case 'P':
          count = count * 4;
          break;
        case 'Y':
          count = count * 2;
          break;
        case 'I':
          count = count * 3;
          break;
        case 'V':
          count = count * 4;
          break;
        case 'A':
          count = count * 4;
          break;
        case 'T':
          count = count * 4;
          break;
        case 'G':
          count = count * 4;
          break;
        case 'R':
          count = count * 6;
          break;
        case 'K':
          count = count * 2;
          break;
        case 'D':
          count = count * 2;
          break;
        case 'N':
          count = count * 2;
          break;
        case 'E':
          count = count * 2;
          break;
        case 'Q':
          count = count * 2;
          break;
        case 'H':
          count = count * 2;
          break;
        case 'C':
          count = count * 2;
          break;
        case 'W':
          count = count * 1;
          break;
        case 'M':
          count = count * 1;
          break;
      }
    }
    return count;
  }
}
