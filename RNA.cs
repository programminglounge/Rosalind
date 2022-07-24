using System;
  
public class Program
{
  public static int Main()
  {
    string dna2 = "AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC";
    string dnatorna = dna2.Replace('T', 'U');
    Console.WriteLine(dnatorna);
  }
}
