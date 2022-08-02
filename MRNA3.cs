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
    int[] map = new int[26];
    map[0] = 4; //A
    map[1] = 0; //B
    map[2] = 2; //C
    map[3] = 2; //D
    map[4] = 2; //E
    map[5] = 2; //F
    map[6] = 4; //G
    map[7] = 2; //H
    map[8] = 3; //I
    map[9] = 0; //J
    map[10] = 2; //K
    map[11] = 6; //L
    map[12] = 1; //M
    map[13] = 2; //N
    map[14] = 0; //O
    map[15] = 4; //P
    map[16] = 2; //Q
    map[17] = 6; //R
    map[18] = 6; //S
    map[19] = 4; //T
    map[20] = 0; //U
    map[21] = 4; //V
    map[22] = 1; //W
    map[23] = 0; //X
    map[24] = 2; //Y
    map[25] = 0; //Z
    for (int i = 0; i<rna.Length; i++)
    {
      count = count *map[rna[i]-'A'];
    }
    return count;
  }
}
