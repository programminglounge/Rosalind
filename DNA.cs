using System;
  
public class Program
{
  public static int Main()
  {
    string dna = "AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC";
    int[] result = counts(dna);
    for (int i = 0; i< result.Length; i++)
    {
      Console.Write(results[i].ToString() + " ");
    }
    Console.WriteLine();
  }
  public static int[] counts(string s)
  {
    int[] nums = new int[4];
    for (int i= 0; i<4; i++)
    {
      nums[i] = 0;
    }
    for (int i = 0; i<s.Length; i++)
    {
      if (s[i] == 'A')
        nums[0]++;
      if (s[i] == 'C')
        nums[1]++;
      if (s[i] == 'G')
        nums[2]++;
      if (s[i] == 'T')
        nums[3]++;
    }
    return nums;
  }
}
