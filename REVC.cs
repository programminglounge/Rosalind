using System;
  
public class Program
{
  public static int Main()
  {
    string dna = "AAAACCCGGT";
    string reversecomplement = complementing(dna);
    Console.WriteLine(reversecomplement);
  }
  public static string complementing (string s)
  {
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    for (int i = 0; i<s.Length; i++)
    {
      if (charArray[i] == 'A')
        charArray[i] = 'T';
      else if (charArray[i] == 'C')
        charArray[i] = 'G';
      else if (charArray[i] == 'G')
        charArray[i] = 'C';
      else if (charArray[i] == 'T')
        charArray[i] = 'A';
    }
    string reverse = new string(charArray);
    return reverse;
  }
}
