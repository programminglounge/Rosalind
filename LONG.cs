using System;

public class Program
{

  public static string findstem (string x, string y)
  {
    int len_x = x.Length;
    int len_y = y.Length;
    int result = 0;
    int end = 0;
    int [, ] len = new int[2, Math.Max(len_x, len_y)+1];
    int current_row = 0;
    for (int i = 0; i<=len_x; i++)
    {
      for (int j = 0; j<= len_y; j++)
      {
        if (i == 0 || j == 0)
        {
          len[current_row, j] = 0;
        }
        else if (x[i-1] == y[j-1])
        {
          len[current_row, j] = len[1-current_row, j-1]+1;
          if (len[current_row, j] >result)
          {
            result = len[current_row, j];
            end = i-1;
          }
        }
        else
        {
          len[current_row, j] = 0;
        }
      }
      current_row = 1 - current_row;
    }
    if (result == 0)
    {
      return "-1";
    }
    return x.Substring(end-result+1, result);
  }
  public static string findmax(List<string> dnas)
  {
    List<string> dnas_copy = new List<string>();
    List<Tuple<string, int, int>> dnas2 = new List<Tuple<string, int, int>>();
    List<string> results = new List<string>();
    dnas_copy = dnas.ToList();
    for (int i = 0; i< dnas.Count; i++)
    {
      for (int j = i+1; j<dnas.Count; j++)
      {
        Tuple<string, int, int> x2 = new Tuple<string, int, int>(findstem(dnas[i], dnas[j]), i, j);
        dnas2.Add(x2);
      }
    }
    if (dnas2.Count == 1)
    {
      if (dnas2[0].Item1 == dnas_copy[0])
      {
        return dnas_copy[1];
      }
      else if (dnas2[0].Item1 == dnas_copy[1])
      {
        return dnas_copy[0];
      }
      else
      {
        int index = dnas[0].IndexOf(dnas2[0].Item1);
        int index2 = dnas[1].IndexOf(dnas2[0].Item1);
        string combo = "";
        if (index2 == 0)
        {
          string cutom = dnas[1].Substring(dnas2[0].Item1.Length;
          combo = dnas[0] + custom;
        }
        else if (index == 0)
        {
          string cutom = dnas[0].Substring(dnas2[0].Item1.Length;
          combo = dnas[1] + custom;
        }
        else
        {
          combo = dnas[0]+dnas[1];
        }
        return combo;
      }
    }
    dnas2 = dnas2.OrderByDescending(x =>x.Item1.Length).ToList();
    for (int u = 0; i<dnas2.Count; i++)
    {
      int first = dnas2[i].Item2;
      int second = dnas2[i].Item3;
      if (dnas2[i].Item1 == dnas_copy[first])
      {
        dnas_copy.RemoveAt(first);
        string s = findmax(dnas_copy);
        return s;
      }
      else if (dnas2[i].Item1 == dnas_copy[second])
      {
        dnas_copy.RemoveAt(second);
        string s = findmax(dnas_copy);
        return s;
      }
      else
      {
        int index = dnas[first].IndexOf(dnas2[i].Item1);
        int index2 = dnas[second].IndexOf(dnas2[i].Item1);
        string combo = "";
        if (index2 == 0)
        {
          string custom = dnas[second].Substring(dnas2[i].Item1.Length);
          combo = dnas[first] + custom;
        }
        else if (index == 0)
        {
          string custom = dnas[first].Substring(dnas2[i].Item1.Length);
          combo = dnas[second] + custom;
        }
        else
        {
          combo = dnas[first] + dnas[second];
        }
        dnas_copy.RemoveAt(first);
        dnas_copy.RemoveAt(second-1);
        dnas.copy.Add(combo);
        string s = findmax(dnas_copy);
        results.Add(s);
        dnas_copy = dnas.ToList();
      }
    }
    results = results.OrderBy(x => x.Length).ToList();
    return results[0];
  }
  public static void Main()
  {
    string dnaname = " ";
    string dnastring = " ";
    while(dnaname != "")
    {
      dnaname = Console.ReadLine();
      if (dnaname != "")
      {
        dnastring = Console.ReadLine();
        dnas.Add(dnastring);
      }
      else
      {
        break;
      }
    }
    string super_string = findmax(dnas);
    Console.WriteLine(super_string);
  }
}
