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
    SortedSet<int> AUB = new SortedSet<int>();
    foreach(int i in A.UnionBy(B, i=>i))
    {
      AUB.Add(i);
    }
    SortedSet<int> ANB = new SortedSet<int>();
    foreach(int i in A.IntersectBy(B, i=>i))
    {
      ANB.Add(i);
    }
    SortedSet<int> AMinusB = new SortedSet<int>();
    foreach(int i in A.ExceptBy(B, i=>i))
    {
      AMinusB.Add(i);
    }
    SortedSet<int> BMinusA = new SortedSet<int>();
    foreach(int i in B.ExceptBy(A, i=>i))
    {
      BMinusA.Add(i);
    }   
    SortedSet<int> APrime = new SortedSet<int>();
    foreach(int i in universe.ExceptBy(A, i=>i))
    {
      APrime.Add(i);
    }
    SortedSet<int> BPrime = new SortedSet<int>();
    foreach(int i in universe.ExceptBy(B, i=>i))
    {
      BPrime.Add(i);
    }
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
