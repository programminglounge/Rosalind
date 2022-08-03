using System;

public class Program
{
  public static int Main()
  {
    List<HashSet<int>> results = sets();
    Console.WriteLine();
    for (int i = 0; i< results.Count; i++)
    {
      int count = 1;
      HashSet<int> answer = results[i];
      Console.Write('{');
      foreach(int j in answer)
      {
        if (count != answer.Count)
        {
          Console.Write(j + ", ");
          count++;
        }
        else
        {
          Console.Write(j);
        }
    }
    Console.WriteLine('}');
  }
  public static List<HashSet<int>> sets()
  {
    HashSet<int> universe = new HashSet<int>();
    HashSet<int> A = new HashSet<int>();
    HashSet<int> B = new HashSet<int>();
    HashSet<int> AUB = new HashSet<int>();
    HashSet<int> ANB = new HashSet<int>();
    HashSet<int> AMinusB = new HashSet<int>();
    HashSet<int> BMinusA = new HashSet<int>();
    HashSet<int> APrime = new HashSet<int>();
    HashSet<int> BPrime = new HashSet<int>();
    int count = 0;
    string number = Console.ReadLine();
    count = Convert.ToInt32(number);
    for (int i = 1; i<=count; i++)
    {
      universe.Add(i);
    }
    string setA = Console.ReadLine();
    setA = setA.Substring(1, setA.Length-2);
    while (setA.Length > 0)
    {
      int index = setA.IndexOf(',');
      if (index>0)
      {
        int elementA = Convert.ToInt32(setA.Substring(0, index));
        A.Add(elementA);
        setA = setA.Substring(index+1);
      }
      else
      {
        int elementA = Convert.ToInt32(setA);
        A.Add(elementA);
        setA = "";
      }
    }
    string setB = Console.ReadLine();
    setB = setB.Substring(1, setB.Length - 2);
    while (setB.Length > 0)
    {
      int index = setB.IndexOf(',');
      if (index>0)
      {
        int elementB = Convert.ToInt32(setB.Substring(0, index));
        B.Add(elementB);
        setB = setB.Substring(index+1);
      }
      else
      {
        int elementB = Convert.ToInt32(setB);
        B.Add(elementB);
        setB = "";
      }
    }
    AUB.UnionWith(A);
    AUB.UnionWith(B);
    ANB.UnionWith(A);
    ANB.IntersectWith(B);
    AMinusB.UnionWith(A);
    AMinusB.ExceptWith(ANB);
    BMinusA.UnionWith(B);
    BMinusA.ExceptWith(ANB);
    APrime.UnionWith(universe);
    APrime.ExceptWith(A);
    BPrime.UnionWith(universe);
    BPrime.ExceptWith(B);
    List<HashSet<int>> result = new List<HashSet<int>>();
    result.Add(AUB);
    result.Add(ANB);
    result.Add(AMinusB);
    result.Add(BMinusA);
    result.Add(APrime);
    result.Add(BPrime);
    return result;
  }
}  
