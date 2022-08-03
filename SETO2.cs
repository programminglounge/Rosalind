using System;

public class Program
{
  public static int Main()
  {
    List<SortedSet<int>> results = sets();
    Console.WriteLine();
    for (int i = 0; i< results.Count; i++)
    {
      int count = 1;
      SortedSet<int> answer = results[i];
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
  public static List<SortedSet<int>> sets()
  {
    SortedSet<int> universe = new SortedSet<int>();
    SortedSet<int> A = new SortedSet<int>();
    SortedSet<int> B = new SortedSet<int>();
    SortedSet<int> AUB = new SortedSet<int>();
    SortedSet<int> ANB = new SortedSet<int>();
    SortedSet<int> AMinusB = new SortedSet<int>();
    SortedSet<int> BMinusA = new SortedSet<int>();
    SortedSet<int> APrime = new SortedSet<int>();
    SortedSet<int> BPrime = new SortedSet<int>();
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
    List<SortedSet<int>> result = new List<SortedSet<int>>();
    result.Add(AUB);
    result.Add(ANB);
    result.Add(AMinusB);
    result.Add(BMinusA);
    result.Add(APrime);
    result.Add(BPrime);
    return result;
  }
}  
