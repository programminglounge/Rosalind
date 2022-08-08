using System;

public class Program
{

  public static List<int> sub2(List<int>input2, int index, int num)
  {
    List<List<int>> result = new List<List<int>>();
    List<int> x = new List<int>();
    List<int> y = new List<int>();
    for (int i = index+1; i<input2.Count; i++)
    {
      if (input2[i]> num)
      {
        y = x.ToList();
        x.Add(input2[i]);
        x = x.Concat(sub2(input2, i, input2[i])).ToList();
        result.Add(x);
        x = y.ToList();
      }
    }
    if (result.Count != 0)
    {
      result = result.OrderByDescending(x => x.Count).ToList();
      return result[0];
    }
    return x;
  }

  public static List<int> sub2(List<int>input2, int index, int num)
  {
    List<List<int>> result = new List<List<int>>();
    List<int> x = new List<int>();
    List<int> y = new List<int>();
    for (int i = index+1; i<input2.Count; i++)
    {
      if (input2[i]< num)
      {
        y = x.ToList();
        x.Add(input2[i]);
        x = x.Concat(sub3(input2, i, input2[i])).ToList();
        result.Add(x);
        x = y.ToList();
      }
    }
    if (result.Count != 0)
    {
      result = result.OrderByDescending(x => x.Count).ToList();
      return result[0];
    }
    return x;
  }

  public static List<List<int>> sub()
  {
    List<List<int>> result = new List<List<int>>();
    List<int> input = new List<int>();
    List<int> input_copy = new List<int>();
    List<List<int>> result2 = new List<List<int>>();
    string x = Console.ReadLine();
    int insert = Int32.Parse(x);
    for (int i = 0; i<insert; i++)
    {
      x = Console.ReadLine();
      int insert2 = Int32.Parse(x);
      input.Add(insert2);
    }
    for (int i = 0; i<input.Count; i++)
    {
      List<int> res = new List<int>();
      res.Add(input[i]);
      result.Add(res.Concat(sub2(input, i, input[i])).ToList());
    }
    result = result.OrderByDescending(x =>x.Count).ToList();
    result2.Add(result[0]);
    result.Clear();
    for (int i = 0; i<input.Count; i++)
    {
      List<int> res = new List<int>();
      res.Add(input[i]);
      result.Add(res.Concat(sub3(input, i, input[i])).ToList());
    }
    result = result.OrderByDescending( x=> x.Count).ToList();
    result2.Add(result[0]);
    return result2;
  }
  public static void Main()
  {
    List<List<int>> result = sub();
    List<int> increasing = result[0];
    List<int> decreasing = result[1];
    for (int i = 0; i<increasing.Count(); i++)
    {
      if (i != increasing.Count()-1)
      {
        Console.Write( increasing[i] + " ");
      }
      else
      {
        Console.WriteLine(increasing[i]);
      }
    }
    for (int i = 0; i<decreasing.Count(); i++)
    {
      if (i != decreasing.Count()-1)
      {
        Console.Write( decreasing[i] + " ");
      }
      else
      {
        Console.WriteLine(decreasing[i]);
      }
    }
  }
}
