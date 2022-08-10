using System;

public class Program
{
  public static void Main()
  {
    string mrna;
    Console.WriteLine("Enter the mRNA");
    mrna = Console.ReadLine();
    string protein = rna2protein(mrna);
    Console.WriteLine(protein);
  }
  public static string rna2protein (string s)
  {
    if (s.Length % 3 == 0)
    {
      int x = s.Length / 3;
      string result = "";
      Dictionary <string, string> map = new Dictionary<string, string>();
      map.Add ("UUU", "F");
      map.Add ("UUC", "F");
      map.Add ("UUA", "L");
      map.Add ("UUG", "L");
      map.Add ("UCU", "S");
      map.Add ("UCC", "S");
      map.Add ("UCA", "S");
      map.Add ("UCG", "S");
      map.Add ("UAU", "Y");
      map.Add ("UAC", "Y");
      map.Add ("UAA", "");
      map.Add ("UAG", "");
      map.Add ("UGU", "C");
      map.Add ("UGC", "C");
      map.Add ("UGA", "");
      map.Add ("UGG", "W");
      map.Add ("CUU", "L");
      map.Add ("CUC", "L");
      map.Add ("CUA", "L");
      map.Add ("CUG", "L");
      map.Add ("CCU", "P");
      map.Add ("CCC", "P");
      map.Add ("CCA", "P");
      map.Add ("CCG", "P");
      map.Add ("CAU", "H");
      map.Add ("CAC", "H");
      map.Add ("CAA", "Q");
      map.Add ("CAG", "Q"); 
      map.Add ("CGU", "R");
      map.Add ("CGC", "R");
      map.Add ("CGA", "R");
      map.Add ("CGG", "R");
      map.Add ("AUU", "I");
      map.Add ("AUC", "I");
      map.Add ("AUA", "I");
      map.Add ("AUG", "M");
      map.Add ("ACU", "T");
      map.Add ("ACC", "T");
      map.Add ("ACA", "T");
      map.Add ("ACG", "T");
      map.Add ("AAU", "N");
      map.Add ("AAC", "N");
      map.Add ("AAA", "K");
      map.Add ("AAG", "K");
      map.Add ("AGU", "S");
      map.Add ("AGC", "S");
      map.Add ("AGA", "R");
      map.Add ("AGG", "R");
      map.Add ("GUU", "V");
      map.Add ("GUC", "V");
      map.Add ("GUA", "V");
      map.Add ("GUG", "V");
      map.Add ("GCU", "A");
      map.Add ("GCC", "A");
      map.Add ("GCA", "A");
      map.Add ("GCG", "A");
      map.Add ("GAU", "D");
      map.Add ("GAC", "D");
      map.Add ("GAA", "E");
      map.Add ("GAG", "E");
      map.Add ("GGU", "G");
      map.Add ("GGC", "G");
      map.Add ("GGA", "G");
      map.Add ("GGG", "G");
      for (int i = 0; i<x; i++)
      {
        string cons = s.Substring(i*3, 3);
        result = result + map[cons];
      }
      return result;
    }
    return "";
  }
}
